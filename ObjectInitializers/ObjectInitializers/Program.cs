using System;

namespace ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();

            Point anotherPoint = new Point(20, 20);
            anotherPoint.DisplayStats();

            Point finalPoint = new Point { X = 30, Y = 30 };
            finalPoint.DisplayStats();
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
        }
        public Point()
        {
        }
        public void DisplayStats()
        {
            Console.WriteLine($"[{X}, {Y}]");
        }
    }
}
