namespace ChristopherBriddock.SortingAlgorithms;
public static class QuickSortExtensions
{
    public static void QuickSort<T>(this ICollection<T> collection) where T : IComparable<T>
    {
        List<T> list = new(collection);
        QuickSortRecursive(list, 0, list.Count - 1);

        collection.Clear();
        foreach (T item in list)
        {
            collection.Add(item);
        }
    }

    private static void QuickSortRecursive<T>(List<T> list, int low, int high) where T : IComparable<T>
    {
        if (low < high)
        {
            int pivotIndex = Partition(list, low, high);
            QuickSortRecursive(list, low, pivotIndex - 1);
            QuickSortRecursive(list, pivotIndex + 1, high);
        }
    }

    private static int Partition<T>(List<T> list, int low, int high) where T : IComparable<T>
    {
        T pivot = list[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (list[j].CompareTo(pivot) <= 0)
            {
                i++;
                Swap(list, i, j);
            }
        }

        Swap(list, i + 1, high);
        return i + 1;
    }

    private static void Swap<T>(List<T> list, int i, int j)
    {
        (list[j], list[i]) = (list[i], list[j]);
    }
}
