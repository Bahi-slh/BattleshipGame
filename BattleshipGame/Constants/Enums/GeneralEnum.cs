using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipGame.Constants.Enums
{
    //public enum AttackStatus
    //{
    //    Hit,
    //    Miss
    //}

    public enum CellStatus
    {
        Filled,
        Empty, 
        Hit, 
        Miss

    }

    public enum ShipDirection
    {
        Horizontal,
        Vertical
    }

    public enum ShipType
    {
        Destroyer,
        Cruiser,
        BattleShip,
        Carrier
    }
}
