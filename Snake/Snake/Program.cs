using System;
using System.Collections.Generic;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            //Point p1 = new Point(1, 3, '*');
            //p1.Draw();

            //Point p2 = new Point(4, 5, '#');
            //p2.Draw();

            //bool error = false;
            //bool end = false;

            HorizontalLine line = new HorizontalLine(0, 40, 0, '+');
            HorizontalLine line1 = new HorizontalLine(0, 40, 22, '+');

            VerticalLine line2 = new VerticalLine(1, 21, 0, '+');
            VerticalLine line3 = new VerticalLine(1, 21, 40, '+');

            line.Draw();
            line1.Draw();
            line2.Draw();
            line3.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(18, 19, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                } else
                {
                    snake.Move();
                }

                Thread.Sleep(500);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }

                snake.Move();
            }
        }
    }
}
