using System;
using System.Collections.Generic;
using System.Text;

namespace Troelsen_Inheritance
{
    partial class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public double Pay { get; set; }
        public int Age { get; set; }
        public string SSN { get; set; }
        public Employee (string name, int age, int id, double pay, string ssn) : this(name, age, id, pay)
        {
            SSN = ssn;
        }
        public void GiveBonus (double amount)
        {
            Pay += amount;
        }
        public void DisplayStats()
        {
            Console.WriteLine($"{Name}, {ID}, {Pay}");
        }
    }
}
