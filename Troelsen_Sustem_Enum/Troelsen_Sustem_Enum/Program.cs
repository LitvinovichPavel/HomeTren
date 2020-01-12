using System;

namespace Troelsen_System_Enum
{
    enum EmpType
    {
        Manager = 0,
        Grunt = 1,
        Contractor = 2,
        VicePresident = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            EmpType emp = EmpType.Contractor;
            AskForBonus(emp);
            Console.WriteLine($"Type: {Enum.GetUnderlyingType(emp.GetType())}"); //возвращает тип данных, 
                                                                                 //используемых для хранения 
                                                                                 //(для int это - System.Int32)
            Console.WriteLine($"EmpType: {Enum.GetUnderlyingType(typeof(EmpType))}"); //System.Int32
            Console.WriteLine(emp.ToString()); //Contractor
            Console.WriteLine((int)emp); //2

        }
        static void AskForBonus (EmpType e)
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("Bla manager");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("Bla Grunt");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("Bla Contractor");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("Bla Vice President");
                    break;
            }
        }
    }
}
