using System;

namespace Troelsen_encapsulation_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("TOOOM", 2414, 30, 30000);
            emp.DisplayStatus();

            emp.Name = "AAA4XI";
            emp.ID = 9379992;
            emp.Age = 31;
            emp.Pay = 33333;
            emp.DisplayStatus();
        }
    }
}
