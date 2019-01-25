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
            point p1 = new point();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            p1.draw();

            point p2 = new point();
            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';
            p2.draw();

            Console.ReadLine();

        }
    }
}
