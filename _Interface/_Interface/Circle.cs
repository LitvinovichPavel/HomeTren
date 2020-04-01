﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _Interface
{
    class Circle : Shape
    {
        public Circle()
        {
        }
        public Circle(string name) : base(name)
        {
        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the Circle");
        }
    }
}
