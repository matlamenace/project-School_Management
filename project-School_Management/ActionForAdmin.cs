using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_School_Management
{
    class ActionForAdmin  //Class of action
    {
        public static void AddStudent(string firstname, string famname, string dateofbirth, string gender) 
        {
            Student student = new Student(firstname, famname, dateofbirth, gender);
            StudentList.studentlist.Add()
        }
        public static void AddCourse()
        {
            Console.WriteLine("What is the student's first name ?");
            string stfirstname = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What is the student's family name ?");
            string stfamname = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What is the course's subject ?");
            string subject = Console.ReadLine();
            Console.Clear();

            Course course = new Course(subject, date, student);
        }
    }
}
