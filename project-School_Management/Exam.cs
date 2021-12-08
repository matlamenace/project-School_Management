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
        Student student;
        public Exam(Course course, string date) //This constructor is for creating a grade by instantiating a new Exam
        {
            this.course = course;
            this.date = date;
        }
        public Exam(Student student, string date, string subject) //This constructor is made to add an Exam to a student's timetable
        {
            this.student = student;
            this.date = Course.Fromdd_mmToWrittenDate(date);
            AddToCalendar(subject);
        }
        private void AddToCalendar(string subject)//method that automatically add the exam to the student's timetable 
        {
            if (student.Timetable.Timetable[date] == "Day off")
            {
                student.Timetable.Timetable[date] = $"Exam : {subject}";
            }
            else
            {
                student.Timetable.Timetable[date] += '\n' + $"Exam : {subject}";
            }


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
