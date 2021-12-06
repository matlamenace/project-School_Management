using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_School_Management
{
    class TimeTable
    {
        Dictionary<string, string> timetable;
        string timetablename;
        public TimeTable(string timetablename)
        {
            this.timetablename = timetablename;
            this.timetable = CreateCalendar();
        }
        public Dictionary<string, string> Timetable
        {
            get { return timetable; }
            set { timetable = value; }
        }
        public static Dictionary<string, string> CreateCalendar()
        {

            Dictionary<string, string> timetable = new Dictionary<string, string>();
            string[] months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December " };
            int[] daysInMonth = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            for (int i = 0; i < months.Length; i++)
            {
                for (int n = 1; n < daysInMonth[i]+1; n++)
                {
                   timetable.Add(months[i]+" "+n, "Day off");
                }
            }
            return timetable;
        }

    }
}
