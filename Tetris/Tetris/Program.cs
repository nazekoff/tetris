using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Figure square = new Figure(3, '*');
            square.DrawSquare();


            Console.ReadKey();
        }

        
    }
}
