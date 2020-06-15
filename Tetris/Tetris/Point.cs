using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    public class Point 
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char SYM { get; set; }
        

        public Point(int a, int b, char c)
        {
            X = a;
            Y = b;
            SYM = c;
        }

        public Point(Point p) 
        {
            X = p.X;
            Y = p.Y;
            SYM = p.SYM;
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(SYM);
        }

        internal void Move(Direction dir)
        {
            switch (dir)
            {
                case Direction.DOWN:
                    Y += 1;
                    break;
                case Direction.LEFT:
                    X -= 1;
                    break;
                case Direction.RIGHT:
                    X += 1;
                    break;
            }
        }

        internal void Hide()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(" ");
        }
    }
}
