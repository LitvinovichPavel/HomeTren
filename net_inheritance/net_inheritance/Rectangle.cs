using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Inheritance
{
    class Rectangle : TwoDShape
    {
        public bool IsSquare()
        {
            if (Width == Height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double Area()
        {
            return Width * Height;
        }
    }
}
