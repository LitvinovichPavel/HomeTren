using System;
using System.Collections.Generic;

namespace _List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> man = new List<Employee>() { };
            man.Add(new Employee(3000, 2));
            man.Add(new Employee(5000, 6));

            foreach (var item in man)
            {
                Console.WriteLine($"Year: {item.Year}, salary {item.Salary}");
            }
        }
    }
    class Employee
    {
        public int Salary { get; set; }
        public int Year { get; set; }
        public Employee(int salary, int year)
        {
            Salary = salary;
            Year = year;
        }
    }
}
