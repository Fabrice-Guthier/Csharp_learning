using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_POO_Delegates_Calendar
{
    class Calendar
    {
        public int Year { get; set; }
        public Months Month { get; set; }
        public int DayNumber { get; set; }
        public Days DayName { get; set; }
        public int Hours { get; set; }
        public List<Alert> Alerts { get; set; }
        public Calendar(int year, Months month, int dayNumber, Days dayName, int hours)
        {
            Year = year;
            Month = month;
            DayNumber = dayNumber;
            DayName = dayName;
            Alerts = new List<Alert>();
        }

        public void AddAlert(string message)
        {
            Alerts.Add(new Alert(message));
        }

        public override string ToString()
        {
            return $"{DayName} {DayNumber} {Month} {Year}";
        }

        public void NextDay()
        {
            if (DayName == Days.Dimanche)
            {
                DayName = Days.Lundi;
            }
            else
            {
                DayName++;
            }
            DayNumber++;
            if (DayNumber > 30)
            {
                DayNumber = 1;
                if (Month == Months.Décembre)
                {
                    Month = Months.Janvier;
                    Year++;
                }
                else
                {
                    Month++;
                }
            }
        }

        public event Action OnNextDay;

        public void NewDayOnNextDay()
        {
            this.NextDay();
            if (OnNextDay != null)
            {
                OnNextDay();
            }
        }
    }
}
