namespace ChristopherBriddock.SortingAlgorithms.Tests;

public class IntroSortExtensionsTests
{
    [Fact]
    public void IntroSort_SortsIntegerCollectionInAscendingOrder()
    {
        // Arrange
        ICollection<int> collection = new List<int> { 5, 3, 1, 4, 2 };

        // Act
        collection.IntroSort();

        // Assert
        Assert.Equal(new List<int> { 1, 2, 3, 4, 5 }, collection);
    }

    [Fact]
    public void IntroSort_SortsStringCollectionInAscendingOrder()
    {
        // Arrange
        ICollection<string> collection = new List<string> { "c", "a", "e", "d", "b" };

        // Act
        collection.IntroSort();

        // Assert
        Assert.Equal(new List<string> { "a", "b", "c", "d", "e" }, collection);
    }

    [Fact]
    public void IntroSort_DoesNotChangeAlreadySortedCollection()
    {
        // Arrange
        ICollection<int> collection = new List<int> { 1, 2, 3, 4, 5 };

        // Act
        collection.IntroSort();

        // Assert
        Assert.Equal(new List<int> { 1, 2, 3, 4, 5 }, collection);
    }

    [Fact]
    public void IntroSort_SortsEmptyCollection()
    {
        // Arrange
        ICollection<int> collection = new List<int>();

        // Act
        collection.IntroSort();

        // Assert
        Assert.Empty(collection);
    }

    [Fact]
    public void IntroSort_SortsCollectionWithDuplicateValues()
    {
        // Arrange
        ICollection<int> collection = new List<int> { 3, 2, 1, 2, 3 };

        // Act
        collection.IntroSort();

        // Assert
        Assert.Equal(new List<int> { 1, 2, 2, 3, 3 }, collection);
    }
}

