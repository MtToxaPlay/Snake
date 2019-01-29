using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake1
{
    class VerticalLine
    {
        List<point> plist;

        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            plist = new List<point>();
            for (int y = yUp; y <= yDown; y++)

            {
                point p = new point(x, y, sym);
                plist.Add(p);
            }

        }

        public void Drow()
        {
            foreach (point p in plist)
            {
                p.draw();
            }
        }

    }
}
