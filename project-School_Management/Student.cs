using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_School_Management
{
    class Student
    {
        string[] personnalinfo;
        List<string> attendance;
        public List<string> results;
        Fee fee;
        TimeTable timetable;

        public Student(string firstname,string famname,string dateofbirth, string gender) 
        {
            this.personnalinfo = new string[] { firstname, famname, dateofbirth, gender };
            this.fee = new Fee();
            string timetablename = personnalinfo[0] + "-" + personnalinfo[1] + "-" + "-timetable";
            this.timetable = new TimeTable(timetablename);
            this.results = new List<string>();
            results.Add("\t\tRESULTS BOOK\n");
        }
        public Student()
        {
        }
        public string[] Personnalinfo 
        {
            get { return personnalinfo; }
        }
        public List<string> Attendence 
        {
            get { return attendance; }
            set { attendance = value; }
        }
        public List<string> Results 
        {
            get { return results; }
            set { results = value; }
        }
        public Fee Fee
        {
            get { return fee; }
            set { fee = value; }
        }
        public TimeTable Timetable
        {
            get { return timetable ; }
            set { timetable = value; }
        }
        public void ResultToString()
        {
            Console.WriteLine("Results book:\n");
            foreach(string result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
