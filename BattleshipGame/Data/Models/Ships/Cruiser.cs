using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BattleshipGame.Constants.Enums;

namespace BattleshipGame.Data.Models.Ships
{
    public class Cruiser : Ship
    {
        public Cruiser()
        {
            ShipLength = 3;
            ShipType = ShipType.Cruiser;
        }
    }
}
