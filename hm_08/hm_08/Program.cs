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
            Console.WriteLine(str1);
            StringBuilder sb = new StringBuilder();
            int indexTurn = str1.IndexOf("?"); //определяем положение вопросительного знака (?) в строке

            for (int i = 0; i < indexTurn; i++)
            {
                if (str1[i] == '!')
                {
                    str1 = str1.Replace("!", string.Empty);
                }
            }

            Console.WriteLine("str1:\n" + str1);
            Console.WriteLine();


        }
    }
}
