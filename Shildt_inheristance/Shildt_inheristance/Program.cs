using System;

namespace Shildt_inheristance
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoDShape[] shapes = new TwoDShape[5];

            shapes[0] = new Triangle("прямоугольный", 8, 12);
            shapes[1] = new Rectangle(10);
            shapes[2] = new Rectangle(10, 4);
            shapes[3] = new Triangle(7);
            shapes[4] = new TwoDShape(10, 20, "общая форма");

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine($"Объект - {shapes[i].Name}");
                Console.WriteLine($"Площадь равна - {shapes[i].Area()}\n");
            }
        }
    }
}
