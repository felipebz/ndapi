using Ndapi.Core;
using Ndapi.Metadata;

using Xunit;

namespace Ndapi.Tests;

// Known differences live in Coverage/forms{major}.txt, one per line: "uncovered Class D2FP_X" (the object has the
// property, Ndapi has no typed member) or "inapplicable Class D2FP_X" (typed member, but the object lacks it).
// New differences and stale entries both fail.
public class PropertyCoverageTests
{
    [Fact]
    public void EveryCreatableClassIsChecked()
    {
        Sta.Run(() =>
        {
            var objects = new FormsObjects("COV_CLASSES");
            try
            {
                var version = NdapiContext.BuilderVersion.MajorVersion;
                var expected = NdapiMetadata.Classes
                    .Where(c => !FormsObjects.NotCreatable.Contains(c))
                    .Where(c => c != typeof(Event) || version >= 12)
                    .Where(c => c != typeof(MenuParameter) || version == 6)
                    .Order(Comparer<Type>.Create((a, b) => string.CompareOrdinal(a.Name, b.Name)));

                Assert.Equal(expected, objects.Objects.Keys.OrderBy(t => t.Name, StringComparer.Ordinal));
            }
            finally
            {
                objects.Destroy();
            }
        });
    }

    [Fact]
    public void TypedMembersApplyToTheirObject() => CheckAgainstBaseline("inapplicable", "COV_INAPPLICABLE",
        (obj, typed) => typed.Where(p => !obj.HasProperty(p)));

    // NdapiObject<T>.Next and Previous are hand-written
    private static readonly HashSet<NdapiConstant> HandWritten = [NdapiConstant.D2FP_NEXT, NdapiConstant.D2FP_PREVIOUS];

    [Fact]
    public void EveryPropertyOfAnObjectHasATypedMember() => CheckAgainstBaseline("uncovered", "COV_UNCOVERED",
        (obj, typed) => NdapiMetadata.SupportedProperties
            .Where(p => !typed.Contains(p) && !HandWritten.Contains(p) && obj.HasProperty(p)));

    private static void CheckAgainstBaseline(string kind, string prefix,
        Func<NdapiObject, HashSet<NdapiConstant>, IEnumerable<NdapiConstant>> differences)
    {
        Sta.Run(() =>
        {
            var baselinePath = Path.Combine(AppContext.BaseDirectory, "Coverage",
                $"forms{NdapiContext.BuilderVersion.MajorVersion}.txt");
            Assert.SkipUnless(File.Exists(baselinePath), $"no coverage baseline for this version ({baselinePath})");

            var baseline = File.ReadLines(baselinePath)
                .Select(l => l.Split('#')[0].Trim())
                .Where(l => l.StartsWith(kind + " ", StringComparison.Ordinal))
                .ToHashSet();

            var objects = new FormsObjects(prefix);
            try
            {
                var actual = new HashSet<string>();
                foreach (var (type, obj) in objects.Objects)
                {
                    var typed = NdapiMetadata.GetMetaObjectFrom(type).AllProperties.Select(p => p.PropertyId).ToHashSet();
                    actual.UnionWith(differences(obj, typed).Select(p => $"{kind} {type.Name} {p}"));
                }

                var unexpected = actual.Except(baseline).Order(StringComparer.Ordinal).ToList();
                var stale = baseline.Except(actual).Order(StringComparer.Ordinal).ToList();
                Assert.True(unexpected.Count == 0 && stale.Count == 0,
                    $"{Path.GetFileName(baselinePath)} is out of date.\n" +
                    $"New ({unexpected.Count}):\n{string.Join('\n', unexpected)}\n" +
                    $"Stale ({stale.Count}):\n{string.Join('\n', stale)}");
            }
            finally
            {
                objects.Destroy();
            }
        });
    }
}
