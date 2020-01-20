using System;
using System.Collections.Generic;
using System.Text;

namespace Troelsen_encapsulation_02
{
    class Employee
    {
        private string empName;
        private int empID;
        private int empAge;
        private float cuppPay;
        public Employee()
        {
        }
        public Employee(string name, int id, float pay) : this (name, 0, id, pay) { }
        public Employee(string name, int id, int age, float pay)
        {
            Name = name;
            ID = id;
            Age = age;
            Pay = pay;
        }
        public string Name
        {
            get => empName;
            set => empName = value;
        }
        public int ID
        {
            get => empID;
            set => empID = value;
        }
        public int Age
        {
            get => empAge;
            set => empAge = value;
        }
        public float Pay
        {
            get => cuppPay;
            set => cuppPay = value;
        }
        public void GiveBonus(float amount)
        {
            Pay += amount;
        }
        public void DisplayStatus()
        {
            Console.WriteLine($"NAME: {empName}");
            Console.WriteLine($"ID: {empID}");
            Console.WriteLine($"AGE: {empAge}");
            Console.WriteLine($"PAY: {cuppPay}");
        }
    }
}
