using NUnit.Framework;
using SortAlgorithms.Implementations;
using FluentAssertions;

namespace Tests
{
    public class RadixSortTest
    {
        [Test]
        public void Radix_Sort_Test()
        {
            var array = new int[] { 329,457,657,5,839,436,67,12,720,355,999 };
            array = RadixSort.Sort(array);
            array.Should().BeEquivalentTo(new int[] {5,12,67,329,355,436,457,657,720,839,999});
        }
    }
}