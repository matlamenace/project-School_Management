using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_School_Management
{
    class Fee
    {
        double ToBePay;
        double BeenPaid;
        public Fee()
        {
            this.ToBePay = 1000;
            this.BeenPaid = 0;
        }

        public void Pay(double amount)
        {
            if (ToBePay - amount >= 0)
            {
                ToBePay -= amount;
                BeenPaid += amount;
                Console.WriteLine($"Amount to be pay: {ToBePay}$");
            }
            else if (ToBePay - amount < 0)
                Console.WriteLine("A problem has occured: Amount bigger than the fees expected");
        }
    }
}
