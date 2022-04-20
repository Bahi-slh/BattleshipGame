using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BattleshipGame.Constants.Enums;

namespace BattleshipGame.Data.Models.Ships
{
    public class BattleShip : Ship //Inherits Ship
    {
        public BattleShip()
        {
            ShipLength = 4;
            ShipType = ShipType.BattleShip;
        }
    }
}
