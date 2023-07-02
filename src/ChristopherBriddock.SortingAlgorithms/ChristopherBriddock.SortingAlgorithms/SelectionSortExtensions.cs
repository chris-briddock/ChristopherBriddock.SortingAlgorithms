namespace ChristopherBriddock.SortingAlgorithms;

public static class SelectionSortExtensions
{
    public static void SelectionSort<T>(this ICollection<T> collection) where T : IComparable<T>
    {
        T[] array = new T[collection.Count];
        collection.CopyTo(array, 0);

        Sort(array);

        collection.Clear();
        foreach (T item in array)
        {
            collection.Add(item);
        }
    }

    private static void Sort<T>(T[] array) where T : IComparable<T>
    {
        int length = array.Length;

        for (int i = 0; i < length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < length; j++)
            {
                if (array[j].CompareTo(array[minIndex]) < 0)
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                (array[minIndex], array[i]) = (array[i], array[minIndex]);
            }
        }
    }
}
