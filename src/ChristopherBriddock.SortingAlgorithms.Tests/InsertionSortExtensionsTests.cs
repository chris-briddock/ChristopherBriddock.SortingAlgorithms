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
        List<Person> collection = new()
        {
            new Person { Name = "John", Age = 30 },
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "Bob", Age = 35 }
        };

        // Act
        collection.InsertionSort();

        // Assert
        Assert.Equal(new List<Person>
        {
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "John", Age = 30 },
            new Person { Name = "Bob", Age = 35 }
        }, collection);
    }

    // Define a custom class for testing
    private class Person : IComparable<Person>
    {
        public string Name { get; set; } = null!;
        public int Age { get; set; }

        public int CompareTo(Person? other)
        {
            return Age.CompareTo(other!.Age);
        }
    }
}
