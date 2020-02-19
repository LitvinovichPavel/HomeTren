using System;
using Newtonsoft.Json;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonData
{
    class Program
    {
        static void Main(string[] args)
        {
            //var person = File.Exists("person4.json") ? JsonConvert.DeserializeObject<Person>(File.ReadAllText("persont4.json")) : new Person
            //{
            //    Name = "4Iha",
            //    Age = 30
            //};
            var person2 = File.Exists("person6.json") ? JsonConvert.DeserializeObject<Person>(File.ReadAllText("persont6.json")) : new Person
            {
                Name = "5Iha",
                Age = 55,
                Str = "qqqqqqqqqqq"
            };

            File.WriteAllText("person6.json", JsonConvert.SerializeObject(person2));

        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Str { get; set; }
    }
}
