﻿using System;
using System.Threading;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            FigureGenerator generator = new FigureGenerator(20, 0, '*');
            Figure s = null;


            while (true)
            {
                FigureFall(s, generator);
                //s.Draw();
            }
            
        }


        static void FigureFall(Figure fig, FigureGenerator generator)
        {
            fig = generator.GetNewFigure();
            fig.Draw();

            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(200);
                fig.Hide();
                fig.Move(Direction.DOWN);
                fig.Draw();
            }
            fig.Hide();
        } 
                
    }
}
