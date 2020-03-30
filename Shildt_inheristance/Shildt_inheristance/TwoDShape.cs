using System;
using System.Collections.Generic;
using System.Text;

namespace Shildt_inheristance
{
    class TwoDShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public string Name { get; set; }
        public TwoDShape()
        {
            Width = 0;
            Height = 0;
            Name = "null";
        }
        public TwoDShape(double w, double h, string n)
        {
            Width = w;
            Height = h;
            Name = n;
        }
        public TwoDShape(double x, string n)
        {
            Width = x;
            Height = x;
            Name = n;
        }
        public TwoDShape(TwoDShape ob)
        {
            Width = ob.Width;
            Height = ob.Height;
            Name = ob.Name;
        }
        public void ShowDim()
        {
            Console.WriteLine($"Ширина: {Width}, высота {Height}");
        }
        public virtual double Area()
        {
            Console.WriteLine($"Method Areaq() must be overridden");
            return 0;
        }
    }
}
