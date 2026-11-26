using Xunit;

namespace Ndapi.Tests;

public class NdapiObjectListTests
{
    [Theory]
    [InlineData(1)]
    [InlineData(3)]
    public void RemoveAllDestroysEveryObject(int count)
    {
        Sta.Run(() =>
        {
            using var module = new FormModule("REMOVE_ALL");
            for (var i = 0; i < count; i++)
            {
                _ = new Block(module, $"B{i}");
            }

            module.Blocks.RemoveAll();

            Assert.Empty(module.Blocks);
        });
    }

    [Fact]
    public void EnumeratorKeepsReturningFalseAfterTheEnd()
    {
        Sta.Run(() =>
        {
            using var module = new FormModule("ENUM_END");
            _ = new Block(module, "A");
            _ = new Block(module, "B");

            using var enumerator = module.Blocks.GetEnumerator();
            Assert.True(enumerator.MoveNext());
            Assert.Equal("A", enumerator.Current.Name);
            Assert.True(enumerator.MoveNext());
            Assert.Equal("B", enumerator.Current.Name);
            Assert.False(enumerator.MoveNext());
            Assert.False(enumerator.MoveNext());
        });
    }

    [Fact]
    public void IndexerRejectsPositionsOutsideTheList()
    {
        Sta.Run(() =>
        {
            using var module = new FormModule("INDEXER");
            _ = new Block(module, "A");
            _ = new Block(module, "B");

            Assert.Equal("B", module.Blocks[1].Name);
            Assert.Throws<ArgumentOutOfRangeException>(() => module.Blocks[-1]);
            Assert.Throws<ArgumentOutOfRangeException>(() => module.Blocks[2]);
        });
    }
}
