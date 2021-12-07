using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_School_Management
{
    class Action //class of action
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
    }
}
