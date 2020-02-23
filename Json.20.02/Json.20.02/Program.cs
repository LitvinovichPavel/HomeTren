using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Json._20._02
{
    class Program
    {
        static void Main(string[] args)
        {
            AllBook allBook = new AllBook();
            allBook.Books = new Book[4];

            allBook.Books[0] = new Book()
            {
                Name = "1",
                Author = "1",
                Price = 1
            };
            allBook.Books[1] = new Book()
            {
                Name = "2",
                Author = "2",
                Price = 2
            };
            allBook.Books[2] = new Book()
            {
                Name = "3",
                Author = "3",
                Price = 3
            };
            allBook.Books[3] = new Book()
            {
                Name = "4",
                Author = "4",
                Price = 4
            };

            DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(Book));

            using (FileStream fs = new FileStream("C:/D/Projects/menu.json", FileMode.OpenOrCreate))
            {
                formatter.WriteObject(fs, allBook);
            }

            using (FileStream fs = new FileStream("C:/D/Projects/menu.json", FileMode.OpenOrCreate))
            {
                Book book2 = (Book)formatter.ReadObject(fs);
            }
        }
    }
    public class AllBook
    {
        public Book[] Books { get; set; }
    }
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
    }
}
