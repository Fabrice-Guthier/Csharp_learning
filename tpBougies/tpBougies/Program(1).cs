using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpBougies
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Kata bougies
            //Imaginons des bougies.
            //Si on en a 3, on peut en utiliser 3.
            //Mais à partir de la cire de 3 bougies, on peut fabriquer une 4ème bougie.
            //Si maintenant on commence avec 9 bougies, on pourra en fabriquer 3 et avoir 12 bougies...
            //Trouver l'algorithme correspondant.


            // premiere tentative avec boucles if/for

            //Console.WriteLine("Saisissez une quantité de bougies : ");
            //string inputQuantity = Console.ReadLine();
            //int candleQuantity = int.Parse(inputQuantity);
            //int candleRest = 0;
            //int newCandleQuantity = candleQuantity;

            //for (int i = 0; i <= (candleQuantity + candleQuantity / 3 - 1); i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        candleRest++;
            //        newCandleQuantity = candleQuantity + candleRest;
            //    }
            //}

            //Console.WriteLine("On peut avoir un total de " + newCandleQuantity);
            //Console.ReadLine();


            // deuxieme tentative avec boucle while

            Console.WriteLine("Saisissez une quantité de bougies allumées, leur cire va créer plus de bougies : ");
            int candleQuantity = int.Parse(Console.ReadLine());

            int totalCandlesUsed = 0;
            int candleRest = 0;

            while (candleQuantity > 0)
            {
                totalCandlesUsed += candleQuantity;
                candleRest += candleQuantity;

                candleQuantity = candleRest / 3;
                candleRest = candleRest % 3;
            }

            Console.WriteLine("On peut avoir un total de " + totalCandlesUsed + " bougies allumées.");
            Console.ReadLine();
        }
    }
}
