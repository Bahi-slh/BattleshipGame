using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipGame.Data.DTOs

{
    public class GameBoardDto
    //A data transfer object/DTO is an object that carries data between processes. it facilitates communication between two systems (like an API and your server)
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
    }
}
