namespace SortAlgorithms.Implementations
{
    public static class CountingSort
    {
        public static int[] Sort(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            int[] count = new int[max + 1];
            for (int i = 0; i <= max; i++)
            {
                count[i] = 0;
            }
            for (int i = 0; i < array.Length; i++)
            {
                count[array[i]]++;
            }
            int k = 0;
            for (int i = 0; i <= max; i++)
            {
                for (int j = 0; j < count[i]; j++)
                {
                    array[k] = i;
                    k++;
                }
            }
            return array;
        }
        public static int[] StableSort(int[] array)
        {
            int[] output = new int[array.Length];
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            int[] count = new int[max + 1];
            for (int i = 0; i <= max; i++)
            {
                count[i] = 0;
            }
            for (int i = 0; i < array.Length; i++)
            {
                count[array[i]]++;
            }
            for (int i = 1; i <= max; i++)
            {
                count[i] += count[i - 1];
            }
            for (int i = array.Length-1; i >= 0; i--)
            {
                output[count[array[i]] - 1] = array[i];
                count[array[i]]--;
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = output[i];
            }
            return array;
        }
    }
}
