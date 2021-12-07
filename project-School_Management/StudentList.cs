using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_School_Management
{
    class StudentList
    {
        public static Dictionary<string, Student> studentlist = new Dictionary<string, Student>();
        public Dictionary<string, Student> Studentlist 
        {
            get { return studentlist; }
            set { studentlist = value; }
        }
        public static Student FromKeyToStudent()
        {
            Console.Clear();
            Console.WriteLine("What is the student's first name ?");
            string stfirstname = Console.ReadLine().ToLower();
            stfirstname = new System.Globalization.CultureInfo("en-US", false).TextInfo.ToTitleCase(stfirstname.ToLower());

            Console.WriteLine();
            Console.WriteLine("What is the student's family name ?");
            string stfamname = Console.ReadLine().ToLower();
            stfamname = new System.Globalization.CultureInfo("en-US", false).TextInfo.ToTitleCase(stfamname.ToLower());
            Console.Clear();

            Student student = new Student();
            if (studentlist.ContainsKey(stfirstname + "-" + stfamname) == true)
            {
                StudentList.studentlist.TryGetValue(stfirstname + "-" + stfamname, out student);
            }
            else
            {
                Console.WriteLine("We can't find the student you entered, please try again");
                Console.ReadKey();
                FromKeyToStudent();
            }
            return student;
        }
    }
}
