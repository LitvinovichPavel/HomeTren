using System;

namespace methodTren
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sport");
            CarSport lexus = new CarSport("Lexus", "RC F", 270, 2250, 5.0);
            lexus.Info();

            CarSport porsche = new CarSport("Porsche", "911 Turbo S", 330, 1990, 3.8);
            porsche.Info();

            CarSport ferrari = new CarSport("Ferrari", "F12 berlinetta", 340, 1525, 6.3);
            ferrari.Info();

            Console.WriteLine("PASSENGER");
            CarPassenger mercedes = new CarPassenger("Mercedes", "S600", 250, 2740, 6.0);
            mercedes.Info();

            CarPassenger bentley = new CarPassenger("Bentley", "Mulsanne", 296, 3090, 6.75);
            bentley.Info();

            CarPassenger rr = new CarPassenger("RR", "Ghost", 250, 3000, 6.6);
            rr.Info();

            Console.WriteLine("SUV");
            CarSUV toyota = new CarSUV("Toyota", "Sequoia", 170, 4536, 5.7);
            toyota.Info();

            CarSUV cadillac = new CarSUV("Cadillac", "Escalade", 180, 3311, 6.2);
            cadillac.Info();

            CarSUV chevrolet = new CarSUV("Chevrolet", "Tahoe", 180, 3311, 6.2);
            chevrolet.Info();
        }
    }
}