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
        public Student(string firstname,string famname,string gender, string dateofbirth) 
        {
            this.personnalinfo = new string[] { firstname, famname, gender, dateofbirth };
            this.fee = new Fee();
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
    }
}
