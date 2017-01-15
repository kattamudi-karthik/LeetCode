using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class SetMatrixZeroesTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(int[,] matrix)
        {
            Solution073.SetZeroes(matrix);
        }
    }
}

