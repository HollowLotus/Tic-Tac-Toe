using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Players
    {
        int playerX = 0;
        int playerO = 0;


        public void player1(Board masterboard)
        {
            Console.Write("Player One please enter a number 1 through 9! ");
            playerX = Convert.ToInt32(Console.ReadLine());
            

            if (playerX == 1)
            {
                masterboard.square1 = 1;
            }
            else if (playerX == 2)
            {
                masterboard.square2 = 1;
            }
            else if (playerX == 3)
            {
                masterboard.square3 = 1;
            }
            else if (playerX == 4)
            {
                masterboard.square4 = 1;
            }
            else if (playerX == 5)
            {
                masterboard.square5 = 1;
            }
            else if (playerX == 6)
            {
                masterboard.square6 = 1;
            }
            else if (playerX == 7)
            {
                masterboard.square7 = 1;
            }
            else if (playerX == 8)
            {
                masterboard.square8 = 1;
            }
            else if (playerX == 9)
            {
                masterboard.square9 = 1;
            }
        }
        
        public void Player2(Board masterboard)
        {
            Console.Write("Player two please enter a number 1 through 9! ");
            playerO = Convert.ToInt32(Console.ReadLine());

            if (playerO == 1)
            {
                masterboard.square1 = 2;
            }
            else if (playerO == 2)
            {
                masterboard.square2 = 2;
            }
            else if (playerO == 3)
            {
                masterboard.square3 = 2;
            }
            else if (playerO == 4)
            {
                masterboard.square4 = 2;
            }
            else if (playerO == 5)
            {
                masterboard.square5 = 2;
            }
            else if (playerO == 6)
            {
                masterboard.square6 = 2;
            }
            else if (playerO == 7)
            {
                masterboard.square7 = 2;
            }
            else if (playerO == 8)
            {
                masterboard.square8 = 2;
            }
            else if (playerO == 9)
            {
                masterboard.square9 = 2;
            }
        }          
    }
}
