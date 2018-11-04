using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePracticeApp
{
    class SavingAccount : BankAccount
    {
        public double InterestAmount { get; set; }
        public SavingAccount(string accountNumber, string customerName, double interestAmount) : base(accountNumber,customerName)
        {
            InterestAmount = interestAmount;           
        }       
        public override string Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                return base.Withdraw(amount);
            }
            else
            {
                return "Insufficient Balance";
            }
        }

        //public string WithdrawFromSavingAccount(double amount)
        //{
        //    if (amount <= Balance)
        //    {
        //        return Withdraw(amount);
        //    }
        //    else
        //    {
        //        return "Insufficient Balance";
        //    }
        //}
    }
}
