using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class HorizontalLine: Figure // ставим двоеточие, пишем название базового класса
    {
      
        public HorizontalLine(int xLeft, int xRight, int y, char sym, ConsoleColor color)
        {
            pList = new List<Point>();
            for(int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x,y,sym, color);
                pList.Add(p);
            }
           
        }

    }
}
