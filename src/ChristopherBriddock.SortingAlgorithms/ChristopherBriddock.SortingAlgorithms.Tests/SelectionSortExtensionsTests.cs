namespace ChristopherBriddock.SortingAlgorithms.Tests;
public class SelectionSortExtensionsTests
{
    [Fact]
    public void SelectionSort_ShouldSortIntArrayInAscendingOrder()
    {
        // Arrange
        int[] array = { 5, 3, 8, 2, 1, 4 };
        List<int> collection = new(array);

        // Act
        collection.SelectionSort();

        // Assert
        int[] expectedArray = { 1, 2, 3, 4, 5, 8 };
        Assert.Equal(expectedArray, collection);
    }

    [Fact]
    public void SelectionSort_ShouldSortStringArrayInAscendingOrder()
    {
        // Arrange
        string[] array = { "banana", "apple", "cherry", "date" };
        List<string> collection = new(array);

        // Act
        collection.SelectionSort();

        // Assert
        string[] expectedArray = { "apple", "banana", "cherry", "date" };
        Assert.Equal(expectedArray, collection);
    }

    [Fact]
    public void SelectionSort_ShouldSortEmptyCollection()
    {
        // Arrange
        int[] array = Array.Empty<int>();
        List<int> collection = new(array);

        // Act
        collection.SelectionSort();

        // Assert
        int[] expectedArray = Array.Empty<int>();
        Assert.Equal(expectedArray, collection);
    }
}

