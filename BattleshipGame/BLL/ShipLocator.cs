using BattleshipGame.Constants.Enums;
using BattleshipGame.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipGame.BLL
{
    public class ShipLocator
    {

        public void LocateShip(int row, int column, Ship ship, GameBoard board, ShipDirection direction)
        {
            ValidateLocation(row, column, ship, board);

            if (direction == ShipDirection.Horizontal)
            {
                for (int i = 0; i < ship.ShipLength; i++)
                {
                    //update cells' status
                    board.CellStatuses[row, column + i] =CellStatus.Filled;
                }
            }
            else if (direction == ShipDirection.Vertical)
            {
                for (int j = 0; j < ship.ShipLength; j++)
                {
                    //update cells' status
                    board.CellStatuses[row + j, column] = CellStatus.Filled;
                }
            }
            else
            {
                throw new Exception("This ship location is not valid");
            }
        }
        private void ValidateLocation(int row, int column, Ship ship, GameBoard board)
        {
            string errrorMsg = "This Placement is not valid";
            if (row > board.Rows)
            {
                throw new IndexOutOfRangeException(errrorMsg);
            }
            if (column > board.Columns)
            {
                throw new IndexOutOfRangeException(errrorMsg);
            }
           
        }
    }
}
