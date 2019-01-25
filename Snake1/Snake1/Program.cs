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
            Console.ReadLine();

        }
    }
}
