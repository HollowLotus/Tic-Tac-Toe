using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public class Board
    {
        //Declaration of objects
        Players playerOne = new Players();
        Winner whoWon = new Winner();

        //declaration of variables
        public int square1 = 0;
        public int square2 = 0;
        public int square3 = 0;
        public int square4 = 0;
        public int square5 = 0;
        public int square6 = 0;
        public int square7 = 0;
        public int square8 = 0;
        public int square9 = 0;
        
        public void Draw()
        {
         
            while (true)
            {
                playerOne.player1(this);

                //--------------------------Square 1
                if (square1 == 0)
                {
                    Console.Write('-');
                }
                else if (square1 == 1)
                {
                    Console.Write('X');
                }
                else if (square1 == 2)
                {
                    Console.Write('O');
                }

                //--------------------------Square 2
                if (square2 == 0)
                {
                    Console.Write('-');
                }
                else if (square2 == 1)
                {
                    Console.Write('X');
                }
                else if (square2 == 2)
                {
                    Console.Write('O');
                }

                //--------------------------Square 3
                if (square3 == 0)
                {
                    Console.WriteLine('-');
                }
                else if (square3 == 1)
                {
                    Console.WriteLine('X');
                }
                else if (square3 == 2)
                {
                    Console.WriteLine('O');
                }

                //--------------------------Square 4
                if (square4 == 0)
                {
                    Console.Write('-');
                }
                else if (square4 == 1)
                {
                    Console.Write('X');
                }
                else if (square4 == 2)
                {
                    Console.Write('O');
                }

                //--------------------------Square 5
                if (square5 == 0)
                {
                    Console.Write('-');
                }
                else if (square5 == 1)
                {
                    Console.Write('X');
                }
                else if (square5 == 2)
                {
                    Console.Write('O');
                }

                //--------------------------Square 6
                if (square6 == 0)
                {
                    Console.WriteLine('-');
                }
                else if (square6 == 1)
                {
                    Console.WriteLine('X');
                }
                else if (square6 == 2)
                {
                    Console.WriteLine('O');
                }

                //--------------------------Square 7
                if (square7 == 0)
                {
                    Console.Write('-');
                }
                else if (square7 == 1)
                {
                    Console.Write('X');
                }
                else if (square7 == 2)
                {
                    Console.Write('O');
                }

                //--------------------------Square 8
                if (square8 == 0)
                {
                    Console.Write('-');
                }
                else if (square8 == 1)
                {
                    Console.Write('X');
                }
                else if (square8 == 2)
                {
                    Console.Write('O');
                }

                //--------------------------Square 9
                if (square9 == 0)
                {
                    Console.WriteLine('-');
                }
                else if (square9 == 1)
                {
                    Console.WriteLine('X');
                }
                else if (square9 == 2)
                {
                    Console.WriteLine('O');
                }

                if (whoWon.chickenDinner(this))
                {
                    break;
                }

                playerOne.Player2(this);

                //--------------------------Square 1
                if (square1 == 0)
                {
                    Console.Write('-');
                }
                else if (square1 == 1)
                {
                    Console.Write('X');
                }
                else if (square1 == 2)
                {
                    Console.Write('O');
                }

                //--------------------------Square 2
                if (square2 == 0)
                {
                    Console.Write('-');
                }
                else if (square2 == 1)
                {
                    Console.Write('X');
                }
                else if (square2 == 2)
                {
                    Console.Write('O');
                }

                //--------------------------Square 3
                if (square3 == 0)
                {
                    Console.WriteLine('-');
                }
                else if (square3 == 1)
                {
                    Console.WriteLine('X');
                }
                else if (square3 == 2)
                {
                    Console.WriteLine('O');
                }

                //--------------------------Square 4
                if (square4 == 0)
                {
                    Console.Write('-');
                }
                else if (square4 == 1)
                {
                    Console.Write('X');
                }
                else if (square4 == 2)
                {
                    Console.Write('O');
                }

                //--------------------------Square 5
                if (square5 == 0)
                {
                    Console.Write('-');
                }
                else if (square5 == 1)
                {
                    Console.Write('X');
                }
                else if (square5 == 2)
                {
                    Console.Write('O');
                }

                //--------------------------Square 6
                if (square6 == 0)
                {
                    Console.WriteLine('-');
                }
                else if (square6 == 1)
                {
                    Console.WriteLine('X');
                }
                else if (square6 == 2)
                {
                    Console.WriteLine('O');
                }

                //--------------------------Square 7
                if (square7 == 0)
                {
                    Console.Write('-');
                }
                else if (square7 == 1)
                {
                    Console.Write('X');
                }
                else if (square7 == 2)
                {
                    Console.Write('O');
                }

                //--------------------------Square 8
                if (square8 == 0)
                {
                    Console.Write('-');
                }
                else if (square8 == 1)
                {
                    Console.Write('X');
                }
                else if (square8 == 2)
                {
                    Console.Write('O');
                }

                //--------------------------Square 9
                if (square9 == 0)
                {
                    Console.WriteLine('-');
                }
                else if (square9 == 1)
                {
                    Console.WriteLine('X');
                }
                else if (square9 == 2)
                {
                    Console.WriteLine('O');
                }

                if (whoWon.chickenDinner(this))
                {
                    break;
                }
            }
        }
    }
}
