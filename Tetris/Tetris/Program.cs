using System;
using System.Threading;

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

            Thread.Sleep(500);
            f[1].Hide();
            f[1].Move(Direction.LEFT);
            f[1].Draw();


            Thread.Sleep(500);
            f[1].Hide();
            f[1].Move(Direction.DOWN);
            f[1].Draw();


            Thread.Sleep(500);
            f[1].Hide();
            f[1].Move(Direction.RIGHT);
            f[1].Draw();


            Console.ReadKey();
        }
                
    }
}
