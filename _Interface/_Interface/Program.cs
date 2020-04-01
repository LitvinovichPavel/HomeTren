using System;

namespace _Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hexagon hexagon = new Hexagon("Peter");
            //IPointy itfPt = hexagon as IPointy;

            //if(itfPt != null)
            //{
            //    Console.WriteLine($"Points: {itfPt.Points}");
            //}
            //else
            //{
            //    Console.WriteLine($"OOPS!");
            //}

            Shape[] myShape = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("JoJo") };

            for(int i = 0; i < myShape.Length; i++)
            {
                myShape[i].Draw();

                if(myShape[i] is IPointy ip)
                {
                    Console.WriteLine($"Points: {ip.Points}");
                }
                else
                {
                    Console.WriteLine($"-> NO {myShape[i].PetName}");
                }
            }
        }
    }
}
