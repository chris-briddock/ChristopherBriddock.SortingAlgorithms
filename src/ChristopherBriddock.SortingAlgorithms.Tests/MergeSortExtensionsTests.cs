namespace ChristopherBriddock.SortingAlgorithms.Tests;

using System;
using System.Collections.Generic;
using Xunit;

public class MergeSortExtensionsTests
{
    [Fact]
    public void MergeSort_SortsIntegerCollection()
    {
        // Arrange
        ICollection<int> collection = new List<int> { 5, 3, 8, 2, 1, 4 };
        int[] expected = { 1, 2, 3, 4, 5, 8 };

        // Act
        collection.MergeSort();

        // Assert
        Assert.Equal(expected, collection);
    }

    [Fact]
    public void MergeSort_SortsStringCollection()
    {
        // Arrange
        ICollection<string> collection = new List<string> { "banana", "apple", "cherry", "date" };
        string[] expected = { "apple", "banana", "cherry", "date" };

        // Act
        collection.MergeSort();

        // Assert
        Assert.Equal(expected, collection);
    }

    [Fact]
    public void MergeSort_SortsEmptyCollection()
    {
        // Arrange
        ICollection<int> collection = new List<int>();
        int[] expected = { };

        // Act
        collection.MergeSort();

        // Assert
        Assert.Equal(expected, collection);
    }

    [Fact]
    public void MergeSort_SortsCollectionWithDuplicateValues()
    {
        // Arrange
        ICollection<int> collection = new List<int> { 5, 3, 2, 3, 1, 4, 1 };
        int[] expected = { 1, 1, 2, 3, 3, 4, 5 };

        // Act
        collection.MergeSort();

        // Assert
        Assert.Equal(expected, collection);
    }

    [Fact]
    public void MergeSort_SortsCollectionWithCustomObjects()
    {
        // Arrange
        ICollection<Person> collection = new List<Person>
        {
            new Person("Alice", 25),
            new Person("Bob", 30),
            new Person("Charlie", 20),
            new Person("David", 35)
        };
        ICollection<Person> expected = new List<Person> 
        {
            new Person("Charlie", 20),
            new Person("Alice", 25),
            new Person("Bob", 30),
            new Person("David", 35)
        };

        // Act
        collection.MergeSort();

        // Assert
        Assert.Equivalent(expected, collection);
    }
}
