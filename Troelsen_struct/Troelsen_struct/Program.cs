using System;

namespace Troelsen_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point myPoint;
            myPoint.x = 349;
            myPoint.y = 76;
            myPoint.Display();

            myPoint.Increm();
            myPoint.Display();
            //////////////////second way
            Point p1;
            p1.x = 10;
            p1.y = 10;
            p1.Display();
            /////////////////
            Point p2 = new Point();
            p2.Display(); //выводит x = 0, y = 0
            ////////////////
            Point p3 = new Point(50, 60);
            p3.Display(); //выводит x = 50, y = 60
        }
        struct Point
        {
            public Point(int xPos, int yPos)
            {
                x = xPos;
                y = yPos;
            }

            public int x;
            public int y;
            public void Increm()
            {
                x++;
                y++;
            }
            public void Decrem()
            {
                x--;
                y--;
            }
            public void Display()
            {
                Console.WriteLine($"x = {x}; y = {y}");
            }
        }
    }
}
