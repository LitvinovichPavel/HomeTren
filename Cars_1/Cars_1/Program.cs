using System;

namespace Cars_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SUV toyotaRav4 = new SUV("RAV4", 2.4);
            toyotaRav4.Toyota();

            SUV audiQ5 = new SUV("Q5", 2.0);
            audiQ5.Aydi();

            SUV audiQ7 = new SUV("Q7", 3.0);
            audiQ7.Aydi();

            Sport ferrariF12 = new Sport("Ferrari", "F12", 6.3);
            ferrariF12.Info();
        }
    }
}
