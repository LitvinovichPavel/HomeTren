using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Json._3
{
    class Program
    {
        static async Task Main(string[] args)
        {
            
            AllMenu menu = new AllMenu();

            menu.Beverages = new Beverage[3];
            menu.Beverages[0] = new Beverage()
            {
                Title = "Fanta",
                Mass = 0.5,
                Price = 2.0
            };
            menu.Beverages[1] = new Beverage()
            {
                Title = "Coca-Cola",
                Mass = 0.5,
                Price = 2.0
            };
            menu.Beverages[2] = new Beverage()
            {
                Title = "Water",
                Mass = 0.5,
                Price = 0.5
            };

            menu.Makis = new Maki[4];
            menu.Makis[0] = new Maki()
            {
                Title = "Авокадо маки",
                Mass = 100,
                Price = 5.6
            };
            menu.Makis[1] = new Maki()
            {
                Title = "Аризона маки",
                Mass = 100,
                Price = 6.2
            };
            menu.Makis[2] = new Maki()
            {
                Title = "Карада маки",
                Mass = 100,
                Price = 5.1
            };
            menu.Makis[3] = new Maki()
            {
                Title = "Нара маки",
                Mass = 100,
                Price = 8.7
            };

            menu.Sets = new Set[4];
            menu.Sets[0] = new Set()
            {
                Title = "Сет №1",
                Mass = 410,
                Price = 32.0
            };
            menu.Sets[1] = new Set()
            {
                Title = "Сет №2",
                Mass = 430,
                Price = 35.2
            };
            menu.Sets[2] = new Set()
            {
                Title = "Сет №3",
                Mass = 420,
                Price = 37.1
            };
            menu.Sets[3] = new Set()
            {
                Title = "Большой сет",
                Mass = 1000,
                Price = 55.7
            };

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            // сохранение данных
            using (FileStream fs = new FileStream("menuJson.json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<AllMenu>(fs, menu, options);
            }
            // чтение данных
            using (FileStream fs = new FileStream("menuJson.json", FileMode.OpenOrCreate))
            {
                AllMenu restoredMenu = await JsonSerializer.DeserializeAsync<AllMenu>(fs, options);
                Console.WriteLine($"НАПИТКИ: {restoredMenu.Beverages[0].Title}, {restoredMenu.Beverages[0].Mass}, {restoredMenu.Beverages[0].Price}");
            }
        }
    }
    class AllMenu
    {
        public Beverage[] Beverages { get; set; }
        public Maki[] Makis { get; set; }
        public Set[] Sets { get; set; }
    }
    class Beverage
    {
        public string Title { get; set; }
        public double Mass { get; set; }
        public double Price { get; set; }
    }
    class Maki
    {
        public string Title { get; set; }
        public double Mass { get; set; }
        public double Price { get; set; }
    }
    class Set
    {
        public string Title { get; set; }
        public double Mass { get; set; }
        public double Price { get; set; }
    }
}