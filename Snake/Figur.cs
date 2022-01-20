using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Figur
    {
        public int length;
        public int x;
        public int y;
        public List<Point> pList = new List<Point>();

        public void Drow()
        {
            for (int i = 0; i < pList.Count; i++)
            {
                pList[i].Drow();
            }
        }

        public bool IsHit(Point point) 
        {
            for (int i = 1; i < length - 1; i++)
            {
                if (point.x == pList[i].x && point.y == pList[i].y)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
