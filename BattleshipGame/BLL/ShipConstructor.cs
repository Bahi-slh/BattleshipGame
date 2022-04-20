using BattleshipGame.Constants.Enums;
using BattleshipGame.Data.Models;
using BattleshipGame.Data.Models.Ships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipGame.BLL
{
    public class ShipConstructor
    {
        public Ship AddShip(ShipType shipType)
        {
            try
            {
                switch (shipType)
                {
                    case ShipType.BattleShip:
                        return new BattleShip();

                    case ShipType.Carrier:
                        return new Carrier();

                    case ShipType.Cruiser:
                        return new Cruiser();

                    case ShipType.Destroyer:
                        return new Destroyer();

                    default:
                        return new Destroyer();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ship was not added: {ex.Message}");
            }
        }
    }
}
