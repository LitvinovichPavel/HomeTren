using System;
using System.Text;

namespace hm_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string strSymbol = "1a!2.3!!.. 4.!.?6 7! ..?";
            Task1(strSymbol);
        }

        static void Task1(string strSymbol)
        {
            string str1 = strSymbol;
            StringBuilder sb = new StringBuilder();



            Console.WriteLine(str1);
        }
    }
}
