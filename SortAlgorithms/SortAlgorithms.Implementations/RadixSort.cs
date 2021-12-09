using System.Linq;

namespace SortAlgorithms.Implementations
{
    public static class RadixSort
    {
        public static int[] Sort(int[] array)
        {
            int length = array.Max().ToString().Length;
            int place = 1;
            for (int i = 0; i < length; i++)
            {
                array = CountingSort(array, place);
                place *= 10;
            }
            return array;
        }
        private static int[] CountingSort(int[] array, int place)
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
            int[] count = new int[10];
            for (int i = 0; i < 10; i++)
            {
                count[i] = 0;
            }
            for (int i = 0; i < array.Length; i++)
            {
                count[(array[i] / place) % 10]++;
            }
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int index = (array[i] / place) % 10;
                output[count[index] - 1] = array[i];
                count[index]--;
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = output[i];
            }
            return array;
        }
    }
}
