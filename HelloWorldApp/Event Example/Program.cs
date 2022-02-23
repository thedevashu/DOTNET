using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Example
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Student s = new Student();
            s.op += new Passing(School.Passing);
            s.bot += new Passing(School.Failing);
            s.name = "Raju";
            s.setMarks(123);

            //BankAccount b = new BankAccount(20000);
           //b.tax += new TaxableIncome(ITDeparment.Alert);
           // b.tax1 += new NonTaxableIncome(ITDeparment.Relax);
            //b.deposit(2000000);

            //b.withdraw(200000);
           // Vaccinate v = new Vaccinate();
           // v.AChecker += new AgeMsg(AgeController.ValidAge);
           // int age = int.Parse(Console.ReadLine());
            //v.getShot(age);
            Console.ReadLine();

            

        }
    }
}
