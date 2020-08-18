using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Winner
    {
        public bool chickenDinner(Board masterBoard)
        {
            if (
                    (masterBoard.square1 == 1 && masterBoard.square2 == 1 && masterBoard.square3 == 1) ||
                    (masterBoard.square4 == 1 && masterBoard.square5 == 1 && masterBoard.square6 == 1) ||
                    (masterBoard.square7 == 1 && masterBoard.square8 == 1 && masterBoard.square9 == 1) ||
                    (masterBoard.square1 == 1 && masterBoard.square4 == 1 && masterBoard.square7 == 1) ||
                    (masterBoard.square2 == 1 && masterBoard.square5 == 1 && masterBoard.square8 == 1) ||
                    (masterBoard.square3 == 1 && masterBoard.square6 == 1 && masterBoard.square9 == 1) ||
                    (masterBoard.square1 == 1 && masterBoard.square5 == 1 && masterBoard.square9 == 1) ||
                    (masterBoard.square3 == 1 && masterBoard.square5 == 1 && masterBoard.square7 == 1))
            {
                Console.WriteLine("\nPlayer 1 wins!");
                Console.ReadLine();
                return true;
            }
            else if (
                (masterBoard.square1 == 2 && masterBoard.square2 == 2 && masterBoard.square3 == 2) ||
                (masterBoard.square4 == 2 && masterBoard.square5 == 2 && masterBoard.square6 == 2) ||
                (masterBoard.square7 == 2 && masterBoard.square8 == 2 && masterBoard.square9 == 2) ||
                (masterBoard.square1 == 2 && masterBoard.square4 == 2 && masterBoard.square7 == 2) ||
                (masterBoard.square2 == 2 && masterBoard.square5 == 2 && masterBoard.square8 == 2) ||
                (masterBoard.square3 == 2 && masterBoard.square6 == 2 && masterBoard.square9 == 2) ||
                (masterBoard.square1 == 2 && masterBoard.square5 == 2 && masterBoard.square9 == 2) ||
                (masterBoard.square3 == 2 && masterBoard.square5 == 2 && masterBoard.square7 == 2))
            {
                Console.WriteLine("\nPlayer 2 wins!");
                Console.ReadLine();
                return true;
            }
            return false;
        }
       
    }
}
