using Snake;

internal class Program
{
    private static void Main(string[] args)
    {
        /* Point p1 = new Point(1,3,'*');
         p1.Draw();

         Point p2 = new Point(4,5,'#');
         p2.Draw();*/

        Console.SetWindowSize(80, 25); // задали размер окна
        Console.SetBufferSize(80, 25); // размер рамки

        // Описание рамки:
        HorizontalLine lineUp = new HorizontalLine(0,78,0,'+');
        lineUp.Print();      
        VerticalLine lineLeft = new VerticalLine(0,24,0,'+');
        lineLeft.Print();
        HorizontalLine lineDown = new HorizontalLine(0, 78, 24, '+');
        lineDown.Print();
        VerticalLine lineRight = new VerticalLine(0, 24, 78, '+');
        lineRight.Print();

        // Отрисовка точек:
        Point p = new Point(4, 5, '*');
        p.Draw();

        Console.ReadLine();
    }

}