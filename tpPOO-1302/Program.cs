using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace tpPOO_1302
{
    public class Program
    {
        static void Main(string[] args)
        {
            Database.DisplayBooks();
            Console.WriteLine();
            Book book1 = new Book("Dune", "Frank Herbert", BookGenre.scifi);
            Book book2 = new Book("Berserk", "Kentaro Miura", BookGenre.manga);

            book1.AddBookInDatabase();
            book2.AddBookInDatabase();

            Database.DisplayBooks();

            Console.ReadLine();
        }
    }
}