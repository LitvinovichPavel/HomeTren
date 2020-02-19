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
            Menu menu = new Menu();
            menu.Makis = new Maki[4];

            menu.Makis[0] = new Maki()
            {
                Title = "Avokado maki",
                Mass = 100,
                Price = 5.2
            };
            menu.Makis[1] = new Maki()
            {
                Title = "Arizona maki",
                Mass = 100,
                Price = 4.8
            };
            menu.Makis[2] = new Maki()
            {
                Title = "Karada maki",
                Mass = 100,
                Price = 3.8
            };
            menu.Makis[3] = new Maki()
            {
                Title = "Nara maki",
                Mass = 100,
                Price = 7.2
            };

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            // сохранение данных
            using (FileStream fs = new FileStream("menuMaki.json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<Menu>(fs, menu, options);
            }

            // чтение данных
            using (FileStream fs = new FileStream("menuMaki.json", FileMode.OpenOrCreate))
            {
                Menu restoredMenu = await JsonSerializer.DeserializeAsync<Menu>(fs, options);
                Console.WriteLine($"MENU: {restoredMenu.Makis[0].Title}");
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
