using BattleshipGame.Constants.Enums;
using BattleshipGame.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipGame.BLL
{
    public class Attack
    {
        public Boolean AttackCell(GameBoard board, int row, int column)
        {
            if (CheckAttach(board, row, column))
            {
                if (board.CellStatuses[row, column] ==CellStatus.Filled ||
                    board.CellStatuses[row, column] == CellStatus.Hit)
                {
                    board.CellStatuses[row, column] =CellStatus.Hit;
                    return true;
                }

                board.CellStatuses[row, column] = CellStatus.Miss;
                return false;
            }
            else
            {
                return false;
            }
        }


        private Boolean CheckAttach(GameBoard board, int row, int column)
        {
            //check if attack location is actually inside of the board
            if (row > board.Rows || column > board.Columns)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
