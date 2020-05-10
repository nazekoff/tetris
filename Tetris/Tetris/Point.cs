using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    public class Point 
    {
        public int x;
        public int y;
        public char sym;

        public Point(int a, int b, char c)
        {
            x = a;
            y = b;
            sym = c;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
