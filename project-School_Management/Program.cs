using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_School_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> timetable = TimeTable.CreateCalendar();
            foreach(KeyValuePair<string,string> key in timetable)
            {
                Console.WriteLine(key);
               
            }
            Console.ReadKey();
        }
    }
}
