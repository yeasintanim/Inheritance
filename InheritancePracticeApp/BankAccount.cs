using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePracticeApp
{
    class BankAccount
    {
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; private set; }
        public BankAccount(string accountNumber, string customerName) : this()
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;            
        }

        public BankAccount()
        {
            Balance = 0;
        }

        public string Deposit(double amount)
        {            
            Balance += amount;
            return "Deposit Successful";
        }
        public virtual string Withdraw(double amount)
        {
            Balance -= amount;
            return "Withdraw Successful";
        }
    }
}
