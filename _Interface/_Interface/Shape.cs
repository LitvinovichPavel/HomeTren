using System;
using System.Collections.Generic;
using System.Text;

namespace _Interface
{
    class Shape
    {
        public string name;
        public string PetName { get; set; }
        public Shape()
        {
        }
        public Shape(string n)
        {
            name = n;
        }
        public virtual void Draw()
        {
            Console.WriteLine($"");
        }
    }
}
