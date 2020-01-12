using System;

namespace Troelsen_enum
{
    enum EmpType //по умолчанию для хранения используется тип int
    {
        Manager,
        Grunt,
        Contractor,
        VicePresident
    }
    enum EmpTypeTwo : byte //используется тип byte
    {
        Manager = 10, //значение элементов в перечислении 10, 1, 88, 2000 и т.п.
        Grunt = 1,
        Contractor = 88,
        //VicePresident = 2000    ошибка т.к. 2000 выходит за диапазон типа byte
    }
    class Program
    {
        static void Main(string[] args)
        {
            EmpType emp = EmpType.VicePresident;
            AskForBonus(emp);
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
