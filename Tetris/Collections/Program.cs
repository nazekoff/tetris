using System;
using Tetris;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums1 = new int[5];
            //nums1[0] = 1;
            //nums1[1] = 3;



            //for (int i = 0; i < num1.Length; i++)
            //{
            //    Console.WriteLine(num1[i]);
            //}

            //foreach (int i in nums1)
            //{
            //    Console.WriteLine(i);
            //}

            //Point[] points = new Point[3];
            //points[0] = new Point(2, 3, '*');
            //points[1] = new Point(4, 5, '%');
            //points[2] = new Point(6, 7, '#');

            //foreach (Point p in points)
            //{
            //    p.Draw();
            //}



            char[][] field = new char[3][];
            for (int i = 0; i < field.Length; i++)
            {
                field[i] = new char[3];
            }

            field[0][0] = 'X';
            field[2][2] = '0';


            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < field.Length; j++)
                {
                    Console.Write(field[i][j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
