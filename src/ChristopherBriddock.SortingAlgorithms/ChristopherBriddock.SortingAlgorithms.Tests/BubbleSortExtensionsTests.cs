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
        List<Person> collection = new()
        {
            new Person("John", 25),
            new Person("Alice", 30),
            new Person("Bob", 20)
        };

        List<Person> expected = new()
        {
            new Person("Bob", 20),
            new Person("John", 25),
            new Person("Alice", 30)
        };

        // Act
        collection.BubbleSort();

        // Assert
        Assert.Equal(expected, collection);
    }

    [Fact]
    public void BubbleSort_SortsStringsAlphabetically()
    {
        // Arrange
        List<string> collection = new() { "orange", "apple", "banana", "grape" };
        List<string> expected = new() { "apple", "banana", "grape", "orange" };

        // Act
        collection.BubbleSort();

        // Assert
        Assert.Equal(expected, collection);
    }

    [Fact]
    public void BubbleSort_PreservesOriginalCollectionOfStringsWithDuplicateValues()
    {
        // Arrange
        List<string> collection = new() { "orange", "apple", "banana", "apple" };
        List<string> expected = new() { "apple", "apple", "banana", "orange" };

        // Act
        collection.BubbleSort();

        // Assert
        Assert.Equal(expected, collection);
    }
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(Person? other)
        {
            return Age.CompareTo(other!.Age);
        }
    }
}
