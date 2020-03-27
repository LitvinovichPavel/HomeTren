using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Inheritance
{
    class TwoDShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public void ShowDim()
        {
            Console.WriteLine($"WIDTH: {Width}, HEIGHT: {Height}");
        }
    }
}
