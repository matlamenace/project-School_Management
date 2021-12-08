using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_School_Management
{
    abstract class Action //class of action used by someone connected as a student 
    {
        public static void SeeTimetable(Student student) 
        {
            foreach (KeyValuePair<string, string> key in student.Timetable.Timetable)
            {
                Console.WriteLine(key);
            }
            Console.ReadKey();
        }
        public static void PayFee(Student student)
        {
            Console.Clear();
            Console.WriteLine("How much do you want to pay ?");
            double amount = Convert.ToDouble(Console.ReadLine());

            student.Fee.Pay(amount);
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
