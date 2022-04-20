using BattleshipGame.Constants.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipGame.Data.Models
{
    public class GameBoard
    {
        public CellStatus[,] CellStatuses { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }
    }
}
