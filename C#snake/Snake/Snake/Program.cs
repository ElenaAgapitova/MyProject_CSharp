using Snake;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.SetWindowSize(100, 30); // задали размер окна
        Console.SetBufferSize(100, 30); // размер рамки
        Console.CursorVisible = false;

        Water water = new Water(100, 30);
        water.Draw();

        Point p = new Point(4, 5, '█', ConsoleColor.DarkMagenta);
        CreateSnake snake = new CreateSnake(p, 4, Direction.RIGHT);
        snake.Print();

        FoodCreator foodCreator = new FoodCreator(80, 25, '█');
        Point food = foodCreator.CreateFood();
        food.Draw();
           
                        
        while(true)
        {
            if(water.isHit(snake) || snake.IsHitTail())
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(40, 13);
                Console.WriteLine("==================");
                Console.SetCursorPosition(40, 15);
                Console.WriteLine("G A M E   O V E R");
                Console.SetCursorPosition(40, 17);
                Console.WriteLine("==================");
                break;
            }
            if(snake.Eat(food))
            {
                food = foodCreator.CreateFood();
                food.Draw();
            }
            else
            {
                snake.Move();
            }
            Thread.Sleep(150);

            if(Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                snake.HandleKey(key.Key);
            }
        }  
        
        
        Console.ReadLine(); 

     }
}

