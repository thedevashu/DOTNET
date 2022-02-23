using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Example
{
    public class BankAccount
    {
        public event  TaxableIncome tax;
        public event NonTaxableIncome tax1;
        int balance { get; set; }
        public BankAccount(int money)
        {
            balance = money;
        }
        public int withdraw(int money)
        {
            int amt = balance - money;
            if(amt < 300000)
            {
                tax1();
                return amt;
            }
            return amt;
        }
        public void deposit(int money)
        {
            if((balance + money) >= 300000){
                tax();
            }
        }

    }
}
