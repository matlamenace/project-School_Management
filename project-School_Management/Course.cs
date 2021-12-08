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
        public string date;
        Student student;
        public Course(string subject, string date, Student student) 
        {
            this.subject = subject;
            this.date = Fromdd_mmToWrittenDate( date);
            this.student = student;
            AddToCalendar();
        }
        public string Subject 
        {
            get { return subject; }
        }
        public static string Fromdd_mmToWrittenDate(string date) //method to turn a dd/mm date to a written date
        {
            string[] days = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            string[] months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December " };
            int[] splitedate = new int[2];
            splitedate[0] = Convert.ToInt32(date.Split('/')[0]);
            splitedate[1] = Convert.ToInt32(date.Split('/')[1]);
            return months[splitedate[1] - 1] + " " + date[0] + date[1];

        }
        private void AddToCalendar() //method that automatically add the course to the student's timetable 
        {
            if (student.Timetable.Timetable[date] == "Day off")
            {
                student.Timetable.Timetable[date] = $"Course : {subject}";
            }
            else
            {
                student.Timetable.Timetable[date] += '\n'+$"Course : {subject}";
            }
        
            
        }

    }
}
