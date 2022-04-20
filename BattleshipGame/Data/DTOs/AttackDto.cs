using BattleshipGame.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipGame.Data.DTOs
{
    public class AttackDto
    {
        public int BoardRows { get; set; } 
        public int BoardColumns { get; set; } 
        public int Row { get; set; }
        public int Column { get; set; }
    }
}
