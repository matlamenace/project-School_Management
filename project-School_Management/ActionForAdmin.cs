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
        }
        public static void AddCourse(string subject)
        {
            Course course = new Course(subject);
        }
    }
}
