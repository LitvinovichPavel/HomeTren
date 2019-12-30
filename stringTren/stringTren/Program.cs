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

            Console.WriteLine();

            string strNull = null;
            Console.WriteLine(strNull == null); //true
            Console.WriteLine(strNull == ""); //false

            Console.WriteLine(string.IsNullOrEmpty(strNull)); //true, (равна ли строка null)

            string str2 = "ABCD";
            char letter = str2[2]; //letter =='C'
            Console.WriteLine(letter);

            foreach (char item in "12345")
            {
                Console.Write(item + ", "); //1, 2, 3, 4, 5,
            }
            Console.WriteLine("\n");

            string stringForArray = "this red had";
            string[] arrayStr = stringForArray.Split();
            foreach (var item in arrayStr)
            {
                Console.Write(item + "|"); //this|red|had
            }
            Console.WriteLine();

            string str4 = string.Concat("this ", "red ", "had");
            Console.WriteLine(str4); //this red had

            string str5 = "Температура в городе {0} будет {1} градуса {2} числа";
            string s = string.Format(str5, "Минск", 2, DateTime.Now.Day);
            Console.WriteLine(s);
        }
    }
}
