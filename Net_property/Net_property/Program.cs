using System;

namespace Net_property
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Name = "Tom";
            person.Age = 30;

            Console.WriteLine($"FULL NAME: {person.FullName}");
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string FullName
        {
            get
            {
                return $"{Age}, {Name}";
            }
        }
    }
}
