using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Inheritance
{
    class Triangle : TwoDShape//
    {
        private string Style { get; set; }
        public Triangle()
        {
            Style = "null";
        }
        public Triangle(string s, double w, double h) : base(w, h)
        {
            Style = s;
        }
        public Triangle(double x) : base(x)
        {
            Style = "равнобедренный";
        }
        public double Area()
        {
            return (Width * Height) / 2;
        }
        public void ShowStyle()
        {
            Console.WriteLine($"TRIANGLE: {Style}");
        }
    }
}
