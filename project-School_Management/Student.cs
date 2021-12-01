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
        List<string> attendence;
        string[] results;
        public Student(string firstname,string famname,string gender, string dateofbirth) 
        {
            this.personnalinfo = new string[] { firstname, famname, gender, dateofbirth };
        }
        public string[] Personnalinfo 
        {
            get { return personnalinfo; }
        }
        public List<string> Attendence 
        {
            get { return attendence; }
            set { attendence = value; }
        }
        public string[] Results 
        {
            get { return results; }
            set { results = value; }
        }
        osighzrgorgz();
    }
}
