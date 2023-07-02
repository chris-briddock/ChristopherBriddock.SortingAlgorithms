namespace ChristopherBriddock.SortingAlgorithms;
    public static class HeapSortExtensions
    {
        public static void HeapSort<T>(this ICollection<T> collection) where T : IComparable<T>
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

            for (int i = length / 2 - 1; i >= 0; i--)
            {
                Heapify(array, length, i);
            }

            for (int i = length - 1; i > 0; i--)
            {
                Swap(array, 0, i);
                Heapify(array, i, 0);
            }
        }

        private static void Heapify<T>(T[] array, int length, int root) where T : IComparable<T>
        {
            int largest = root;
            int left = 2 * root + 1;
            int right = 2 * root + 2;

            if (left < length && array[left].CompareTo(array[largest]) > 0)
            {
                largest = left;
            }

            if (right < length && array[right].CompareTo(array[largest]) > 0)
            {
                largest = right;
            }

            if (largest != root)
            {
                Swap(array, root, largest);
                Heapify(array, length, largest);
            }
        }

        private static void Swap<T>(T[] array, int i, int j)
        {
        (array[j], array[i]) = (array[i], array[j]);
    }
}