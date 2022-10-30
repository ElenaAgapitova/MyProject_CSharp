using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Figure // базовый класс для наследников горизонтальные и вертикальные линии, здесь общий код для обоих классов
    {
        protected List<Point> pList; // пишем protected
        public void Print()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }

        }
    }
}
