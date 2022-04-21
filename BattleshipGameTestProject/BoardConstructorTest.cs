using BattleshipGame.BLL;
using System;
using Xunit;

namespace BattleshipGameTestProject
{
    public class BoardConstructorTest
    //Facts are tests which are always true. They test invariant conditions.
    //Theories are tests which are only true for a particular set of data.
    {
        [Theory]
        [InlineData(10, 10)]
        [InlineData(20, 20)]
        [InlineData(12, 12)]
        public void TestBoardConstruction(int row, int column)
        {
            var boardConstructor = new BoardConstructor();
            var board = boardConstructor.ConstructBoard(row, column);
            Assert.Equal(row * column, board.CellStatuses.Length);
        }

        [Theory]
        [InlineData(10, 10)]
        [InlineData(20, 20)]
        [InlineData(12, 12)]
        public void ConstructBoard_MethodTest(int rows, int columns)
        {
            var boardConstructor = new BoardConstructor();
            var board = boardConstructor.ConstructBoard(rows, columns);
            Assert.Equal(rows, board.Rows);
        }

        [Theory]
        [InlineData(10, 10)]
        [InlineData(20, 20)]
        [InlineData(12, 12)]
        public void ConstructBoard_MethodTest2(int rows, int columns)
        {
            var boardConstructor = new BoardConstructor();
            var board = boardConstructor.ConstructBoard(rows, columns);
            Assert.Equal(columns, board.Columns);
        }
    }
}
