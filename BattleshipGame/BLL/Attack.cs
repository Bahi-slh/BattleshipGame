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
        AttackStatus AttackCell(int row, int column, GameBoard board)
        {
            ValidateAttack(row, column, board);
            //if attack HITs
            if (board.CellStatuses[row, column] == CellStatus.Filled)
            {
                return AttackStatus.Hit;
            }
            return AttackStatus.Miss;
        }


        private void ValidateAttack(int row, int column, GameBoard board)
        {
            string errrorMsg = "This attack is invalid";
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
