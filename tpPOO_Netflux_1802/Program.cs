using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace tpPOO_Netflux_1802
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Episode tvShow1Episode1 = new Episode("Arcane S01E01", 60, Genre.Animation, 0);
            Episode tvShow1Episode2 = new Episode("Arcane S01E02", 60, Genre.Animation, 0);
            Episode tvShow1Episode3 = new Episode("Arcane S01E03", 60, Genre.Animation, 0);
            Episode tvShow1Episode4 = new Episode("Arcane S01E04", 60, Genre.Animation, 0);
            Episode tvShow1Episode5 = new Episode("Arcane S01E05", 60, Genre.Animation, 0);
            Episode tvShow1Episode6 = new Episode("Arcane S01E06", 60, Genre.Animation, 0);
            Episode tvShow1Episode7 = new Episode("Arcane S01E07", 60, Genre.Animation, 0);
            Episode tvShow1Episode8 = new Episode("Arcane S01E08", 60, Genre.Animation, 0);

            List<Episode> episodes = new List<Episode> { tvShow1Episode1, tvShow1Episode2, tvShow1Episode3,
            tvShow1Episode4, tvShow1Episode5, tvShow1Episode6, tvShow1Episode7, tvShow1Episode8};
            TvShow tvShow1 = new TvShow("Arcane", episodes);
            
            Episode tvShow2Episode1 = new Episode("The Witcher S01E01", 60, Genre.Fantasy, 0);
            Episode tvShow2Episode2 = new Episode("The Witcher S01E02", 60, Genre.Fantasy, 0);
            Episode tvShow2Episode3 = new Episode("The Witcher S01E03", 60, Genre.Fantasy, 0);
            Episode tvShow2Episode4 = new Episode("The Witcher S01E04", 60, Genre.Fantasy, 0);
            Episode tvShow2Episode5 = new Episode("The Witcher S01E05", 60, Genre.Fantasy, 0);
            Episode tvShow2Episode6 = new Episode("The Witcher S01E06", 60, Genre.Fantasy, 0);
            Episode tvShow2Episode7 = new Episode("The Witcher S01E07", 60, Genre.Fantasy, 0);
            Episode tvShow2Episode8 = new Episode("The Witcher S01E08", 60, Genre.Fantasy, 0);

            List<Episode> episodes2 = new List<Episode> { tvShow2Episode1, tvShow2Episode2, tvShow2Episode3,
            tvShow2Episode4, tvShow2Episode5, tvShow2Episode6, tvShow2Episode7, tvShow2Episode8};
            TvShow tvShow2 = new TvShow("The Witcher", episodes);

            Dictionary<TvShow, int> tvShows = new Dictionary<TvShow, int>();
            tvShows.Add(tvShow1, 4);
            tvShows.Add(tvShow2, 3);


            User user1 = new User("Fab", "fabrice.guthier@gmail.com", "1234", 0, tvShows);
            Content content1 = new Movie("The Witcher", 60, Genre.Fantasy, 0, "Lauren Schmidt Hissrich");
            Content content2 = new Movie("Berserk", 70, Genre.Animation, 0, "Kentaro Miura");
            Content content3 = new Movie("Squid Game", 45, Genre.Thriller, 0, "Korea Man");


            user1.Watch(content1);
            user1.Watch(content2);
            user1.Watch(content3);
            user1.PrintWatchtime();
            Console.WriteLine();
            user1.PrintNumberOfViews(content1);
            user1.PrintNumberOfViews(content2);
            user1.PrintNumberOfViews(content3);
            Console.WriteLine();
            tvShow1.Selected(user1);
            tvShow2.Selected(user1);
            Console.WriteLine();
            user1.PrintWatchtime();
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}