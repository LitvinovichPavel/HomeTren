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
            allBook.Books = new Book[3];//в json находится по названием Books

            allBook.Books[0] = new Book()
            {
                Author = "Rihter",
                Title = "CLR via C#",
                Price = 100
            };
            allBook.Books[1] = new Book()
            {
                Author = "Albahari",
                Title = ".NET Core",
                Price = 110
            };
            allBook.Books[2] = new Book()
            {
                Author = "Troelsen",
                Title = "C# 7.0",
                Price = 120
            };

            DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(AllBook));

            using (FileStream fs = new FileStream("C:/D/Projects/111.json", FileMode.OpenOrCreate))
            {
                formatter.WriteObject(fs, allBook);
            }

            using (FileStream fs = new FileStream("C:/D/Projects/111.json", FileMode.OpenOrCreate))
            {
                AllBook book2 = (AllBook)formatter.ReadObject(fs);
            }
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