using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Example
{
    public delegate void TaxableIncome();
    public delegate void NonTaxableIncome();
    class ITDeparment
    {
        public static void Alert()
        {
            Console.WriteLine("You have Taxable income give me money!!!!");
        }
        public static  void Relax()
        {
            Console.WriteLine("Relax you are broke ");
        }
    }
}
