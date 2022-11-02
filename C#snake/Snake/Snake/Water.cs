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
            HorizontalLine lineUp = new HorizontalLine(0, mapWidth - 1, 0, '█', ConsoleColor.DarkCyan);
            VerticalLine lineLeft = new VerticalLine(0, mapHeight - 1, 0, '█', ConsoleColor.DarkCyan);
            HorizontalLine lineDown = new HorizontalLine(0, mapWidth - 1, mapHeight - 1, '█', ConsoleColor.DarkCyan);
            VerticalLine lineRight = new VerticalLine(0, mapHeight - 1, mapWidth - 1, '█', ConsoleColor.DarkCyan);

            waterList.Add(lineUp);
            waterList.Add(lineLeft);
            waterList.Add(lineDown);
            waterList.Add(lineRight);
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
