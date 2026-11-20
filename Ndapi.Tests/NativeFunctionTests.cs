using Ndapi.Core;
using Ndapi.Enums;
using Ndapi.Metadata;

using Xunit;

namespace Ndapi.Tests;

public class NativeFunctionTests
{
    [Fact]
    public void PersistentClientInfoSurvivesSaveAndReopen()
    {
        Sta.Run(() =>
        {
            var path = Path.Join(Path.GetTempPath(), $"pci_{Guid.NewGuid():N}.fmb");
            var module = new FormModule("PCI_SAVE");
            var alert = new Alert(module, "A");
            Assert.Null(alert.PersistentClientInfo);

            alert.PersistentClientInfo = [1, 2, 3, 0, 255];
            alert.ClientInfo = new IntPtr(1234);

            Assert.Equal([1, 2, 3, 0, 255], alert.PersistentClientInfo);
            Assert.Equal(new IntPtr(1234), alert.ClientInfo);
            module.Save(path);
            module.Destroy();

            var reopened = FormModule.Open(path);
            try
            {
                var reloaded = Assert.Single(reopened.Alerts);
                Assert.Equal([1, 2, 3, 0, 255], reloaded.PersistentClientInfo);
                Assert.Equal(IntPtr.Zero, reloaded.ClientInfo);
            }
            finally
            {
                reopened.Destroy();
                File.Delete(path);
            }
        });
    }

    [Fact]
    public void ImportedImageCanBeExported()
    {
        Sta.Run(() =>
        {
            var directory = Directory.CreateTempSubdirectory("ndapi_img");
            var source = Path.Join(directory.FullName, "in.bmp");
            File.WriteAllBytes(source, Bitmap2X2());
            var module = new FormModule("IMAGE_IO");
            var image = new Graphics(new Canvas(module, "C"), "IMG") { GraphicsObjectType = GraphicsObjectType.Image };
            try
            {
                image.ImportImage(source, ImageFormat.Bmp);

                Assert.SkipWhen(NdapiContext.BuilderVersion.MajorVersion < 12, "ExportImage requires Forms 12c");
                var target = Path.Join(directory.FullName, "out.bmp");
                image.ExportImage(target);
                Assert.True(new FileInfo(target).Length > 0);
            }
            finally
            {
                module.Destroy();
                directory.Delete(true);
            }
        });
    }

    [Fact]
    public void UnSubclassDetachesTheObjectFromItsSource()
    {
        Sta.Run(() =>
        {
            Assert.SkipWhen(NdapiContext.BuilderVersion.MajorVersion < 12, "requires Forms 12c");

            var module = new FormModule("UNSUBCLASS");
            var alert = new Alert(module, "A");
            alert.Subclass(new PropertyClass(module, "PC"));
            Assert.NotNull(alert.Source);

            alert.UnSubclass();

            Assert.Null(alert.Source);
            module.Destroy();
        });
    }

    [Fact]
    public void ObjectTypeNamesRoundTrip()
    {
        Sta.Run(() =>
        {
            foreach (var type in new[] { ObjectType.Canvas, ObjectType.Item, ObjectType.FormModule })
            {
                Assert.Equal(type, NdapiMetadata.GetObjectType(NdapiMetadata.GetObjectTypeName(type).ToUpperInvariant()));
            }
        });
    }

    [Fact]
    public void ValueNamesRoundTrip()
    {
        Sta.Run(() =>
        {
            Assert.SkipWhen(NdapiContext.BuilderVersion.MajorVersion < 12, "requires Forms 12c");

            var name = NdapiMetaProperty.GetValueName(NdapiConstant.D2FP_NEWDEFER_REQ_ENF, 2);

            Assert.Equal(2, NdapiMetaProperty.GetValue(NdapiConstant.D2FP_NEWDEFER_REQ_ENF, name));
        });
    }

    [Fact]
    public void MissingLibraryIsReportedInsteadOfFailingTheLoad()
    {
        Sta.Run(() =>
        {
            Assert.SkipWhen(NdapiContext.BuilderVersion.MajorVersion < 12, "requires Forms 12c");
            var oracleHome = Environment.GetEnvironmentVariable("ORACLE_HOME") ?? "";
            var shipped = Path.Join(oracleHome, "forms", "rp2rro.pll");
            Assert.SkipUnless(File.Exists(shipped), $"{shipped} not found");

            var directory = Directory.CreateTempSubdirectory("ndapi_pll");
            var library = Path.Join(directory.FullName, "RP2RRO.pll");
            var form = Path.Join(directory.FullName, "with_lib.fmb");
            File.Copy(shipped, library);
            var module = new FormModule("WITH_LIB");
            _ = new AttachedLibrary(module, library);
            module.Save(form);
            module.Destroy();

            var loaded = FormModule.Open(form, out var withLibrary);
            loaded.Destroy();
            Assert.Null(withLibrary);

            File.Delete(library);
            var reopened = FormModule.Open(form, out var withoutLibrary);
            reopened.Destroy();
            directory.Delete(true);
            Assert.Contains("FRM-10102", withoutLibrary);
        });
    }

    [Fact]
    public void LibraryCanBeCompiled()
    {
        Sta.Run(() =>
        {
            Assert.SkipWhen(NdapiContext.BuilderVersion.MajorVersion < 12, "requires Forms 12c");
            var oracleHome = Environment.GetEnvironmentVariable("ORACLE_HOME") ?? "";
            var shipped = Path.Join(oracleHome, "forms", "EnableDisableItem.pll");
            Assert.SkipUnless(File.Exists(shipped), $"{shipped} not found");

            var directory = Directory.CreateTempSubdirectory("ndapi_plx");
            var path = Path.Join(directory.FullName, "ENABLEDISABLEITEM.pll");
            File.Copy(shipped, path);
            var library = LibraryModule.Open(path);
            try
            {
                library.CompileFile();

                Assert.Single(directory.GetFiles("*.plx", new EnumerationOptions { MatchCasing = MatchCasing.CaseInsensitive }));
            }
            finally
            {
                library.Destroy();
                directory.Delete(true);
            }
        });
    }

    private static byte[] Bitmap2X2()
    {
        var pixels = new byte[] { 0, 0, 255, 0, 255, 0, 0, 0, 255, 0, 0, 0, 255, 255, 255, 0 };
        var header = new byte[54];
        "BM"u8.CopyTo(header);
        BitConverter.GetBytes(header.Length + pixels.Length).CopyTo(header, 2);
        BitConverter.GetBytes(header.Length).CopyTo(header, 10);
        BitConverter.GetBytes(40).CopyTo(header, 14);
        BitConverter.GetBytes(2).CopyTo(header, 18);
        BitConverter.GetBytes(2).CopyTo(header, 22);
        BitConverter.GetBytes((short)1).CopyTo(header, 26);
        BitConverter.GetBytes((short)24).CopyTo(header, 28);
        BitConverter.GetBytes(pixels.Length).CopyTo(header, 34);
        return [.. header, .. pixels];
    }
}
