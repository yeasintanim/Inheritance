using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePracticeApp
{
    class SampleAccount : SavingAccount
    {
        public string SampleData { get; set; }

        public SampleAccount(string accountNumber, string customerName, double interestAmount) : base(accountNumber, customerName, interestAmount)
        {
        }
    }
}
