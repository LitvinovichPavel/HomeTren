using System;

namespace Troelsen_Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuples_ tuples_ = new Tuples_();
            tuples_.MethodTuples();
        }
    }
    class Tuples_
    {
        public void MethodTuples()
        {
            (string, int, string) value = ("A", 21, "C");
            var value2 = (ax: "ab", dax: 121, bex: "cd");
            Console.WriteLine(value.Item1);
            Console.WriteLine(value.Item2);
            Console.WriteLine(value.Item3);

            Console.WriteLine(value2.ax);
            Console.WriteLine(value2.dax);
            Console.WriteLine(value2.bex);
        }
    }
}
