using Xunit;

namespace Ndapi.Tests;

public class ObjectLibraryTests
{
    [Fact]
    public void ALibraryWithASingleObjectHasAny()
    {
        Sta.Run(() =>
        {
            var form = new FormModule("OLB_ANY_FMB");
            var alert = new Alert(form, "ALT");
            var library = new ObjectLibrary("OLB_ANY");
            var tab = library.CreateObjectLibraryTab("TAB");

            tab.AddObject(alert);

            Assert.Equal(1, library.Objects.Count);
            Assert.True(library.Objects.Any());
            Assert.Equal(1, tab.Objects.Count);
            Assert.True(tab.Objects.Any());
            library.Destroy();
            form.Destroy();
        });
    }

    [Fact]
    public void ObjectsCanBeAddedToATabReadFromTheLibrary()
    {
        Sta.Run(() =>
        {
            var form = new FormModule("OLB_TAB_FMB");
            var alert = new Alert(form, "ALT");
            var library = new ObjectLibrary("OLB_TAB");
            library.CreateObjectLibraryTab("TAB");
            var tab = Assert.Single(library.Tabs);

            Assert.Same(library, tab.ObjectLibrary);
            tab.AddObject(alert);
            Assert.Equal(1, tab.Objects.Count);
            library.Destroy();
            form.Destroy();
        });
    }
}
