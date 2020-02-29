using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonMetanit.Write.Read
{
    class Program
    {
        static void Main(string[] args)
        {
            Executive.MethodBook();
        }
    }
    public class Executive
    {
        public static void MethodBook()
        {
            var allBook = new AllBook();
            DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(AllBook));

            int priceRihter, priceAlbahari, priceTroelsen;

            using (FileStream fs = new FileStream("C:/D/Projects/111.json", FileMode.OpenOrCreate))
            {
                AllBook book2 = (AllBook)formatter.ReadObject(fs);
                priceRihter = book2.Books[0].Price;
                priceAlbahari = book2.Books[1].Price;
                priceTroelsen = book2.Books[2].Price;
            }
            Console.WriteLine($"PRICE RIHTER: {priceRihter}");
        }
    }
    public class AllBook
    {
        public Book[] Books { get; set; }
    }
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
    }
}