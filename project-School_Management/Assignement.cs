using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_School_Management
{
    class Assignement
    {
        public string grade { get; set; }
        Course course;
        string date;
        public Assignement(Course course, string date)
        {
            this.course = course;
            this.date = date;
        }
        public override string ToString()
        {
            if(grade != null)
                return $"Assignement: {course.Subject} \t date: {date} \t grade: {grade}";
            else
                return $"Assignement: {course.Subject} \t date: {date}";

        }
    }
}
