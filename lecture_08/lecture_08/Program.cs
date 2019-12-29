using System;
using System.Text;

namespace lecture_08
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "AAA.";

            Motorcycle motorcycle = new Motorcycle();

            StrBild(firstString);
        }
        static void StrBild(string firstString)
        {
            string str2;
            str2 = firstString;
            StringBuilder sb = new StringBuilder();
            sb.Append(str2).Append(str2).Append(str2).Append(str2).Append(str2); //склеивает
            Console.WriteLine(sb);
            sb.Clear();
            Console.WriteLine("Clear" + sb);
        }
    }
}
