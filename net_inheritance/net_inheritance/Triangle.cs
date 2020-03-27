using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Inheritance
{
    class Triangle : TwoDShape
    {
        public string Style;
        public double Area()
        {
            return (Width * Height) / 2;
        }
        public void ShowStyle()
        {
            Console.WriteLine($"TRIANGLE {Style}");
        }
    }
}
