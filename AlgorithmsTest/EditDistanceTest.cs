using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class EditDistanceTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(string word1, string word2, int output)
        {
            Assert.Equal(output, Solution072.MinDistance(word1, word2));
        }
    }
}

