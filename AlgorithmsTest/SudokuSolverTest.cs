using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class SudokuSolverTest
    {
        [Theory]
        [InlineData(new string[]{"..9748...","7........",".2.1.9...","..7...24.",".64.1.59.",".98...3..","...8.3.2.","........6","...2759.."}
        , new string[]{"519748632","783652419","426139875","357986241","264317598","198524367","975863124","832491756","641275983"})]
        public void TestMethod(string[] board, string[] output)
        {
            Assert.Equal(output, Solution037.SolveSudoku(board));
        }
    }
}

