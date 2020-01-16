using System;

namespace Value_Reference_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 10);
            Point p2 = p1;

            p1.Display();
            p2.Display();

            p1.x = 99;

            p1.Display();
            p2.Display();
        }
    }
    class Point
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Display()
        {
            Console.WriteLine($"x = {x}, y = {y}");
        }
    }
}
