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
            /*
            Menu menu = new Menu();
            menu.Makis = new Maki[4];

            menu.Makis[0] = new Maki()
            {
                Title = "Avokado maki",
                Mass = 110,
                Price = 5.2
            };
            menu.Makis[1] = new Maki()
            {
                Title = "Arizona maki",
                Mass = 120,
                Price = 4.8
            };
            menu.Makis[2] = new Maki()
            {
                Title = "Karada maki",
                Mass = 130,
                Price = 3.8
            };
            menu.Makis[3] = new Maki()
            {
                Title = "Nara maki",
                Mass = 140,
                Price = 7.2
            };*/

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            /*
            // сохранение данных
            using (FileStream fs = new FileStream("menuMaki.json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<Menu>(fs, menu, options);
            }*/

            // чтение данных
            using (FileStream fs = new FileStream("menuMaki.json", FileMode.OpenOrCreate))
            {
                Menu restoredMenu = await JsonSerializer.DeserializeAsync<Menu>(fs, options);
                Console.WriteLine($"MENU: {restoredMenu.Makis[0].Title}, {restoredMenu.Makis[0].Mass}gr, PRICE: {restoredMenu.Makis[0].Price}");
                Console.WriteLine($"MENU: {restoredMenu.Makis[1].Title}, {restoredMenu.Makis[1].Mass}gr, PRICE: {restoredMenu.Makis[1].Price}");
                Console.WriteLine($"MENU: {restoredMenu.Makis[2].Title}, {restoredMenu.Makis[2].Mass}gr, PRICE: {restoredMenu.Makis[2].Price}");
                Console.WriteLine($"MENU: {restoredMenu.Makis[3].Title}, {restoredMenu.Makis[3].Mass}gr, PRICE: {restoredMenu.Makis[3].Price}");
            }
        }
    }

    class Menu
    {
        public Maki[] Makis { get; set; }
    }
    class Maki
    {
        public string Title { get; set; }//name
        public double Mass { get; set; }//age
        public double Price { get; set; }

    }
}
