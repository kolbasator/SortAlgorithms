using NUnit.Framework;
using SortAlgorithms.Implementations;
using FluentAssertions;

namespace Tests
{
    public class BubbleSortTest
    {
        [Test]
        public void Bubble_Sort_Test()
        {
            var array = new int[] { 0, 7, 1, 8, 6, 4, 5, 3, 1, 2, 0, 2, 9, 8, 6, 4, 5, 6, 7, 9, 3, 4, 6, 7, 4, 5, 6, 6, 7, 8, 9, 0 };
            array = BubbleSort.Sort(array);
            array.Should().BeEquivalentTo(new int[] { 0, 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 4, 4, 5, 5, 5, 6, 6, 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 9, 9, 9 });
        }
    }
}