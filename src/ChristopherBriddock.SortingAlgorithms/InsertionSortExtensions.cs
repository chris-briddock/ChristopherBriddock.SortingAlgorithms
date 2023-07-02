namespace ChristopherBriddock.SortingAlgorithms;
public static class InsertionSortExtensions
{
    public static void InsertionSort<T>(this ICollection<T> collection) where T : IComparable<T>
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

        for (int i = 1; i < length; i++)
        {
            T key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j].CompareTo(key) > 0)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = key;
        }
    }
}
