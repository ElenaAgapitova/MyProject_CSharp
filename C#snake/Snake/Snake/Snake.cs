﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Snake
{
    internal class CreateSnake : Figure
    {
        Direction direction;
        public CreateSnake(Point tail, int length, Direction direction1)
        {
            direction = direction1;
            pList = new List<Point>();
            for(int i = 0; i < length; i++)
            {
                Point p = new Point (tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if(head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }


    }
}
