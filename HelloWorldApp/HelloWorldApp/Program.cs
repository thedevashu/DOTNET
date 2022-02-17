using Banking;
using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acct = new Account(12, "Ravi Tambade", 45000);
            Console.WriteLine(acct);
            acct.Balance = 76000;
            Console.WriteLine(acct);
            double result = acct.Balance;
            Console.WriteLine("Result: "+result);
            Console.WriteLine(acct);
            Console.WriteLine("-------------------------------------------");
            Account a1 = new Account();
            Console.WriteLine(a1.Balance);
            a1.AccountId = 021;
            Console.WriteLine(a1);
            a1.AccountHolder = "Raju";
            Console.WriteLine(a1);
            a1.Deposit(6000);
            Console.WriteLine(a1);
            a1.Withdraw(3000);
            Console.WriteLine(a1);

            Console.WriteLine("-------------------------------------------");

            Account a2 = new Account(34, "Chotta Bhim", 102000);
            a2.Withdraw(2000);
            Console.WriteLine(a2);

        }
    }
}
