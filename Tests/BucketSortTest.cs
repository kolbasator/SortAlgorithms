using NUnit.Framework;
using SortAlgorithms.Implementations;
using FluentAssertions;

namespace Tests
{
    public class BucketSortTest
    {
        [Test]
        public void Bucket_Sort_Test()
        {
            var array = new double[] { 0.23, 0.44, 0.17, 0.16, 0.89, 0.75, 0.623, 0.9432, 0.32 };
            array = BucketSort.Sort(array);
            array.Should().BeEquivalentTo(new double[] { 0.16, 0.17, 0.23, 0.32, 0.44, 0.623, 0.75, 0.89, 0.9432 });
        }
    }
}