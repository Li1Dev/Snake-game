using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static Snake snake;
        static Timer time;
        static HorisontalLine upLine;
        static HorisontalLine downLine;
        static VerticalLine leftLine;
        static VerticalLine rightLine;
        static Food food;
        static bool gameOver;


        static void Main(string[] args)
        {
            gameOver = false;
            direction dir = direction.Right;
            snake = new Snake(7, 4, dir);
            upLine = new HorisontalLine(0, 0, 78);
            downLine = new HorisontalLine(0, 20, 78);
            leftLine = new VerticalLine(0, 0, 20);
            rightLine = new VerticalLine(78, 0, 20);
            Console.CursorVisible = false;

            Console.ForegroundColor = ConsoleColor.Blue;
            downLine.Drow();
            leftLine.Drow();
            upLine.Drow();
            rightLine.Drow();
            Console.ResetColor();

            snake.Drow();
            CreateFood();

            time = new Timer(Loop, null, 0, 200);

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Rotation(key.Key);
                }
                if (gameOver)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(35, 10);
                    Console.Write("Game Over");
                    Console.SetCursorPosition(34, 11);
                    Console.Write("You're dead");
                }
            }

            

        }
        static void Loop(object obj)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            snake.Move();
            Console.ResetColor();
            if (upLine.IsHit(snake.GetHead()) || downLine.IsHit(snake.GetHead()) || rightLine.IsHit(snake.GetHead()) || leftLine.IsHit(snake.GetHead()) || snake.IsHit(snake.GetHead()))
            {
                time.Change(Timeout.Infinite, Timeout.Infinite);
                gameOver = true;
            }
            Eat();
            
        }
        static void CreateFood() 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            food = new Food();
            food.Drow();
            Console.ResetColor();
        }
        static void Eat() 
        {
            if (food.IsHit(snake.GetHead()))
            {
                snake.Elongation();
                CreateFood();
            }
        }

        
    }
}
