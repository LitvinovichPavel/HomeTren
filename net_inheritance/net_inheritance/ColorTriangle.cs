using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Inheritance
{
    class ColorTriangle : Triangle
    {
        private string color;
        public ColorTriangle(string c, string s, double w, double h) : base(s, w, h)
        {
            color = c;
        }
        public void ShowColor()
        {
            Console.WriteLine($"Цвет: {color}");
        }
    }
}
