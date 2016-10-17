using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class ValidSudokuTest
    {
        [Theory]
        [InlineData(new string[]{".87654321","2........","3........","4........","5........","6........","7........","8........","9........"}, true)]
        public void TestMethod(string[] board, bool output)
        {
            Assert.Equal(output, Solution036.IsValidSudoku(board));
        }
    }
}

