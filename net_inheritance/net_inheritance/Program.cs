using System;

namespace Net_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle1 = new Triangle();
            Triangle triangle2 = new Triangle();

            triangle1.Width = 4;
            triangle1.Height = 4;
            triangle1.Style = "number one";

            triangle2.Width = 8;
            triangle2.Height = 12;
            triangle2.Style = "number two";

            Console.WriteLine($"Information triangle number ONE: ");
            triangle1.ShowStyle();
            triangle1.ShowDim();
            Console.WriteLine($"AREA = {triangle1.Area()}\n");

            Console.WriteLine($"Information triangle number TWO: ");
            triangle2.ShowStyle();
            triangle2.ShowDim();
            Console.WriteLine($"AREA = {triangle2.Area()}\n");

            TwoDShape twoDShape = new TwoDShape();
            twoDShape.Width = 11;
            twoDShape.Height = 22;
            twoDShape.ShowDim();
        }
    }
}
