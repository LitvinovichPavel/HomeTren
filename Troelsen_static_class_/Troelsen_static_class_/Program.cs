using System;

namespace Troelsen_static_class
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeUtilClass.PrintDate();
            TimeUtilClass.PrintTime();

            //TimeUtilClass u = new TimeUtilClass();   нельзя создать экземпляр статического класса
        }
    }
    static class TimeUtilClass
    {
        public static void PrintTime()
        {
            Console.WriteLine(DateTime.Today.ToShortTimeString());
        }
        public static void PrintDate()
        {
            Console.WriteLine(DateTime.Today.ToShortDateString());
        }
    }
}

