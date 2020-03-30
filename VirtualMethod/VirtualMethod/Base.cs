using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualMethod
{
    class Base
    {
        public virtual void Who()
        {
            Console.WriteLine($"Method Who() in class Base");
        }
    }
}
