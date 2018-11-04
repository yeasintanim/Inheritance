using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InheritancePracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount sv1 = new SavingAccount("SV-101", "Ruhul Kuddus", 2000);
            SavingAccount sv2 = new SavingAccount("SV-101", "Jumman Kuddus", 2000);
            BankAccount b1 = new BankAccount("BA-101", "Asif Kuddus");
            BankAccount b2 = new BankAccount("BA-102", "Rahim Kuddus");
            //Console.WriteLine(sv1.Deposit(35000));
            //Console.WriteLine(sv1.Withdraw(4000));
            //Console.WriteLine(sv1.InterestAmount);
            //Console.WriteLine(sv1.CustomerName);
            //Console.WriteLine(sv1.AccountNumber);
            //Console.WriteLine(sv1.Balance);
            //BankAccount b1 = sv1;            
            //SavingAccount sv2 = (SavingAccount)b1;
            //Console.WriteLine(sv2.InterestAmount);            
            //Console.WriteLine(b1.AccountNumber);



            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(b1);
            accounts.Add(sv1);
            accounts.Add(sv2);


            foreach (BankAccount account in accounts)
            {
                Console.WriteLine(account.CustomerName);
            }




            //BankAccount b2 = new BankAccount("Ba-101","Asbi");
            //SavingAccount sv3 = (SavingAccount)b2;
            
           

            Console.ReadKey();

        }
    }
}
