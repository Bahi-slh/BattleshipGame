using BattleshipGame.BLL;
using BattleshipGame.Constants.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BattleshipGameTestProject
{
    public class ShipLocatorTest
    {
        [Theory]
        [InlineData(10, 10, 11, 11, ShipType.Destroyer, ShipDirection.Horizontal)]
        //The locate spot is out of the board
        public void LocateShipValidation_MethodTest(int boardRow, int boardColumn, int locateRow, int locateColumn, ShipType shipType, ShipDirection direction)
        {
            var boardConstructor = new BoardConstructor();
            var board = boardConstructor.ConstructBoard(boardRow, boardColumn);

            var shipConstructor = new ShipConstructor();
            var ship = shipConstructor.AddShip(shipType);

            var shipLocator = new ShipLocator();
            Exception exception = Assert.Throws<Exception>(() =>
              shipLocator.LocateShip(locateRow, locateColumn, ship, board, direction));

            Assert.Equal("This Placement is not valid", exception.Message);
        }

        [Theory]
        [InlineData(10, 10, 2, 2, ShipType.Destroyer, ShipDirection.Vertical)]
       
        public void LocateShipVertically_Test(int boardRow, int boardColumn, int locateRow, int locateColumn, ShipType shipType, ShipDirection direction)
        {
            var boardConstructor = new BoardConstructor();
            var board = boardConstructor.ConstructBoard(boardRow, boardColumn);

            var shipConstructor = new ShipConstructor();
            var ship = shipConstructor.AddShip(shipType);

            var shipLocator = new ShipLocator();
            shipLocator.LocateShip(locateRow, locateColumn, ship, board, direction);

            //first and last cell of the ship must be filled
            Assert.True(board.CellStatuses[locateRow, locateColumn]==CellStatus.Filled);
            Assert.True(board.CellStatuses[locateRow+ship.ShipLength-1, locateColumn]==CellStatus.Filled);
        }

        [Theory]
        [InlineData(10, 10, 2, 2, ShipType.Destroyer, ShipDirection.Horizontal)]

        public void LocateShipHorizontally_Test(int boardRow, int boardColumn, int locateRow, int locateColumn, ShipType shipType, ShipDirection direction)
        {
            var boardConstructor = new BoardConstructor();
            var board = boardConstructor.ConstructBoard(boardRow, boardColumn);

            var shipConstructor = new ShipConstructor();
            var ship = shipConstructor.AddShip(shipType);

            var shipLocator = new ShipLocator();
            shipLocator.LocateShip(locateRow, locateColumn, ship, board, direction);

            //first and last cell of the ship must be filled
            Assert.True(board.CellStatuses[locateRow, locateColumn] == CellStatus.Filled);
            Assert.True(board.CellStatuses[locateRow , locateColumn+ ship.ShipLength - 1] == CellStatus.Filled);
        }
    }
}
