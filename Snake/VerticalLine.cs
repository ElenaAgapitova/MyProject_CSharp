﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class VerticalLine: Figure // ставим двоеточие, пишем название базового класса
    {
        
        public VerticalLine(int yUp, int yDown,int x, char sym, ConsoleColor color)
        {
            pList = new List<Point>();

            for(int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x,y,sym, color);
                pList.Add(p);
            }

        }

     }
}
