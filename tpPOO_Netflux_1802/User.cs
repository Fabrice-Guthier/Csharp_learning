using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace tpPOO_Netflux_1802
{
	public class User
	{
		public string UserName { get; set; }
		public string Email { get; set; }
        public string Password { get; set; }
		public int Watchtime { get; set; }
        public Dictionary<TvShow, int> Episodes { get; set; }

        public User(string userName, string email, string password, int watchtime, Dictionary<TvShow, int> episodes)
		{
			UserName = userName;
            Email = email;
            Password = password;
            Watchtime = watchtime;
            Episodes = episodes;
        }

        public void Watch(Content content)
        {
            Watchtime += content.Duration;
            content.NumberOfViews++;
        }

        public void PrintWatchtime()
        {
            Console.WriteLine($"{UserName} a regardé {Watchtime} minutes de contenu");
        }
        public void PrintNumberOfViews(Content content)
        {
            Console.WriteLine($"{UserName} a regardé {content.Name} {content.NumberOfViews} fois");
        }
    }
}
