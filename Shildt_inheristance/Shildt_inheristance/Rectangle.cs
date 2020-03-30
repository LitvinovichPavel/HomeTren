using System;
using System.Collections.Generic;
using System.Text;

namespace Shildt_inheristance
{
    class Rectangle : TwoDShape
    {
        public Rectangle(double w, double h) : base(w, h, "прямоугольник")
        { 
        }
        public Rectangle(double x) : base(x, "прямоугольник")
        { 
        }
        public Rectangle(Rectangle ob) : base(ob)
        {
        }
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
        public override double Area()
        {
            return Width * Height;
        }
    }
}
