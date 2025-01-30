using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }

        public Account(int accountNumber, string holderName, double initialDeposit)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = initialDeposit;
        }
    }
}
