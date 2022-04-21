using BattleshipGame.BLL;
using BattleshipGame.Constants.Enums;
using BattleshipGame.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BattleshipGameTestProject
{
    public class AttackTest
    {
        [Theory]
        [InlineData(10, 10,11,11)]
       //The spot that is meant to attack is out of the board. So, it must return false as CheckAttack Validation returns false.
        public void CheckAttack_MethodTest(int boardRow, int boardColumn, int row, int column)
        {
            var boardConstructor = new BoardConstructor();
            var board = boardConstructor.ConstructBoard(boardRow, boardColumn);

            var attack = new Attack();
            Boolean result=attack.AttackCell(board, row, column);

            Assert.True(result==false);
        }


        [Theory]
        [InlineData(10, 10, 9, 9)]
        //This attack spot must be a Miss as it's empty so then the AttackCell Method returns false
        public void AttackEmptyCell_MethodTest(int boardRow, int boardColumn, int row, int column)
        {
            var boardConstructor = new BoardConstructor();
            var board = boardConstructor.ConstructBoard(boardRow, boardColumn);

            var attack = new Attack();
            Boolean result = attack.AttackCell(board, row, column);

            Assert.True(result==false);
        }

        [Theory]
        [InlineData(10, 10, 2, 2, 2, 3, ShipType.Destroyer ,ShipDirection.Horizontal)]
        //This attack spot must be a HIT as it's filled so then the AttackCell Method returns false
        public void AttackFilledCell_MethodTest(
            int boardRow, int boardColumn, int shipRow, int shipColumn, int row, int column, ShipType shipType, ShipDirection direction)
        {
            var boardConstructor = new BoardConstructor();
            var board = boardConstructor.ConstructBoard(boardRow, boardColumn);

            var shipConstructor = new ShipConstructor();
            var ship=shipConstructor.AddShip(shipType);

            var shipLocator = new ShipLocator();
            shipLocator.LocateShip(shipRow, shipColumn, ship, board, direction);

            var attack = new Attack();
            Boolean result = attack.AttackCell(board, row, column);

            Assert.True(result == true);
        }


    }
}
