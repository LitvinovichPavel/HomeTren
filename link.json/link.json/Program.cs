using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace _link._json
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassClass classClass = new ClassClass();
            classClass.AAAAAAA();
        }
    }
    class ClassClass
    {
        public void Method()
        {
            Console.WriteLine("___");
        }
        public void AAAAAAA()
        {
            for (int i = 0; i < 100000000; i++)
            {
                Console.WriteLine(i);
                Method();
            }
        }
    }
}
