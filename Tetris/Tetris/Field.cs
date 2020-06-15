using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Tetris
{
    static class Field
    {
        private static int _width = 30;
        private static int _height = 20;

        public static int Width
        {
            get
            {
                return _width;
            }
            set 
            {
                _width = value;
                Console.SetWindowSize(_width, Field.Height);
                Console.SetBufferSize(_width, Field.Height);
            }
        }

       

        public static int Height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;
                Console.SetWindowSize(value, Field.Height);
                Console.SetBufferSize(value, Field.Height);
            }
        }


        private static bool[][] _heap;

        static Field()
        {
            _heap = new bool[Height][];

            for (int i = 0; i < Height; i++)
            {
                _heap[i] = new bool[Width];
            }
        }

        internal static void DeleteLine()
        {
            int[] count = new int[Height];
            for (int i = 0; i < count.Length; i++)
            {
                count[i] = 0;
            }


            for (int i = 0; i < _heap.Length; i++)
            {
                for (int j = 0; j < _heap[i].Length; j++)
                {
                    if(_heap[i][j] == true )
                    {
                        count[i]++;
                    }
                }
            }


            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] < Field.Width)
                {
                    count[i] = 0;
                }
            }

           

            for (int i = 0; i < _heap.Length; i++)
            {
                for (int j = 0; j < _heap[i].Length; j++)
                {
                    if (_heap[i][j] == true && count[i] == Field.Width)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.WriteLine("#");
                    }
                }
            }


        }

        public static bool CheckStrike(Point p)
        {
            return _heap[p.Y][p.X];
        }


        public static void AddFigure(Figure fig)
        {
            foreach (var p in fig.Points)
            {
                _heap[p.Y][p.X] = true;
            }
        }



    }
}
