using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class Searcha2DMatrixTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(int[,] matrix, int target, bool output)
        {
            Assert.Equal(output, Solution074.SearchMatrix(matrix, target));
        }
    }
}

