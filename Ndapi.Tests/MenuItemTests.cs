using Xunit;

namespace Ndapi.Tests;

public class MenuItemTests
{
    [Fact]
    public void RolesListsTheRolesOfTheItem()
    {
        Sta.Run(() =>
        {
            using var module = new MenuModule("ROLES_MMB");
            module.AddRoleAt(1, "ADMIN");
            module.AddRoleAt(2, "CLERK");
            var item = new MenuItem(new Menu(module, "MNU"), "MNI");
            item.AddRoleAt(1, "ADMIN");
            item.AddRoleAt(2, "CLERK");

            Assert.Equal(["ADMIN", "CLERK"], item.Roles);
        });
    }
}
