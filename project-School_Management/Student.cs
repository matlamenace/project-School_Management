using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_School_Management
{
    class Student
    {
        // BENOIT
        string[] personnalinfo;
        List<string> attendance;
        string[] results;
        List<Course> ListofCourses;
        Fee fee;
        TimeTable timetable;

        public Student(string firstname,string famname,string gender, string dateofbirth) 
        {
            this.personnalinfo = new string[] { firstname, famname, gender, dateofbirth };
            this.fee = new Fee();
            string timetablename = personnalinfo[0] + "-" + personnalinfo[1] + "-" + "-timetable";
            this.timetable = new TimeTable(timetablename);
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
        public string[] Results 
        {
            get { return results; }
            set { results = value; }
        }
        public TimeTable Timetable
        {
            get { return timetable ; }
            set { timetable = value; }
        }
    }
}
