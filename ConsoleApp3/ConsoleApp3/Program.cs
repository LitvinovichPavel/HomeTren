using System;
using System.Text.RegularExpressions;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class MyClass
    {
        public int Method()
        {
            int num1;
            int num2;
            try
            {
                num1 = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());
                //return num1 + num2;
            }
            catch
            {

            }
            finally
            {
               
            }
            return num1 + num2;
        }
    }
}
