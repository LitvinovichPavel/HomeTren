using System;
using System.Collections.Generic;
using System.Text;

namespace tren_lecture_12
{
    class Employee
    {
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public void MethodAge()
        {
            Employee employee = new Employee();
            employee.Age = 11;

            Console.WriteLine("1.  " + employee.Age);
            Console.WriteLine("1.1 " + employee.age);
        }
        public void Info()
        {
            Employee employee = new Employee();
            Console.WriteLine("2.  " + employee.Age);
        }
    }
}
