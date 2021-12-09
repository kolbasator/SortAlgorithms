namespace SortAlgorithms.Implementations
{
    public static class BubbleSort
    {
        public static int[] Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int tmp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = tmp;
                    }
                }
            }
            return array;
        }
    }
}
