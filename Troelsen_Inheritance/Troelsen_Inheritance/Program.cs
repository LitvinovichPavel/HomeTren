using System;

namespace Troelsen_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //SalesPerson fred = new SalesPerson();
            //fred.Age = 31;
            //fred.Name = "Fred";
            //fred.SalesNumber = 50;

            Manager chucky = new Manager("Chucky", 50, 92, 100_000, "333-33-3333", 9_000);
        }
    }
}
