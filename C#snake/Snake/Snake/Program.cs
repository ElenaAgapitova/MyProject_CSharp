using Snake;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Console.SetWindowSize(80, 25); // задали размер окна
        Console.SetBufferSize(80, 25); // размер рамки

        // Описание рамки:
        HorizontalLine lineUp = new HorizontalLine(0,78,0,'+');
        lineUp.Print();      
        VerticalLine lineLeft = new VerticalLine(0,24,0,'+');
        lineLeft.Print();
        HorizontalLine lineDown = new HorizontalLine(0, 78, 24, '+');
        lineDown.Print();
        VerticalLine lineRight = new VerticalLine(0, 24, 78, '+');
        lineRight.Print();*/

        // Змейка:

        Point p = new Point(4, 5, '*');
        CreateSnake snake = new CreateSnake(p, 4, Direction.RIGHT);
        snake.Print();

        snake.Move();
        Thread.Sleep(100);
        snake.Move();
        Thread.Sleep(100);
        snake.Move();
        Thread.Sleep(100);
        snake.Move();
        Thread.Sleep(100);
        snake.Move();
        Thread.Sleep(100);
        snake.Move();
        Thread.Sleep(100);
        snake.Move();
        Thread.Sleep(100);
        snake.Move();
        Thread.Sleep(100);
        snake.Move();
        Thread.Sleep(100);


        List<int> numList = new List<int>();
        numList.Add(0);
        numList.Add(1);
        numList.Add(2);

        int x = numList[0];
        int y = numList[1];
        int z = numList[2];

        foreach(int i in numList)
        {
            Console.WriteLine(i);
        }

        numList.RemoveAt(0);

        List<Point> plist = new List<Point>();
        plist.Add(p1);
        plist.Add(p2);

        Console.ReadLine();
    }

}