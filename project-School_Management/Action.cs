using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_School_Management
{
    class Action //class of action
    {
        public static void SeeTimetable() 
        {

        }
        public void PayFee(Student student, double amount)
        {
            student.Fee.Pay(amount);
        }
    }
}
