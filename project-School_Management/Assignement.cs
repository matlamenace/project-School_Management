using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_School_Management
{
    class Assignement
    {
        Course course;
        string date;
        public Assignement(Course course, string date)
        {
            this.course = course;
            this.date = date;
        }
        public override string ToString()
        {
            return $"Assignement : {course.Subject} date : {date}";
        }
    }
}
