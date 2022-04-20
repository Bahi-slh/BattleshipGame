using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BattleshipGame.Constants.Enums;

namespace BattleshipGame.Data.Models.Ships
{
    public class Carrier : Ship //Inherits Ship
    {
        public Carrier()
        {
            ShipLength = 5;
            ShipType = ShipType.Carrier;
        }
    }
}
