using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class SortColorsTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(int[] nums)
        {
            Solution075.SortColors(nums);
        }
    }
}

