namespace ChristopherBriddock.SortingAlgorithms;
public static class MergeSortExtensions
{
    public static void MergeSort<T>(this ICollection<T> collection) where T : IComparable<T>
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
        if (array.Length <= 1)
            return;

        int mid = array.Length / 2;

        T[] leftArray = new T[mid];
        T[] rightArray = new T[array.Length - mid];

        Array.Copy(array, 0, leftArray, 0, mid);
        Array.Copy(array, mid, rightArray, 0, array.Length - mid);

        Sort(leftArray);
        Sort(rightArray);

        Merge(array, leftArray, rightArray);
    }

    private static void Merge<T>(T[] array, T[] leftArray, T[] rightArray) where T : IComparable<T>
    {
        int leftLength = leftArray.Length;
        int rightLength = rightArray.Length;
        int i = 0, j = 0, k = 0;

        while (i < leftLength && j < rightLength)
        {
            if (leftArray[i].CompareTo(rightArray[j]) <= 0)
            {
                array[k] = leftArray[i];
                i++;
            }
            else
            {
                array[k] = rightArray[j];
                j++;
            }
            k++;
        }

        while (i < leftLength)
        {
            array[k] = leftArray[i];
            i++;
            k++;
        }

        while (j < rightLength)
        {
            array[k] = rightArray[j];
            j++;
            k++;
        }
    }
}

