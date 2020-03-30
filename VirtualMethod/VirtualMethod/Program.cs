using System;

namespace VirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Derived3 derived3 = new Derived3();

            Base baseRef;

            baseRef = derived3;
            baseRef.Who();
        }
    }
}
