using Snake;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.SetWindowSize(100, 30); // задали размер окна
        Console.SetBufferSize(100, 30); // размер рамки
        Console.CursorVisible = false;

        Water water = new Water(100, 30);
        water.Draw();
       
        

        Point p = new Point(4, 5, '█', ConsoleColor.DarkGreen); 
        CreateSnake snake = new CreateSnake(p, 5, Direction.RIGHT);
        snake.Draw();

        int snakeSpeed = 150; // начальная скорость, замедление уменьшается на 5 едениц после еды

        FoodCreator foodCreator = new FoodCreator(80, 25, '■', ConsoleColor.Red); 
        Point food = foodCreator.CreateFood();
        food.Draw();

        int score = 0; // за каждую съеденную еду 10 очков
                                  
        while(true)
        {
            if(water.isHit(snake) || snake.IsHitTail())
            {
                Console.Beep(200, 600);
                Console.Clear();
                WriteGameOver(score);
                break;
            }
            if (snake.Eat(food))
            {
                Console.Beep(1200,200);
                food = foodCreator.CreateFood();
                food.Draw();
                snakeSpeed -= 5;
                score += 10;

            }
            else
            {
                snake.Move();
            }
            Thread.Sleep(snakeSpeed);


            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                snake.HandleKey(key.Key);
            }
        }  

        static void WriteGameOver(int score)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(40, 11);
            Console.WriteLine("====================");
            Console.SetCursorPosition(40, 13);
            Console.WriteLine(" G A M E   O V E R");
            Console.SetCursorPosition(40, 15);
            Console.WriteLine($"   Game score: {score}");
            Console.SetCursorPosition(40, 17);
            Console.WriteLine("====================");
        }
                
        Console.ReadLine(); 

     }
}

