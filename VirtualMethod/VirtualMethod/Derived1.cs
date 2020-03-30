using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualMethod
{
    class Derived1 : Base
    {
        public override void Who()
        {
            Console.WriteLine($"Method Who() in class Derived1");
        }
    }
}
