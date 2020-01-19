using System;
using System.Collections.Generic;
using System.Text;

namespace Troelsen_encapsulation_01
{
    class Check
    {
        public void MethodCheck()
        {
            Employee employee = new Employee();
            Console.WriteLine($"+++ {employee.Name}");
        }
    }
}
