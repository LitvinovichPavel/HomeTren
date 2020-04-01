using System;
using System.Collections.Generic;
using System.Text;

namespace _Interface
{
    class Hexagon : Shape, IPointy
    {
        public Hexagon()
        {
        }
        public Hexagon(string name) : base(name)
        {
        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the Hexagon");
        }
        public byte Points
        {
            get { return 6; }
        }
    }
}
