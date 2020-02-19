using System;
using System.Text.Json;

namespace JsonMetanit
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person { Name = "Tom", Age = 35, Car = "Toyota", NumberCar = 8226 };

            string json = JsonSerializer.Serialize<Person>(tom);
            Console.WriteLine(json);

            Person restoredPerson = JsonSerializer.Deserialize<Person>(json);
            Console.WriteLine(restoredPerson.Car);

            //Здесь вначале сериализуем с помощью метода JsonSerializer.Serialize() объект типа Person 
            //в стоку с кодом json. Затем обратно получаем из этой строки объект Person посредством 
            //метода JsonSerializer.Deserialize().
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Car { get; set; }
        public int NumberCar { get; set; }
    }
}
