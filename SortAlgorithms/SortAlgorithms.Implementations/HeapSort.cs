namespace SortAlgorithms.Implementations
{
    public static class HeapSort
    {
        public static int[] Sort(int[] array)
        {
            for (int i = (array.Length - 1) / 2; i >= 0; i--)
            {
                MaxHeapify(array, array.Length, i);
            }
            for(int i = array.Length-1; i >= 0; i--)
            {
                int tmp = array[i];
                array[i] = array[0];
                array[0] = tmp;
                MaxHeapify(array, i, 0);
            }
            return array;
        }
        private static void MaxHeapify(int[] array, int n, int i)
        {
            int left = i * 2 + 1;
            int right = i * 2 + 2;
            int largest = i;
            if (left < n && array[left] > array[largest])
            {
                largest = left;
            }
            if (right < n && array[right] > array[largest])
            {
                largest = right;
            }
            if (largest != i)
            {
                int tmp = array[i];
                array[i] = array[largest];
                array[largest] = tmp;
                MaxHeapify(array, n, largest);
            }
        }
    }
}
