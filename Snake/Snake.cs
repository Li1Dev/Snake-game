using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Snake : Figur
    {
        direction dir;
        public Point head;
        Point tail;

        public Snake(int x, int y, direction dir)
        {
           
            length = 4;
            this.x = x;
            this.y = y;
            this.dir = dir;
            for (int i = 0; i <= length; i++)
            {
                pList.Add(new Point(x + i, y, '#'));
            }
            this.x += 3;
        }
        public void Move() 
        {
            head = GetNextPoin();
            pList.Add(head);
            tail = pList[0];
            pList.Remove(tail);
            tail.Clear();
            Drow();
        }
        public void Rotation(ConsoleKey key) 
        {
            if (key == ConsoleKey.UpArrow && dir != direction.Down)
            {
                dir = direction.Up;
            }
            else if (key == ConsoleKey.DownArrow && dir != direction.Up)
            {
                dir = direction.Down;
            }
            else if (key == ConsoleKey.LeftArrow && dir != direction.Right)
            {
                dir = direction.Left;
            }
            else if (key == ConsoleKey.RightArrow && dir != direction.Left)
            {
                dir = direction.Right;
            }
        }
        public Point GetHead() 
        {
            return pList[pList.Count - 1];
        }
        public void Elongation() 
        {
            pList.Add(GetNextPoin());
            length++;
        }

        public Point GetNextPoin() 
        {
            Point nextPoint = GetHead();
            if (dir == direction.Right)
            {
                x++;
                nextPoint = new Point(x, y, '#');
                
            }
            else if (dir == direction.Left)
            {
                x--;
                nextPoint = new Point(x, y, '#');
              
            }
            else if (dir == direction.Up)
            {
                y--;
                nextPoint = new Point(x, y, '#');
            }
            else if (dir == direction.Down)
            {
                y++;
                nextPoint = new Point(x, y, '#');
            }
            return nextPoint;
        }
    }
}
