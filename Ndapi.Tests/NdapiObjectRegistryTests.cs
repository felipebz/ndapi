using Ndapi.Enums;

using Xunit;

namespace Ndapi.Tests;

public class NdapiObjectRegistryTests
{
    // The native allocator reuses the memory of destroyed objects. A wrapper cached for a destroyed object must
    // never be handed out for the new object that happens to live at the same address.
    [Fact]
    public void DestroyedObjectsAreNotReturnedForReusedAddresses()
    {
        Sta.Run(() =>
        {
            for (var i = 0; i < 50; i++)
            {
                var module = new FormModule($"REG_{i}");
                for (var j = 0; j < 20; j++)
                {
                    _ = new Window(module, $"W{j}");
                }

                // enumerate, so every window gets a cached wrapper (a new module also has its default window)
                Assert.All(module.Windows, w => Assert.Equal(ObjectType.Window, w.GetObjectType()));
                module.Destroy();

                var other = new FormModule($"REG_OTHER_{i}");
                for (var j = 0; j < 20; j++)
                {
                    _ = new Canvas(other, $"C{j}");
                    _ = new Alert(other, $"A{j}");
                }

                Assert.All(other.Canvases, c => Assert.Equal(ObjectType.Canvas, c.GetObjectType()));
                Assert.All(other.Alerts, a => Assert.Equal(ObjectType.Alert, a.GetObjectType()));
                other.Destroy();
            }
        });
    }

    [Fact]
    public void DestroyedChildIsNotReturnedForReusedAddress()
    {
        Sta.Run(() =>
        {
            var module = new FormModule("REG_CHILD");
            for (var i = 0; i < 50; i++)
            {
                var block = new Block(module, $"B{i}");
                _ = new Item(block, "I1");
                Assert.Single(block.Items);
                block.Destroy();

                _ = new Alert(module, $"A{i}");
                _ = new RecordGroup(module, $"RG{i}");
                Assert.All(module.Alerts, a => Assert.Equal(ObjectType.Alert, a.GetObjectType()));
                Assert.All(module.RecordGroups, r => Assert.Equal(ObjectType.RecordGroup, r.GetObjectType()));
            }

            module.Destroy();
        });
    }
}
