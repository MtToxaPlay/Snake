using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake1
{
    class Program
    {
        static void Main(string[] args)
        {
            point p1 = new point(1, 3, '*');
            p1.draw();

            point p2 = new point(4, 5, '#');
            p2.draw();

            HorizontalLine line = new HorizontalLine(5, 10, 8, '+');
            line.Drow();

            VerticalLine Line = new VerticalLine(10, 5, 8, '+');
            Line.Drow();

            Console.ReadLine();

        }
    }
}
