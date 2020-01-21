using System;

namespace tren_lecture_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.MethodAge();
            employee.Info();
            employee.Age = 22;
            Console.WriteLine("3.  " + employee.Age);
        }
    }
}