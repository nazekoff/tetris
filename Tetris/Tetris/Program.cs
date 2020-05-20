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

            //Figure s = new Stick(20, 5, '*');
            Figure[] f = new Figure[2];
            f[0] = new Stick(20, 5, '*');
            f[1] = new Square(25, 7, '*');

            Random rand = new Random();
            int val = rand.Next(0, 2);

            f[val].Draw();

            
            ////////////

            //s.Draw();

            //Thread.Sleep(500);
            //s.Hide();
            //s.Rotate();
            //s.Draw();


            //Thread.Sleep(500);
            //s.Hide();
            //s.Move(Direction.LEFT);
            //s.Draw();


            //Thread.Sleep(500);
            //s.Hide();
            //s.Move(Direction.DOWN);
            //s.Draw();


            //Thread.Sleep(500);
            //s.Hide();
            //s.Move(Direction.RIGHT);
            //s.Draw();


            //Thread.Sleep(500);
            //s.Hide();
            //s.Rotate();
            //s.Draw();


            Console.ReadKey();
        }
                
    }
}
