using System;

namespace Tetris
{
    internal class FigureGenerator
    {
        private int _x;
        private int _y;
        private char _c;

        private Random _rand = new Random();
        
        public FigureGenerator(int x, int y, char c)
        {
            _x = x;
            _y = y;
            _c = c;
        }

        public Figure GetNewFigure(out bool boolFig)
        {
            if(_rand.Next(0, 2) == 0)
            {
                boolFig = false;
                return new Square(_x, _y, _c);
            }

            else
            {
                boolFig = true;
                return new Stick(_x, _y, _c);
            }
        }
    }
}