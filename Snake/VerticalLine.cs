using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine : Figur
    {
        public VerticalLine(int x, int y, int length)
        {
            this.x = x;
            this.y = y;
            this.length = length;
            for (int i = 0; i <= length; i++)
            {
                pList.Add(new Point(x, y + i, '*'));
            }
        }
    }
}
