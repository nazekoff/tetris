using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Stick : Figure
    {
        
        public Stick(int x, int y, char sym)
        {
            points[0] = new Point(x, y, sym);
            points[1] = new Point(x, y + 1, sym);
            points[2] = new Point(x, y + 2, sym);
            points[3] = new Point(x, y + 3, sym);
            Draw();
        }


        //public void TryMove()
        //{
        //    Hide();
        //    var clone = Clone();

        //    Rotate();

        //}



        public override void Rotate()
        {
            Hide();
            var clone = Clone();
                        
            if (clone[0].x == clone[1].x)
            {
                RotateHorizontal(clone);
            }
            else
            {
                RotateVertical(clone);
            }


            if (VerifyPosition(clone))
            {
                points = clone;
            }

            Draw();
            Hide();
        }

        private void RotateVertical(Point[] clone)
        {
            for (int i = 0; i < clone.Length; i++)
            {
                clone[i].x = clone[0].x;
                clone[i].y = clone[0].y + i;
            }
        }

        private void RotateHorizontal(Point[] clone)
        {
            for (int i = 0; i < clone.Length; i++)
            {
                clone[i].y = clone[0].y;
                clone[i].x = clone[0].x + i;
            }
        }

    }
}
