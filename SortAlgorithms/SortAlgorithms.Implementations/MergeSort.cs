namespace SortAlgorithms.Implementations
{
    public static class MergeSort
    {
        public static int[] Sort(ref int[] array)
        {
            if (array.Length == 1)
            {
                return array;
            }
            int middleIndex = array.Length / 2;
            int[] leftHalf = new int[middleIndex];
            int[] rightHalf = new int[array.Length - middleIndex];
            for (int i = 0; i < leftHalf.Length; i++)
            {
                leftHalf[i] = array[i];
            }
            for (int i = 0; i < rightHalf.Length; i++)
            {
                rightHalf[i] = array[middleIndex];
                middleIndex++;
            }
            Sort(ref leftHalf);
            Sort(ref rightHalf);
            Merge(leftHalf, rightHalf, array);
            return array;
        }
        private static int[] Merge(int[] leftHalf, int[] rightHalf, int[] mergedArray)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int currentIndex = 0;
            while (leftIndex < leftHalf.Length && rightIndex < rightHalf.Length)
            {
                if (leftHalf[leftIndex] <= rightHalf[rightIndex])
                {
                    mergedArray[currentIndex] = leftHalf[leftIndex];
                    leftIndex++;
                }
                else
                {
                    mergedArray[currentIndex] = rightHalf[rightIndex];
                    rightIndex++;
                }
                currentIndex++;
            }
            while (leftIndex < leftHalf.Length)
            {
                mergedArray[currentIndex] = leftHalf[leftIndex];
                currentIndex++;
                leftIndex++;
            }
            while (rightIndex < rightHalf.Length)
            {
                mergedArray[currentIndex] = rightHalf[rightIndex];
                currentIndex++;
                rightIndex++;
            }
            return mergedArray;
        }
    }
}
