using BattleshipGame.Constants.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipGame.Data.Models
{
    public abstract class Ship/// abstract beacuse it cannot be instantiated and is a base class
    {
        public ShipType ShipType { get; set; }
        public int ShipLength { get; set; }


    }
}
