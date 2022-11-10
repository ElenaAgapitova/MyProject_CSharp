using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Point
    {
        public int x;
        public int y;
        public char sym;
        public ConsoleColor color;
        public Point(int x, int y, char sym, ConsoleColor color)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
            this.color = color;
        }   
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
            color = p.color;
        }
        public void Move(int offset, Direction direction) // растояние offset направление Direction
        {
            if(direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if(direction == Direction.LEFT)
            {
                x = x - offset;
            }
            if(direction == Direction.UP)
            {
                y = y - offset;
            }
            else if(direction==Direction.DOWN)
            {
                y = y + offset;
            }
        }
        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
        public void Clear()
        {
            sym = ' ';
            Draw();
           
        }
         public void Draw()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
            Console.SetCursorPosition(1, 1);

        }
        
    }
}
