using System.Linq;

namespace SortAlgorithms.Implementations
{
    public static class QuickSort
    {
        public static int[] Sort(ref int[] array, int l, int r)
        {
            if (array.Length == 1)
            {
                return array;
            }
            if (l >= r)
            {
                return array;
            }
            int pivot = Partition(ref array, l, r);
            Sort(ref array, l, pivot);
            Sort(ref array, pivot + 1, r);
            return array;
        }
        private static int Partition(ref int[] array, int l, int r)
        {
            int pivot = array[(l + r) / 2];
            while (true)
            {
                while (array[l] < pivot)
                {
                    l++;
                }
                while (array[r] > pivot)
                {
                    r--;
                }
                if (l >= r)
                {
                    return r;
                }
                int tmp = array[l];
                array[l] = array[r];
                array[r] = tmp;
                l++;
                r--;
            }
        }
    }
}
