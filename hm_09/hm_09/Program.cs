using System;

namespace hm_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Passanger fullName = new Passanger();
            fullName.FullName();
            string peopleName;
            peopleName = fullName.Surname;
            Console.WriteLine("фамилия: " + peopleName);
        }
    }
}
