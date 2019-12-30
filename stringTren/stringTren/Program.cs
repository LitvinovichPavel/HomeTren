using System;

namespace stringTren
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('*', 10));

            char[] ch = "Hello".ToCharArray();
            string str = new string(ch); //конструируем строку из массива
            Console.WriteLine(str);

            //строки null и пустые строки
            string str1 = "";
            Console.WriteLine(str1 == ""); //true
            Console.WriteLine(str1 == string.Empty); //true
            Console.WriteLine(str1.Length == 0); //true
        }
    }
}
