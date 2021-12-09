using NUnit.Framework;
using SortAlgorithms.Implementations;
using FluentAssertions; 

namespace Tests
{
    public class QuickSortTest
    {
        [Test]
        public void Quick_Sort_Test()
        {
            var array = new int[] { 6,7,5,4,9,3,5,7,8,4,3,6,8,1,2,4,6,7,8,5,4,6,7,4,1 };
            array = QuickSort.Sort(ref array, 0, 24);
            array.Should().BeEquivalentTo(new int[] { 1, 1, 2, 3, 3, 4, 4, 4, 4, 4, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 9 });
        }
    }
}