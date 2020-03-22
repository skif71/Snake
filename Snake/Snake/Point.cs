﻿using System;
namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public bool error = false;

        public Point()
        {

        }

        public Point(int _x,int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }

            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }

        public bool isHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public void Draw()
        {
            
            try
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(sym);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Вы погибли");
                System.Environment.Exit(1);
            }
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}