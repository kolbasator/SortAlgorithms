namespace SortAlgorithms.Implementations
{
    public static class LomutoQuickSort
    {
        public static int[] Sort(int[] array, int l, int r)
        {
            if (array.Length == 1)
            {
                return array;
            }
            if (l == r)
            {
                return array;
            }
            int pivot = Partition(ref array, l, r);
            Sort(array, l, pivot);
            Sort(array, pivot + 1, r);
            return array;
        }
        private static int Partition(ref int[] array, int l, int r)
        {
            int pivot = array[r];
            int i = l - 1;
            for (int j = l; j < r - 1; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            int tmp = array[i + 1];
            array[i + 1] = array[r];
            array[r] = tmp;
            return i + 1;
        }
    }
}
