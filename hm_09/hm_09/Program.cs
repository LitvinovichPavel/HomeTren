using System;

namespace hm_09
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckIn checkIn = new CheckIn();

            //checkIn.Greeting();

            Passanger passanger = new Passanger();
            passanger.FullName();

            //checkIn.Passport();

            checkIn.Luggage();
        }
    }
}
