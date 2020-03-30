using System;
using System.Collections.Generic;
using System.Text;

namespace Shildt_inheristance
{
    class Triangle : TwoDShape
    {
        string Style { get; set; }
        public Triangle()
        {
            Style = "null";
        }
        public Triangle(string s, double w, double h) : base(w, h, "треугольгик")
        {
            Style = s;
        }
        public Triangle(double x) : base(x, "треугольгик")
        {
            Style = "равнобедренный";
        }
        public Triangle(Triangle ob) : base(ob)
        {
            Style = ob.Style;
        }
        public override double Area()
        {
            return (Width * Height) / 2;
        }
        public void ShowStyle()
        {
            Console.WriteLine($"Треугольник: {Style}");
        }
    }
}
