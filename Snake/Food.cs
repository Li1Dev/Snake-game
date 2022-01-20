using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Food : Point
    {
        Random rnd = new Random();
        public Food() : base()
        {
            x = rnd.Next(1, 77);
            y = rnd.Next(1, 19);
            sym = '$';
        }

        public bool IsHit(Point p) 
        {
            if (x == p.x && y == p.y)
            {
                return true;
            }
            return false;
        }
    }
}
