using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_School_Management
{
    class Fee
    {
        double To_Be_Pay;
        double Been_Paid;
        public Fee()
        {
            this.To_Be_Pay = 1000;
            this.Been_Paid = 0;
        }

        public void Pay(double amount)
        {
            Console.WriteLine();
            if (To_Be_Pay - amount >= 0)
            {
                To_Be_Pay -= amount;
                Been_Paid += amount;
                Console.WriteLine($"Amount to be pay: {To_Be_Pay}$");
            }
            else if (To_Be_Pay - amount < 0)
                Console.WriteLine("A problem has occured: Amount bigger than the fees expected");
            Console.ReadKey();
        }
    }
}
