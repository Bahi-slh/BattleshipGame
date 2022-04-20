using BattleshipGame.Constants.Enums;
using BattleshipGame.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipGame.Data.Interfaces
{
    public interface IAttack
    {
        Boolean AttackCell(GameBoard board, int row, int column);
    }
}
