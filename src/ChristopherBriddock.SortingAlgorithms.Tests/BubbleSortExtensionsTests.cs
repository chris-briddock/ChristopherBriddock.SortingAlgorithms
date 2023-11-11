namespace ChristopherBriddock.SortingAlgorithms.Tests;

public class BubbleSortExtensionsTests
{
    [Fact]
    public void BubbleSort_SortsCollectionInAscendingOrder()
    {
        // Arrange
        List<int> collection = new() { 5, 2, 7, 1, 3 };
        List<int> expected = new() { 1, 2, 3, 5, 7 };

        // Act
        collection.BubbleSort();

        // Assert
        Assert.Equal(expected, collection);
    }

    [Fact]
    public void BubbleSort_PreservesOriginalCollectionWithDuplicateValues()
    {
        // Arrange
        List<int> collection = new() { 5, 2, 7, 2, 3 };
        List<int> expected = new() { 2, 2, 3, 5, 7 };

        // Act
        collection.BubbleSort();

        // Assert
        Assert.Equal(expected, collection);
    }

    [Fact]
    public void BubbleSort_SortsCollectionWithCustomClass()
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
        collection.BubbleSort();

        // Assert
        Assert.Equivalent(expected, collection);
    }

    [Fact]
    public void BubbleSort_SortsStringsAlphabetically()
    {
        // Arrange
        IList<string> collection = new List<string>(4) { "orange", "apple", "banana", "grape" };
        IList<string> expected = new List<string>(4) { "apple", "banana", "grape", "orange" };

        // Act
        collection.BubbleSort();

        // Assert
        Assert.Equal(expected, collection);
    }

    [Fact]
    public void BubbleSort_PreservesOriginalCollectionOfStringsWithDuplicateValues()
    {
        // Arrange
        IList<string> collection = new List<string>(4) { "orange", "apple", "banana", "apple" };
        IList<string> expected = new List<string>(4) { "apple", "apple", "banana", "orange" };

        // Act
        collection.BubbleSort();

        // Assert
        Assert.Equal(expected, collection);
    }
}
