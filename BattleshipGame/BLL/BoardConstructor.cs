using BattleshipGame.Constants.Enums;
using BattleshipGame.Data.Interfaces;
using BattleshipGame.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipGame.BLL
{
    public class BoardConstructor : IBoardConstructor 
    {
        public GameBoard ConstructBoard(int rows, int columns)
        {

            try
            {
                //make a board and set cellStatus to empty cells
                CellStatus[,] statuses = new CellStatus[rows, columns];
                for (int row = 0; row < rows; row++)
                {
                    for (int column = 0; column < columns; column++)
                    {
                        statuses[row, column] = CellStatus.Empty;
                    }
                }

                GameBoard _board = new GameBoard();
                _board.CellStatuses = statuses;
                _board.Rows = rows;
                _board.Columns = columns;

                return _board;

            }
            catch (Exception ex)
            {
                throw new Exception($"Creating Board Failed: {ex.Message}");

            }
        }
    }
}
