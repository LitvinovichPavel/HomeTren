using System;

namespace Troelsen_encapsulation_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("YASIA", 317857, 3000);
            emp.DisplayStatus();
            emp.SetName("IIGOR");
            Console.WriteLine($"NAME: {emp.GetName()}");
        }
    }
}
