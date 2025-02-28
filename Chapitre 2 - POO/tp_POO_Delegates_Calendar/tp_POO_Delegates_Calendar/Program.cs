using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_POO_Delegates_Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            Calendar calendar = new Calendar(2021, Months.Janvier, 1, Days.Vendredi, 0);
            Alert alert = new Alert("Rendez-vous chez le coiffeur");
            Console.WriteLine(calendar);
            Console.WriteLine(alert.Message);

            for (int i = 1; i <= 10000; i++)
            {
                calendar.NewDayOnNextDay();
            }
            Console.WriteLine(calendar);

        }
    }
}

