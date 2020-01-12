using System;

namespace lecture_09._01._20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddWrapper(3, 7));
        }
        static int AddWrapper(int x, int y)
        {
            return Add();
            int Add()
            {
                return x + y;
            }
        }
    }
}
