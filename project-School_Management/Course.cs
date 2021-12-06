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
        string date;
        Student student;
        public Course(string subject, string date, Student student) 
        {
            this.subject = subject;
            this.date = date;
            this.student = student;
        }
        public string Subject 
        {
            get { return subject; }
        }
        private void AddToCalendar() 
        {
            if(student.Timetable.Timetable[date]=="Day off") 
            {
                student.Timetable.Timetable[date] = $"Course : {subject}";
            }
            
        }

    }
}
