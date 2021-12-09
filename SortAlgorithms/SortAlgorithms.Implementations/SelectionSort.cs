namespace SortAlgorithms.Implementations
{
    public static class SelectionSort
    {
        public static int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                    j++;
                }
                if (min != i)
                {
                    int tmp = array[i];
                    array[i] = array[min];
                    array[min] = tmp;
                }
            }
            return array;
        }
    }
}
