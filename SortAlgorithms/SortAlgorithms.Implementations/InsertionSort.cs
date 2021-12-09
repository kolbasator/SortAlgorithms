namespace SortAlgorithms.Implementations
{
    public static class InsertionSort
    {
        public static int[] Sort(int[] array)
        { 
            int i, j;
            for (i = 1; i < array.Length; i++)
            {
                int key = array[i];
                for (j = i - 1; j >= 0 && array[j] > key; j--)
                {
                    array[j + 1] = array[j];
                }
                array[j + 1] = key;
            }
            return array;
        }
    }
}
