/// Allan Atton
/// 9/18/19
/// tic-tac-toe
/// A game of tic-tac-toe using classes and objects

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            board.Draw();
        }
    }
}
