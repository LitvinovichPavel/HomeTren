using System;
using System.Threading;

namespace Timer_net
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            // устанавливаем метод обратного вызова
            TimerCallback tm = new TimerCallback(Count);
            // создаем таймер
            Timer timer = new Timer(tm, num, 0, 2000);

            Console.ReadLine();
        }
        public static void Count(object obj)
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
