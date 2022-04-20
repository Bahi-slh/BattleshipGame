using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BattleshipGame.Constants.Enums;

namespace BattleshipGame.Data.Models.Ships
{
    public class Destroyer : Ship //Inherits Ship
    {
        public Destroyer()
        {
            ShipLength = 2;
            ShipType = ShipType.Destroyer;
        }
    }
}
