using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace project_School_Management
{
    class ActionForAdmin  //Class of action used by someone connected as an admin
    {
        public static void AddStudent() //Creates a new student and add it to the school
        {
            Console.Clear();
            Console.WriteLine("What is the student's first name ?");
            string stfirstname = Console.ReadLine().ToLower();
            if (stfirstname == "")
            {
                Console.WriteLine("The name you gave is null, please try again");
                Thread.Sleep(1500);
                Console.Clear();
                AddStudent();
            }
            stfirstname = new System.Globalization.CultureInfo("en-US", false).TextInfo.ToTitleCase(stfirstname.ToLower());
            Console.Clear();
            Console.WriteLine("What is the student's family name ?");
            string stfamname = Console.ReadLine().ToLower();
            if (stfamname == "")
            {
                Console.WriteLine("The name you gave is null, please try again");
                Thread.Sleep(1500);
                Console.Clear();
                AddStudent();
            }
            stfamname = new System.Globalization.CultureInfo("en-US", false).TextInfo.ToTitleCase(stfamname.ToLower());
            Console.Clear();
            Console.WriteLine("What is the student's date of birth ? Write a dd/mm/yyyy date type");
            string stdateofbirth = Console.ReadLine();
            if (stdateofbirth[2] != '/' || stdateofbirth[5] != '/' || stdateofbirth.Length != 10 || stdateofbirth == "")
            {
                Console.WriteLine("The date is not conform to a dd/mm/yyyy date type, please try again");
                Thread.Sleep(1500);
                Console.Clear();
                AddStudent();
            }
            Console.Clear();
            Console.WriteLine("What is the student's gender ?");
            string stgender = Console.ReadLine();
            if (stgender == "")
            {
                Console.WriteLine("The gender you gave is null, please try again");
                Thread.Sleep(1500);
                Console.Clear();
                AddStudent();
            }
            Console.Clear();

            Student student = new Student(stfirstname, stfamname, stdateofbirth, stgender);
            StudentList.studentlist.Add(stfirstname + "-" + stfamname, student);
        }
        public static void AddCourse() //Create a new course for a particuliar student
        {
            Console.Clear();
            Console.WriteLine("What is the student's first name ?");
            string stfirstname = Console.ReadLine().ToLower();
            if (stfirstname == "")
            {
                Console.WriteLine("The name you gave is null, please try again");
                Thread.Sleep(1500);
                Console.Clear();
                AddCourse();
            }
            stfirstname = new System.Globalization.CultureInfo("en-US", false).TextInfo.ToTitleCase(stfirstname.ToLower());
            Console.Clear();
            Console.WriteLine("What is the student's family name ?");
            string stfamname = Console.ReadLine().ToLower();
            if (stfamname == "")
            {
                Console.WriteLine("The name you gave is null, please try again");
                Thread.Sleep(1500);
                Console.Clear();
                AddCourse();
            }
            stfamname = new System.Globalization.CultureInfo("en-US", false).TextInfo.ToTitleCase(stfamname.ToLower());
            Console.Clear();
            Console.WriteLine("When is the course going to happen ? Type a date (dd/mm)");
            string date = Console.ReadLine();
            if (date[2] != '/' || date.Length != 5 || date == "")
            {

                Console.WriteLine("The date is not conform to a dd/mm date type, please try again");
                Thread.Sleep(1500);
                Console.Clear();
                AddCourse();
            }
            Console.Clear();
            Console.WriteLine("What is the subject of the course ?");
            string subject = Console.ReadLine();
            if (subject == "")
            {
                Console.WriteLine("The course you entered is null, please try again");
                Thread.Sleep(1500);
                Console.Clear();
                AddCourse();
            }
            if (StudentList.studentlist.ContainsKey(stfirstname + "-" + stfamname) == false)
            {
                Console.WriteLine("We can't find the student you entered, please try again");
                Thread.Sleep(1500);
                Console.Clear();
                AddCourse();
            }
            Course course = new Course(subject, date, StudentList.studentlist[stfirstname + "-" + stfamname]);
            Console.Clear();

        }
        public static void SeeIfPaid()
        {
            Student student = StudentList.FromKeyToStudent();
            if (student.Fee.To_Be_Pay == 0)
            {
                Console.WriteLine(student.Personnalinfo[0] + " " + student.Personnalinfo[1] + " paid all his fees");
            }
            else
            {
                Console.WriteLine($"{student.Personnalinfo[0]} {student.Personnalinfo[1]} still have to pay {student.Fee.To_Be_Pay} euros ");
            }
        }
    }   
}
