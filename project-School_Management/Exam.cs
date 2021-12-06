using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_School_Management
{
    class Exam
    {
        public string grade { get; set; }
        Course course { get; set; }
        string date { get; set; }
        public Exam(Course course, string date) 
        {
            this.course = course;
            this.date = date;
        }
        public override string ToString()
        {
            if(grade != null)
                return $"Exam: {course.Subject} \t date: {date} \t grade: {grade}";
            else
                return $"Exam: {course.Subject} \t date: {date}";
        }
    }
}
