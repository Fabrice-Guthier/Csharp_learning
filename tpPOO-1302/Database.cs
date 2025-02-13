using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace tpPOO_1302
{
    public class Database
    {
        static List<Book> books = new List<Book>();

        static Database()
        {
            books.Add(new Book("Harry Potter", "J.K. Rowling", BookGenre.youth));
            books.Add(new Book("Le Seigneur des Anneaux", "J.R.R. Tolkien", BookGenre.fantasy));
            books.Add(new Book("Le Petit Prince", "Antoine de Saint-Exupéry", BookGenre.novel));
            books.Add(new Book("1984", "George Orwell", BookGenre.scifi));
            books.Add(new Book("Le Rouge et le Noir", "Stendhal", BookGenre.thriller));
        }

        public static void DisplayBooks()
        {
            Console.WriteLine("Voici la liste des livres de la bibliothèque : ");
            foreach (var book in books)
            {
                Console.WriteLine(book.Title + " de " + book.Author + " , dont le genre est : " + book.Genre);
            }
        }

        public static void AddBook(Book book)
        {
            books.Add(book);
        }   
    }
}
