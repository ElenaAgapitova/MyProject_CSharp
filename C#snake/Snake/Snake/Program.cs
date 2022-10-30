using Snake;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.SetWindowSize(100, 30); // задали размер окна
        Console.SetBufferSize(100, 30); // размер рамки
        Console.CursorVisible = false;


        // Описание рамки:
        HorizontalLine lineUp = new HorizontalLine(0,99,0, '█');
        lineUp.Print();      
        VerticalLine lineLeft = new VerticalLine(0,29,0, '█');
        lineLeft.Print();
        HorizontalLine lineDown = new HorizontalLine(0, 99, 29, '█');
        lineDown.Print();
        VerticalLine lineRight = new VerticalLine(0, 29, 99, '█');
        lineRight.Print();

        // Змейка:

        Point p = new Point(4, 5, '█', ConsoleColor.DarkMagenta);
        CreateSnake snake = new CreateSnake(p, 5, Direction.RIGHT);
        snake.Print();

        FoodCreator foodCreator = new FoodCreator(80, 25, '█');
        Point food = foodCreator.CreateFood();
        food.Draw();
           
                        
        while(true)
        {
            if(snake.Eat(food))
            {
                food = foodCreator.CreateFood();
                food.Draw();
            }
            else
            {
                snake.Move();
            }
            Thread.Sleep(200);

            if(Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                snake.HandleKey(key.Key);
            }
            Thread.Sleep(200);
            snake.Move();
        }
       
        


        Console.ReadLine();
    }

}