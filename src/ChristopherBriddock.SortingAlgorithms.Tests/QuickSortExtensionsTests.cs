namespace ChristopherBriddock.SortingAlgorithms.Tests;
public class QuickSortExtensionsTests
{
    [Fact]
    public void QuickSort_SortsIntegerCollection()
    {
        // Arrange
        List<int> collection = new() { 5, 2, 8, 1, 3 };
        List<int> expected = new() { 1, 2, 3, 5, 8 };

        // Act
        collection.QuickSort();

        // Assert
        Assert.Equal(expected, collection);
    }

    [Fact]
    public void QuickSort_SortsStringCollection()
    {
        // Arrange
        List<string> collection = new() { "banana", "apple", "grape", "cherry" };
        List<string> expected = new() { "apple", "banana", "cherry", "grape" };

        // Act
        collection.QuickSort();

        // Assert
        Assert.Equal(expected, collection);
    }

    [Fact]
    public void QuickSort_EmptyCollection_RemainsEmpty()
    {
        // Arrange
        List<int> collection = new();

        // Act
        collection.QuickSort();

        // Assert
        Assert.Empty(collection);
    }
}