using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleTraining2
{
    internal class Program
    {
        static void WriteT(int size1, int size2)
        {
            // Буква "Т" начало
            Turtle.Angle = 0; // направление наверх = 0
            Turtle.Move(size1);
            Turtle.Angle = 270; //поворот налево, можно Turtle.TurnLeft();
            Turtle.Move(size2);
            Turtle.Angle = 90;
            Turtle.Move(size2*2);
            // Буква Т конец
        }
        static void WriteO(int size)
        {
            // Буква О начало
            Turtle.Angle = 0;
            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(size);
                Turtle.TurnRight();
            }
            // Буква О конец
        }

        static void WriteP(int size1, int size2)
        {
            Turtle.Angle = 0;
            Turtle.Move(size1);
            Turtle.TurnRight();
            Turtle.Move(size2);
            Turtle.TurnRight();
            Turtle.Move(size2);
            Turtle.TurnRight();
            Turtle.Move(size2);
            Turtle.TurnLeft();
            Turtle.Move(size2);
        }

        static void Main(string[] args)
        {
            /*
            Turtle.Speed = 9;
            int i = 0;
            while (i < 4)
            {
                Turtle.Move(100);
                //Turtle.TurnRight();
                Turtle.Turn(45);
                i++;
            }
          */
            /*
            Turtle.Speed = 9;

            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(30);
                Turtle.TurnRight();
                Turtle.Move(30);
                Turtle.TurnRight();
                Turtle.Move(30);
                Turtle.TurnLeft();
                Turtle.Move(30);
                Turtle.TurnLeft();
              
            }
            
            
            Turtle.Speed = 9;
            int i = 0;

            while (i<6)
            {
                Turtle.Move(100);
                Turtle.Turn(60);
                i++;
            }
            */

            // Пишем слово торт

            Turtle.Speed = 9;
            Turtle.X = 200;
            Turtle.Y = 200;

            WriteT(60,20);

            Turtle.X = 260;
            Turtle.Y = 200;

            WriteO(40);

            Turtle.X = 340;
            Turtle.Y = 200;

            WriteP(40, 20);
           
         
            Turtle.X = 400;
            Turtle.Y = 200;

            WriteT(40,15);



        }
    }
}
