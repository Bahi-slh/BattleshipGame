using BattleshipGame.Constants.Enums;
using BattleshipGame.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipGame.Data.DTOs
{
    public class ShipDto
    {
        public ShipType Ship { get; set; }
        //public GameBoard Board { get; set; }
        public int BoardRow { get; set; }
        public int BoardColumn { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }

        public ShipDirection Direction { get; set; }
    }
}
