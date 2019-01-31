using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(167, 44);

            //Отрисовка рамки
            HorizontalLine upline = new HorizontalLine(0, 165, 0, '+');
            HorizontalLine downline = new HorizontalLine(0, 165, 43, '+');
            VerticalLine leftline = new VerticalLine(0, 43, 0, '+');
            VerticalLine rightline = new VerticalLine(0, 43, 165, '+');
            upline.Drow();
            downline.Drow();
            leftline.Drow();
            rightline.Drow();

            //Отрисовка точек
            point p = new point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            while(true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}
