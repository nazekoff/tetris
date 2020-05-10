using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Figure[] f = new Figure[2];
            f[0] = new Stick(8, 8, '*');
            f[1] = new Square(2, 3, '*');

            foreach (Figure fig in f)
            {
                fig.Draw();
            }


            Console.ReadKey();
        }

        
    }
}
