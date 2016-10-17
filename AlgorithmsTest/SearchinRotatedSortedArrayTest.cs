using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class SearchinRotatedSortedArrayTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(int[] nums, int target, int output)
        {
            Assert.Equal(output, Solution033.Search(nums, target));
        }
    }
}

