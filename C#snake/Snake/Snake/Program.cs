using Snake;

internal class Program
{
    private static void Main(string[] args)
    {
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

        // Змейка:

        Point p = new Point(4, 5, '*');
        CreateSnake snake = new CreateSnake(p, 4, Direction.RIGHT);
        snake.Print();

        Console.ReadLine();
    }

}