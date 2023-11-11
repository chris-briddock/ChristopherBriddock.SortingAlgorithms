namespace ChristopherBriddock.SortingAlgorithms.Tests;

public class HeapSortExtensionsTests
{
    [Fact]
    public void HeapSort_SortsIntegerCollectionInAscendingOrder()
    {
        // Arrange
        List<int> collection = new() { 9, 5, 2, 7, 1, 10 };
        List<int> expected = new() { 1, 2, 5, 7, 9, 10 };

        // Act
        collection.HeapSort();

        // Assert
        Assert.Equal(expected, collection);
    }

    [Fact]
    public void HeapSort_SortsStringCollectionInAscendingOrder()
    {
        // Arrange
        List<string> collection = new() { "banana", "apple", "orange", "grape", "pear" };
        List<string> expected = new() { "apple", "banana", "grape", "orange", "pear" };

        // Act
        collection.HeapSort();

        // Assert
        Assert.Equal(expected, collection);
    }

    [Fact]
    public void HeapSort_SortsEmptyCollection_ReturnsEmptyCollection()
    {
        // Arrange
        List<int> collection = new();

        // Act
        collection.HeapSort();

        // Assert
        Assert.Empty(collection);
    }

    [Fact]
    public void HeapSort_SortsCollectionWithDuplicateValuesInAscendingOrder()
    {
        // Arrange
        List<int> collection = new() { 5, 2, 8, 2, 5, 1, 8 };
        List<int> expected = new() { 1, 2, 2, 5, 5, 8, 8 };

        // Act
        collection.HeapSort();

        // Assert
        Assert.Equal(expected, collection);
    }

    [Fact]
    public void HeapSort_SortsCollectionWithCustomClassInAscendingOrder()
    {
        // Arrange
        ICollection<Person> collection = new List<Person>
        {
            new Person("John", 25),
            new Person("Alice", 30),
            new Person("Bob", 20)
        };

        ICollection<Person> expected = new List<Person>
        {
            new Person("Bob", 20),
            new Person("John", 25),
            new Person("Alice", 30)
        };

        // Act
        collection.HeapSort();

        // Assert
        Assert.Equivalent(expected, collection);
    }

}
