using System;

namespace Troelsen_encapsulation_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.DisplayStatus();
            emp.Name = "VASILIY";
            Console.WriteLine(emp.Name);
            //emp.SetName("VASILIY");
            //Console.WriteLine($"NAME: {emp.GetName()}");
            Check check = new Check();
            check.MethodCheck();
        }
    }
}