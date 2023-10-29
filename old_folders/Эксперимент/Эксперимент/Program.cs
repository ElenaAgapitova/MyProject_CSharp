using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace Эксперимент
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.BrushColor = "Blue";
            var stone = Shapes.AddEllipse(12, 12);
            int x = GraphicsWindow.Width / 2;
            int y = GraphicsWindow.Height / 2;
            Shapes.Move(stone, x, y);


            
            
            
             
           
        }
    }
}
