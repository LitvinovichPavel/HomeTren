using System;
using System.Collections.Generic;
using System.Text;

namespace _Exceptions
{
    class Radio
    {
        public void TurnOn(bool on)
        {
            Console.WriteLine(on ? "Jamming..." : "Quiet time...");
        }
    }
}
