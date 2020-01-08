using System;

namespace Troelsen_static_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount s1 = new SavingAccount(50);

            Console.WriteLine($"Interest Rate is: {SavingAccount.GetInterestRate()}");
            SavingAccount.SetInterestRate(0.08);

            SavingAccount s2 = new SavingAccount(100);
            Console.WriteLine($"Interest Rate is: {SavingAccount.GetInterestRate()}");
        }
        class SavingAccount
        {
            public double currBalance;
            public static double currInterestRate;
            public SavingAccount(double balance)   //конструктор
            {
                currBalance = balance;
            }
            static SavingAccount()         //конструктор
            {
                Console.WriteLine($"In static ctor!");
                currInterestRate = 0.04;
            }
            public static void SetInterestRate(double newRate)
            {
                currInterestRate = newRate;
            }
            public static double GetInterestRate()
            {
                return currInterestRate;
            }
        }
    }
}
