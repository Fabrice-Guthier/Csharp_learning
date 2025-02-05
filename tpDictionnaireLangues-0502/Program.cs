using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpDictionnaireLangues_0502
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionnaire français-anglais
            Dictionary<string, string> francaisAnglais = new Dictionary<string, string>();
            francaisAnglais.Add("bonjour", "hello");
            francaisAnglais.Add("maison", "house");
            francaisAnglais.Add("livre", "book");

            Console.WriteLine("Veuillez saisir un des mots suivants : bonjour, maison, livre.");
            string motFrancais = Console.ReadLine();
            string motAnglais = francaisAnglais[motFrancais];
            Console.WriteLine($"{motFrancais} en anglais est : {motAnglais}");

            // Dictionnaire anglais-français (pour l'exemple)
            Dictionary<string, string> anglaisFrancais = new Dictionary<string, string>();
            anglaisFrancais.Add("hello", "bonjour");
            anglaisFrancais.Add("house", "maison");
            anglaisFrancais.Add("book", "livre");

            Console.WriteLine("Veuillez saisir un des mots suivants : hello, house, book.");
            string motAnglais2 = Console.ReadLine();
            string motFrancais2 = anglaisFrancais[motAnglais2];
            Console.WriteLine($"{motAnglais2} en français est : {motFrancais2}");

            Console.ReadLine();
        }
    }
}
