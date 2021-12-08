using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_School_Management
{
    class Fee
    {
        double to_Be_Pay;
        double Been_Paid;
        public Fee()
        {
            this.to_Be_Pay = 1000;
            this.Been_Paid = 0;
        }

        public void Pay(double amount) //method used by the Action class for a student to pay a fee
        {
            Console.WriteLine();
            if (to_Be_Pay - amount >= 0)
            {
                to_Be_Pay -= amount;
                Been_Paid += amount;
                Console.WriteLine($"Amount to be pay: {to_Be_Pay}$");
            }
            else if (to_Be_Pay - amount < 0)
                Console.WriteLine("A problem has occured: Amount bigger than the fees expected");
            Console.ReadKey();
        }
        public double To_Be_Pay
        {
            get { return to_Be_Pay; }
        }
    }
}
