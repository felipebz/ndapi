using System.Reflection;
using System.Runtime.Loader;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

using NdapiSourceGenerator;

using Xunit;

namespace Ndapi.UnitTests;

public class NdapiPropertyGeneratorTests
{
    // Stand-in for the Ndapi members the generated accessors call: it records each call, so the tests check which
    // Forms property every generated getter and setter reaches.
    private const string Api = """
        namespace Ndapi.Core
        {
            public enum NdapiConstant { D2FP_TEXT, D2FP_SIZE, D2FP_ENABLED, D2FP_STYLE, D2FP_OWNER, D2FP_CHILDREN, D2FP_LABEL }

            [System.AttributeUsage(System.AttributeTargets.Property)]
            internal sealed class PropertyAttribute(NdapiConstant propertyId) : System.Attribute
            {
                public NdapiConstant PropertyId { get; } = propertyId;
            }
        }

        namespace Ndapi
        {
            using System;
            using System.Collections.Generic;
            using Ndapi.Core;

            public enum Style { Plain, Bold }

            public sealed class NdapiObjectList<T> where T : NdapiObject { }

            public abstract class NdapiObject
            {
                public List<string> Calls { get; } = [];

                public string? GetStringProperty(NdapiConstant p) { Calls.Add($"get string {p}"); return "text"; }
                public void SetStringProperty(NdapiConstant p, string? v) => Calls.Add($"set string {p}={v}");
                public int GetNumberProperty(NdapiConstant p) { Calls.Add($"get number {p}"); return 7; }
                public void SetNumberProperty(NdapiConstant p, int v) => Calls.Add($"set number {p}={v}");
                public T GetNumberProperty<T>(NdapiConstant p) where T : struct, Enum { Calls.Add($"get enum {p}"); return default; }
                public void SetNumberProperty<T>(NdapiConstant p, T v) where T : struct, Enum => Calls.Add($"set enum {p}={v}");
                public bool GetBooleanProperty(NdapiConstant p) { Calls.Add($"get bool {p}"); return true; }
                public void SetBooleanProperty(NdapiConstant p, bool v) => Calls.Add($"set bool {p}={v}");
                public T? GetObjectProperty<T>(NdapiConstant p) where T : NdapiObject { Calls.Add($"get object {p}"); return null; }
                public void SetObjectProperty<T>(NdapiConstant p, T? v) where T : NdapiObject => Calls.Add($"set object {p}");
                public NdapiObjectList<T> GetObjectList<T>(NdapiConstant p) where T : NdapiObject { Calls.Add($"get list {p}"); return new(); }
            }

            public partial class Sample : NdapiObject
            {
                [Property(NdapiConstant.D2FP_TEXT)] public partial string? Text { get; set; }
                [Property(NdapiConstant.D2FP_SIZE)] public partial int Size { get; set; }
                [Property(NdapiConstant.D2FP_ENABLED)] public partial bool Enabled { get; set; }
                [Property(NdapiConstant.D2FP_STYLE)] public partial Style Style { get; set; }
                [Property(NdapiConstant.D2FP_OWNER)] public partial Sample? Owner { get; set; }
                [Property(NdapiConstant.D2FP_CHILDREN)] public partial NdapiObjectList<Sample> Children { get; }
                [Property(NdapiConstant.D2FP_LABEL)] public partial string? Label { get; }
            }
        }
        """;

    [Fact]
    public void GeneratedAccessorsReachTheDeclaredProperty()
    {
        var sample = CompileSample(out var type);

        Set("Text", "abc");
        Set("Size", 3);
        Set("Enabled", false);
        Set("Style", Enum.ToObject(type.Assembly.GetType("Ndapi.Style")!, 1));
        Set("Owner", sample);
        foreach (var property in new[] { "Text", "Size", "Enabled", "Style", "Owner", "Children", "Label" })
        {
            type.GetProperty(property)!.GetValue(sample);
        }

        Assert.Equal(
        [
            "set string D2FP_TEXT=abc", "set number D2FP_SIZE=3", "set bool D2FP_ENABLED=False",
            "set enum D2FP_STYLE=Bold", "set object D2FP_OWNER",
            "get string D2FP_TEXT", "get number D2FP_SIZE", "get bool D2FP_ENABLED", "get enum D2FP_STYLE",
            "get object D2FP_OWNER", "get list D2FP_CHILDREN", "get string D2FP_LABEL"
        ], (List<string>)type.GetProperty("Calls")!.GetValue(sample)!);
        return;

        void Set(string property, object? value) => type.GetProperty(property)!.SetValue(sample, value);
    }

    [Fact]
    public void GetOnlyPropertiesStayReadOnly()
    {
        CompileSample(out var type);

        Assert.False(type.GetProperty("Children")!.CanWrite);
        Assert.False(type.GetProperty("Label")!.CanWrite);
    }

    private static object CompileSample(out Type type)
    {
        var parseOptions = new CSharpParseOptions(LanguageVersion.Latest);
        var compilation = CSharpCompilation.Create("Sample",
            [CSharpSyntaxTree.ParseText(Api, parseOptions)],
            FrameworkReferences(),
            new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary,
                nullableContextOptions: NullableContextOptions.Enable));

        CSharpGeneratorDriver.Create([new NdapiPropertyGenerator().AsSourceGenerator()], parseOptions: parseOptions)
            .RunGeneratorsAndUpdateCompilation(compilation, out var output, out var generatorDiagnostics);

        Assert.Empty(generatorDiagnostics);
        using var stream = new MemoryStream();
        var result = output.Emit(stream);
        Assert.True(result.Success,
            string.Join(Environment.NewLine, result.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error)));

        stream.Position = 0;
        var assembly = new AssemblyLoadContext("Sample", isCollectible: true).LoadFromStream(stream);
        type = assembly.GetType("Ndapi.Sample")!;
        return Activator.CreateInstance(type)!;
    }

    // only the framework: the test's own dependencies include the real Ndapi, whose types would clash with the stand-in
    private static IEnumerable<MetadataReference> FrameworkReferences()
    {
        var runtimeDirectory = Path.GetDirectoryName(typeof(object).Assembly.Location)!;
        return ((string)AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES")!)
            .Split(Path.PathSeparator)
            .Where(path => Path.GetDirectoryName(path) == runtimeDirectory)
            .Select(path => MetadataReference.CreateFromFile(path));
    }
}
