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
        }
        public void PayFee(Student student, double amount)
        {
            student.Fee.Pay(amount);
        }
    }
}
