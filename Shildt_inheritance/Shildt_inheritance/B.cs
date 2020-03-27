using System;
using System.Collections.Generic;
using System.Text;

namespace Shildt_inheritance
{
    class B
    {
        protected int i, j;
        public void Set(int a, int b)
        {
            i = a; //2
            j = b; //3
        }
        public void Show()
        {
            Console.WriteLine($"{i}   {j}");
        }
    }
}
