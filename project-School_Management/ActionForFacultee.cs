using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_School_Management
{
    class ActionForFacultee //class of action
    {
        public void AddGradeToExam(string grade, Exam exam)
        {
            exam.grade = grade;
        }
        public void AddGradeToAssignement(string grade, Assignement assignement)
        {
            assignement.grade = grade;
        }
        public void StudentAttendance(Student student)
        {
            foreach(string s in student.Attendence)
            {
                Console.WriteLine(s);
            }
        }
    }
}

