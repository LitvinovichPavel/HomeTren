using System;
using System.Text;

namespace lecture_08
{
    class Program
    {
        static void Main(string[] args)
        {
            string str2 = "AAA.";
            StringBuilder sb = new StringBuilder();
            sb.Append(str2).Append(str2).Append(str2).Append(str2).Append(str2);
            Console.WriteLine(sb);
            sb.Clear();
            Console.WriteLine("Clear" + sb);
        }
    }
}
