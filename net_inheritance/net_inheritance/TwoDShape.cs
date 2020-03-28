using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Inheritance
{
    class TwoDShape
    {
        public double Width { get; set; }//
        public double Height { get; set; }
        public TwoDShape()
        {
            Width = 0;
            Height = 0;
        }
        public TwoDShape(double w, double h)
        {
            Width = w;
            Height = h;
        }
        public TwoDShape(double x)
        {
            Width = x;
            Height = x;
        }
        public void ShowDim()
        {
            Console.WriteLine($"WIDTH: {Width}, HEIGHT: {Height}");
        }
    }
}
