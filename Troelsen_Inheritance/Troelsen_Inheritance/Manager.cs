using System;
using System.Collections.Generic;
using System.Text;

namespace Troelsen_Inheritance
{
    class Manager : Employee
    {
        public int StockOptions { get; set; }
        public Manager(string name, int age, int id, 
                       double pay, string ssn, int stockOptions)
        {
            StockOptions = stockOptions;
            ID = id;
            Age = age;
            Name = name;
            Pay = pay;
            SSN = ssn;
        }
    }
}
