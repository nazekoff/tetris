using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Figure
    {
        public int sidelength;
        public char sym;

        public Figure(int a, char sym)
        {
            sidelength = a;
            this.sym = sym;
        }

        
        public void DrawSquare()
        {
            char[][] squareArray = new char[sidelength][];
            Random rand = new Random();

            for (int i = 0; i < squareArray.Length; i++)
            {
                squareArray[i] = new char[3];
                //squareArray[i] = new char[rand.Next(1, 8)];
            }



            for (int i = 0; i < squareArray.Length; i++)
            {
                for (int j = 0; j < squareArray[i].Length; j++)
                {
                    squareArray[i][j] = sym;
                    Console.Write(squareArray[i][j]);
                }
                Console.WriteLine();
            }
        }

    }
}
