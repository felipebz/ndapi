using Xunit;

namespace Ndapi.Tests;

public class ObjectLibraryTests
{
    [Fact]
    public void ALibraryWithASingleObjectHasAny()
    {
        Sta.Run(() =>
        {
            using var form = new FormModule("OLB_ANY_FMB");
            var alert = new Alert(form, "ALT");
            using var library = new ObjectLibrary("OLB_ANY");
            var tab = library.CreateObjectLibraryTab("TAB");

            tab.AddObject(alert);

            Assert.Equal(1, library.Objects.Count);
            Assert.Equal(1, tab.Objects.Count);
#pragma warning disable CS0618 // the instance Any() stays until Ndapi 15
            Assert.True(library.Objects.Any());
            Assert.True(tab.Objects.Any());
#pragma warning restore CS0618
        });
    }

    [Fact]
    public void ObjectsCanBeAddedToATabReadFromTheLibrary()
    {
        Sta.Run(() =>
        {
            using var form = new FormModule("OLB_TAB_FMB");
            var alert = new Alert(form, "ALT");
            using var library = new ObjectLibrary("OLB_TAB");
            library.CreateObjectLibraryTab("TAB");
            var tab = Assert.Single(library.Tabs);

            Assert.Same(library, tab.ObjectLibrary);
            tab.AddObject(alert);
            Assert.Equal(1, tab.Objects.Count);
        });
    }
}
