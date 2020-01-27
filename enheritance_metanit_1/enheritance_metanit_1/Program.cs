using System;

namespace enheritance_metanit_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Iiigor");
            person.Display();
            Employee employee = new Employee("Aaaliosha", "Google");
            employee.Display();
        }
    }
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public void Display()
        {
            Console.WriteLine(Name);
        }
    }
    class Employee : Person
    {
        public string Company { get; set;}
        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }
        public void Display()
        {
            Console.WriteLine(Name, Company);
        }
    }
}
