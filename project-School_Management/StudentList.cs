using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_School_Management
{
    class StudentList
    {
        public static Dictionary<string, Student> studentlist = new Dictionary<string, Student>();
        public Dictionary<string, Student> Studentlist 
        {
            get { return studentlist; }
            set { studentlist = value; }
        }
    }
}
