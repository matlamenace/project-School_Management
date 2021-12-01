using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_School_Management
{
    class Course
    {
        string subject;
        public Course(string subject) 
        {
            this.subject = subject;
        }
        public string Subject 
        {
            get { return subject; }
        }

    }
}
