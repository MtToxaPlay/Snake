using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake1
{
    class FoodCreator
    {
        int mapHeight;
        int mapWidht;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapHeight, int mapWidht, char sym)
        {
            this.mapWidht = mapWidht;
            this.mapHeight = mapHeight;
            this.sym = sym;
       }

        public point CreateFood()
        { 
            int x = random.Next(5, mapWidht - 5);
            int y = random.Next(5, mapHeight - 5);
            return new point(x, y, sym);
        }
    }
}
