using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake1
{
    class Figure
    {
       protected List<point> plist;

        public void Drow()
        {
            foreach (point p in plist)
            {
                p.draw();
            }
        }
    }
}
