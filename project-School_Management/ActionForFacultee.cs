using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_School_Management
{
    class ActionForFacultee //class of action
    {
        public static void AddGradeToExam()
        {
            Console.Clear();
            Student student = StudentList.FromKeyToStudent();
            Console.Clear();

            Console.WriteLine("What is the subject of the Exam ?");
            string subject = Console.ReadLine();

            Console.WriteLine("\nWhat is the date of the Exam ? Write a dd/mm/yyyy date type");
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
        public static void AddGradeToAssignement()
        {
            Console.Clear();
            Student student = StudentList.FromKeyToStudent();
            Console.Clear();

            Console.WriteLine("What is the subject of the Assignement ?");
            string subject = Console.ReadLine();

            Console.WriteLine("\nWhat is the date of the Assignement ? Write a dd/mm/yyyy date type");
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
        public static void ShowStudentResults()
        {
            Console.Clear();
            Student student = StudentList.FromKeyToStudent();
            Console.Clear();

            
            foreach (string s in student.results)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}

