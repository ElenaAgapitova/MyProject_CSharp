using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Water
    {
        List<Figure> waterList;

        public Water(int mapWidth, int mapHeight)
        {
            waterList = new List<Figure>();
            HorizontalLine lineUp = new HorizontalLine(1, mapWidth - 2, 1, '█', ConsoleColor.DarkCyan);
            VerticalLine lineLeft = new VerticalLine(1, mapHeight - 2, 1, '█', ConsoleColor.DarkCyan);
            VerticalLine lineLeft1 = new VerticalLine(1, mapHeight - 2, 2, '█', ConsoleColor.DarkCyan);
            HorizontalLine lineDown = new HorizontalLine(1, mapWidth - 2, mapHeight - 2, '█', ConsoleColor.DarkCyan);
            VerticalLine lineRight = new VerticalLine(1, mapHeight - 2, mapWidth - 2, '█', ConsoleColor.DarkCyan);
            VerticalLine lineRight1 = new VerticalLine(1, mapHeight - 2, mapWidth - 3, '█', ConsoleColor.DarkCyan);

            waterList.Add(lineUp);
            waterList.Add(lineLeft);
            waterList.Add(lineLeft1);
            waterList.Add(lineDown);
            waterList.Add(lineRight);
            waterList.Add(lineRight1);
        }

        internal bool isHit(Figure figure)
        {
            foreach(var water in waterList)
            {
                if(water.IsHit(figure))
                    return true;
            }
            return false;
        }
        public void Draw()
        {
            foreach(var water in waterList)
            {
                water.Draw();
            }
        }
    }
}
