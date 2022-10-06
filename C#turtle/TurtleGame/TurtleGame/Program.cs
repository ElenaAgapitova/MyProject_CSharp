using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown; // Вызов функции, при нажатии клавиши черепашка будет менять направление движения;

            Turtle.PenUp(); // Команда, которая убирает шлейф (рисунок линии) за черепашкой; Turtle.PenDown(); - будет оставлять след;

            // var x = 0; -> var - используется, если не хотим указывать тип данных, int x = 0; (int - целое число), программа понимает, какая переменная по значению справа.

            GraphicsWindow.BrushColor = "Yellow"; // Добавили цвет, кисть которой рисуем имеет цвет желтый;
            var eat = Shapes.AddRectangle(10, 10); // Shapes.AddRectangle - вызов квадрата со сторонами 10 на 10;
            Shapes.Move(eat, 200, 200); // Будем двигать еду в координатах 200 - 200;

            while (true)  // Черепашка будет двигаться всегда, без остановок;
            {
                Turtle.Move(10);
            }

        }

        private static void GraphicsWindow_KeyDown() // Описание функции нажатии клавиш, будет меняться направление движения только, если нажимаем стрелочки вверх/вниз/направо/налево
        {
            if(GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;
            }
            else if(GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            }
            else if(GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;
            }
            else if(GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;
            } // при нажатии других клавиш черепашка не будет менять направления движений
        }
    }
}
