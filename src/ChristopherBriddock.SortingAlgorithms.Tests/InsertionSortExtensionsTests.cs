namespace ChristopherBriddock.SortingAlgorithms.Tests;

public class InsertionSortExtensionsTests
{
    [Fact]
    public void InsertionSort_SortsIntegerCollection()
    {
        // Arrange
        List<int> collection = new() { 4, 2, 1, 3 };

        // Act
        collection.InsertionSort();

        // Assert
        Assert.Equal(new List<int> { 1, 2, 3, 4 }, collection);
    }

    [Fact]
    public void InsertionSort_SortsStringCollection()
    {
        // Arrange
        List<string> collection = new() { "banana", "apple", "cherry", "date" };

        // Act
        collection.InsertionSort();

        // Assert
        Assert.Equal(new List<string> { "apple", "banana", "cherry", "date" }, collection);
    }

    [Fact]
    public void InsertionSort_SortsCustomObjectCollection()
    {
        // Arrange
        ICollection<Person> collection = new List<Person>
        {
            new Person("John", 30),
            new Person("Alice", 25),
            new Person("Bob", 35)
        };

        ICollection<Person> expected = new List<Person>
        {
            new Person("Alice",25),
            new Person("John", 30),
            new Person("Bob", 35)
        };

        // Act
        collection.InsertionSort();

        // Assert
        Assert.Equivalent(collection, expected);
    }
}
