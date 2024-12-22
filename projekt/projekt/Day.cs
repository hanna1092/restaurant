using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Day
    {
        private float hour;
        private string weekday;
        private List<string> days;
        private int help;

        public Day(float hour, string weekday)
        {
            this.hour = hour;
            this.weekday = weekday;
            days = new List<string>() { "poniedzialek", "wtorek", "sroda", "czwartek", "piatek", "sobota", "niedziela" };
            help = 0;
        }
        public float Hour
        { get { return hour; }}
        public string Weekday
        { get { return weekday; } }
        public List<string> Days
        { get { return days; } }
        public void ChangeHour(float time)
        {  
            hour = hour + time;
            while(hour > 24)
            {
                hour = hour - 24;
                ChangeDay();
            }
        }
        
        public void ChangeDay()
        {
            int dayIndex = Days.IndexOf(weekday);
            if (dayIndex == 6)
                weekday = Days[0];
            else
                weekday = Days[dayIndex+ 1];
                
            
        }
        

    }
}
