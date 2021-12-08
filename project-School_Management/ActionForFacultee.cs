using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace project_School_Management
{
    // PROJECT BY Matthieu Perret (24475), Lucie Mallet (24470), Mathis Tiberghien (24445), Benoit Jaffuel (24431)
    class ActionForFacultee : Action //class of action used by someone connected as a professor 
    {
        public static void AddGradeToExam() 
        {
            Console.Clear();
            Student student = StudentList.FromKeyToStudent();
            Console.Clear();

            Console.WriteLine("What is the subject of the Exam ?");
            string subject = Console.ReadLine();

            Console.WriteLine("\nWhat is the date of the Exam ? Write a dd/mm date type");
            string date = Console.ReadLine();

            Course course = new Course(subject, date, student);

            Exam exam = new Exam(course, course.date);

            Console.Clear();
            Console.WriteLine("Enter the grade of this Exam");
            string grade = Console.ReadLine();
            exam.grade = grade;

            string str_result = $"Exam: {course.Subject} \t date: {date} \t grade: {grade}";
            Console.WriteLine(str_result);
            Console.ReadKey();

            student.results.Add(str_result);
        }
        public static void AddGradeToAssignement() //This method creates a new grade to an assignment
        {
            Console.Clear();
            Student student = StudentList.FromKeyToStudent();
            Console.Clear();

            Console.WriteLine("What is the subject of the Assignement ?");
            string subject = Console.ReadLine();

            Console.WriteLine("\nWhat is the date of the Assignement ? Write a dd/mm date type");
            string date = Console.ReadLine();

            Course course = new Course(subject, date, student);

            Assignement assignement = new Assignement(course, course.date);

            Console.Clear();
            Console.WriteLine("Enter the grade of this Assignement");
            string grade = Console.ReadLine();
            assignement.grade = grade;

            string str_result = $"Assignement: {course.Subject} \t date: {date} \t grade: {grade}";
            Console.WriteLine(str_result);
            Console.ReadKey();

            student.Results.Add(str_result);
        }
        
        public static void AddAssigment() //This method creates a new assigment
        {
            Console.Clear();
            Console.WriteLine("What is the student's first name ?");
            string stfirstname = Console.ReadLine().ToLower();
            if (stfirstname == "")
            {
                Console.WriteLine("The name you gave is null, please try again");
                Thread.Sleep(1500);
                Console.Clear();
                AddAssigment();
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
                AddAssigment();
            }
            stfamname = new System.Globalization.CultureInfo("en-US", false).TextInfo.ToTitleCase(stfamname.ToLower());
            Console.Clear();
            Console.WriteLine("When is the assignment going to happen ? Type a date (dd/mm)");
            string date = Console.ReadLine();
            if (date[2] != '/' || date.Length != 5 || date == "")
            {

                Console.WriteLine("The date is not conform to a dd/mm date type, please try again");
                Thread.Sleep(1500);
                Console.Clear();
                AddAssigment();
            }
            Console.Clear();
            Console.WriteLine("What is the subject of the assignement ?");
            string subject = Console.ReadLine();
            if (subject == "")
            {
                Console.WriteLine("The assignment you entered is null, please try again");
                Thread.Sleep(1500);
                Console.Clear();
                AddAssigment();
            }
            if (StudentList.studentlist.ContainsKey(stfirstname + "-" + stfamname) == false)
            {
                Console.WriteLine("We can't find the student you entered, please try again");
                Thread.Sleep(1500);
                Console.Clear();
                AddAssigment();
            }
            Assignement assigment = new Assignement(StudentList.studentlist[stfirstname + "-" + stfamname], date, subject);
            Console.Clear();
        }
        public static void AddExam() //This method get creates a new exam
        {
            Console.Clear();
            Console.WriteLine("What is the student's first name ?");
            string stfirstname = Console.ReadLine().ToLower();
            if (stfirstname == "")
            {
                Console.WriteLine("The name you gave is null, please try again");
                Thread.Sleep(1500);
                Console.Clear();
                AddExam();
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
                AddExam();
            }
            stfamname = new System.Globalization.CultureInfo("en-US", false).TextInfo.ToTitleCase(stfamname.ToLower());
            Console.Clear();
            Console.WriteLine("When is the exam going to happen ? Type a date (dd/mm)");
            string date = Console.ReadLine();
            if (date[2] != '/' || date.Length != 5 || date == "")
            {

                Console.WriteLine("The date is not conform to a dd/mm date type, please try again");
                Thread.Sleep(1500);
                Console.Clear();
                AddExam();
            }
            Console.Clear();
            Console.WriteLine("What is the subject of the exam ?");
            string subject = Console.ReadLine();
            if (subject == "")
            {
                Console.WriteLine("The exam you entered is null, please try again");
                Thread.Sleep(1500);
                Console.Clear();
                AddExam();
            }
            if (StudentList.studentlist.ContainsKey(stfirstname + "-" + stfamname) == false)
            {
                Console.WriteLine("We can't find the student you entered, please try again");
                Thread.Sleep(1500);
                Console.Clear();
                AddExam();
            }
            Exam exam = new Exam(StudentList.studentlist[stfirstname + "-" + stfamname], date, subject);
            Console.Clear();
        }
    }
}

