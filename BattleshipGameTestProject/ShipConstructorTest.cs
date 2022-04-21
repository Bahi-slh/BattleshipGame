using System;
using System.Text;
using BattleshipGame.BLL;
using BattleshipGame.Constants.Enums;
using Xunit;

namespace BattleshipGameTestProject
{
    public class ShipConstructorTest
    {

        [Theory]
        [InlineData(ShipType.Destroyer)]
        public void AddShip_MethodTest(ShipType shipType)
        {
            var shipConstructor = new ShipConstructor();
            var ship = shipConstructor.AddShip(shipType);

            Assert.NotNull(ship);
        }
    }
}

