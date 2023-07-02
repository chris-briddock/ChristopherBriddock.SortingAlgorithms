namespace ChristopherBriddock.SortingAlgorithms;

public static class BubbleSortExtensions
{
    public static void BubbleSort<T>(this ICollection<T> collection) where T : IComparable<T>
    {
        T[] array = new T[collection.Count];
        collection.CopyTo(array, 0);

        int length = array.Length;
        bool swapped;

        for (int i = 0; i < length - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < length - i - 1; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    Swap(array, j, j + 1);
                    swapped = true;
                }
            }

            if (!swapped)
                break;
        }

        collection.Clear();
        foreach (T item in array)
        {
            collection.Add(item);
        }
    }

    private static void Swap<T>(T[] array, int i, int j)
    {
        (array[j], array[i]) = (array[i], array[j]);
    }
}
