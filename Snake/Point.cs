using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
   class Point
    {
        public int  x;
        public int  y;
        public char sym;

        public Point()
        {

        }
        public Point(int x, int y, char sym) 
        { 
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public void Drow()
        {
            DrowPoint(sym);
        }

        public void Clear() 
        {
            DrowPoint(' ');
        }
        private void DrowPoint(char ch)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(ch);
        }
    }
}
