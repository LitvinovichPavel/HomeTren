using System;

namespace Net_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle1 = new Triangle();
            Triangle triangle2 = new Triangle("прямоугольный", 8, 12);
            Triangle triangle3 = new Triangle(4);

            triangle1 = triangle2;

            Console.WriteLine($"OBJECT INFORMATION ONE: ");
            triangle1.ShowStyle();
            triangle1.ShowDim();
            Console.WriteLine($"AREA: {triangle1.Area()}\n");

            Console.WriteLine($"OBJECT INFORMATION TWO");
            triangle2.ShowStyle();
            triangle2.ShowDim();
            Console.WriteLine($"AREA: {triangle2.Area()}\n");

            Console.WriteLine($"OBJECT INFORMATION THREE");
            triangle3.ShowStyle();
            triangle3.ShowDim();
            Console.WriteLine($"AREA: {triangle3.Area()}\n");
        }
    }
}
