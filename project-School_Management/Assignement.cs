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
        Student student;
        public Assignement(Course course, string date)
        {
            this.course = course;
            this.date = date;
        }
        public Assignement(Student student ,string date, string subject) 
        {
            this.student = student;
            this.date = Course.Fromdd_mmToWrittenDate(date);
            AddToCalendar(subject);
            
        }
        public override string ToString()
        {
            if(grade != null)
                return $"Assignement: {course.Subject} \t date: {date} \t grade: {grade}";
            else
                return $"Assignement: {course.Subject} \t date: {date}";

        }
        private void AddToCalendar(string subject) //method that automatically add the assignment to the student's timetable 
        {
            if (student.Timetable.Timetable[date] == "Day off")
            {
                student.Timetable.Timetable[date] = $"Assignment : {subject}";
            }
            else
            {
                student.Timetable.Timetable[date] += '\n' + $"Assignment : {subject}";
            }


        }
    }
}
