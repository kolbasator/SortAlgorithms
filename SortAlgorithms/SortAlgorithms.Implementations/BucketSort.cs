using System.Collections.Generic;
using System.Linq;

namespace SortAlgorithms.Implementations
{
    public static class BucketSort
    {
        public static double[] Sort(double[] array)
        {
            if (array.Length == 0)
                return array;
            List<double>[] buckets = new List<double>[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                buckets[i] = new List<double>();
            }
            for (int i = 0; i < array.Length; i++)
            {
                int index = (int)(array[i] * array.Length);
                buckets[index].Add(array[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                buckets[i] = InsertionSort(buckets[i].ToArray()).ToList();
            }
            int current = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    array[current] = buckets[i][j];
                    current++;
                }
            }
            return array;
        }
        private static double[] InsertionSort(double[] array)
        {
            int j, i;
            for (i = 1; i < array.Length; i++)
            {
                double current = array[i];
                for (j = i - 1; j >= 0 && array[j] > array[i]; j--)
                {
                    double tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;
                }
                array[j + 1] = current;
            }
            return array;
        }
    }
}

