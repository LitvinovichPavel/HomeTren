using System;

namespace Troelsen_autom_property
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.PetName = "Frank";
            c.Speed = 55;
            c.Color = "Red";
            c.DisplayStatus();

            Garage g = new Garage();
            g.MyAuto = c;
            Console.WriteLine($"{g.NumerOfCars}, {g.MyAuto.PetName}");
        }
    }
    class Car
    {
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }
        public void DisplayStatus()
        {
            Console.WriteLine($"{PetName}, {Speed}, {Color}");
        }
    }
    class Garage
    {
        public int NumerOfCars { get; set; }
        public Car MyAuto { get; set;  }
        public Garage()
        {
            MyAuto = new Car();
            NumerOfCars = 1;
        }
        public Garage(Car car, int number)
        {
            MyAuto = car;
            NumerOfCars = number;
        }
    }
}
