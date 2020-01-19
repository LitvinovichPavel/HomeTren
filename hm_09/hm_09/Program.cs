using System;

namespace hm_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting greeting = new Greeting();
            greeting.Hello();

            Passanger passanger = new Passanger();
            passanger.FullName();

            CheckIn checkIn = new CheckIn();
            checkIn.Ticket();
            checkIn.LuggageSuitCase();
            checkIn.LuggageHand();
            checkIn.GoToSecurity();

            SecurityCheck securityCheck = new SecurityCheck();
            securityCheck.HelloSecurityCheck();
            securityCheck.SearchClothes();
            securityCheck.SearchWeapons();
            securityCheck.SearchMetalDetector();
            securityCheck.GoToPassportControl();




        }
    }
}
