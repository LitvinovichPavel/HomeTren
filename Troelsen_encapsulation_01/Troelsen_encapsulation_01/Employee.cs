using System;
using System.Collections.Generic;
using System.Text;

namespace Troelsen_encapsulation_01
{
    class Employee
    {
        private string empName;
        private int empID;
        private float cuppPay;
        public Employee()
        {
        }
        public Employee(string name, int id, float pay)
        {
            empName = name;
            empID = id;
            cuppPay = pay;
        }
        public void GiveBonus(float amount)
        {
            cuppPay += amount;
        }
        public void DisplayStatus()
        {
            Console.WriteLine($"NAME: {empName}");
            Console.WriteLine($"ID: {empID}");
            Console.WriteLine($"PAY: {cuppPay}");
        }
    }
}
