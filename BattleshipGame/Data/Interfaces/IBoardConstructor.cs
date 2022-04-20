using BattleshipGame.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipGame.Data.Interfaces
{
    public interface IBoardConstructor 
        //On run time, we can decide which class object we need to pass to Account via interface.
        //anything in this interface must be implemented in the class type of it 
    {
        GameBoard ConstructBoard(int rows, int columns); //interface member
    }
}
