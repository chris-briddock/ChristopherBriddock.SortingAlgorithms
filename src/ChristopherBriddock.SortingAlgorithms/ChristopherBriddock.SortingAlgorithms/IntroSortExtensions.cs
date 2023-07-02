namespace ChristopherBriddock.SortingAlgorithms;

public static class IntroSortExtensions
{
    public static void IntroSort<T>(this ICollection<T> collection) where T : IComparable<T>
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
        int maxDepth = (int)Math.Floor(Math.Log(array.Length, 2));
        SortRecursive(array, 0, array.Length - 1, maxDepth);
    }

    private static void SortRecursive<T>(T[] array, int left, int right, int depthLimit) where T : IComparable<T>
    {
        if (right - left <= 16)
        {
            InsertionSort(array, left, right);
            return;
        }

        if (depthLimit == 0)
        {
            Heapsort(array, left, right);
            return;
        }

        int pivot = Partition(array, left, right);
        SortRecursive(array, left, pivot, depthLimit - 1);
        SortRecursive(array, pivot + 1, right, depthLimit - 1);
    }

    private static void InsertionSort<T>(T[] array, int left, int right) where T : IComparable<T>
    {
        for (int i = left + 1; i <= right; i++)
        {
            T key = array[i];
            int j = i - 1;
            while (j >= left && array[j].CompareTo(key) > 0)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;
        }
    }

    private static void Heapsort<T>(T[] array, int left, int right) where T : IComparable<T>
    {
        int n = right - left + 1;

        for (int i = n / 2; i >= 1; i--)
        {
            DownHeap(array, i, n, left);
        }

        for (int i = n; i > 1; i--)
        {
            Swap(array, left, left + i - 1);
            DownHeap(array, 1, i - 1, left);
        }
    }

    private static void DownHeap<T>(T[] array, int i, int n, int left) where T : IComparable<T>
    {
        T element = array[left + i - 1];

        while (i <= n / 2)
        {
            int child = 2 * i;

            if (child < n && array[left + child - 1].CompareTo(array[left + child]) < 0)
            {
                child++;
            }

            if (element.CompareTo(array[left + child - 1]) >= 0)
            {
                break;
            }

            array[left + i - 1] = array[left + child - 1];


            i = child;
        }

        array[left + i - 1] = element;
    }

    private static int Partition<T>(T[] array, int left, int right) where T : IComparable<T>
    {
        T pivot = array[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (array[j].CompareTo(pivot) <= 0)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, right);
        return i + 1;
    }

    private static void Swap<T>(T[] array, int i, int j)
    {
        (array[j], array[i]) = (array[i], array[j]);
    }
}
