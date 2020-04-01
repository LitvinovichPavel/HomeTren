using System;
using System.Collections;

namespace _Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    myCar.Accelerate(10);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Help link: {e.HelpLink}");

                foreach  (DictionaryEntry de in e.Data)
                {
                    Console.WriteLine($"{de.Key}, {de.Value}");
                }
            }
        }
    }
}
