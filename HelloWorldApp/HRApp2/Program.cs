using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib2;

namespace HRApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("as","as","as","sa");
            Console.WriteLine(p);
            Employee e = new Employee("Dev", "Satara", 35000, 1000, "Prasad", "Pisal", "pp@gmail.com", "9078563412");
            Console.WriteLine(e);
            Console.WriteLine("Total Salary: " + e.Computepay());
            Console.WriteLine("----------------");
            SalesPerson sp = new SalesPerson(700000, 1000001, "Sales", "Nigde", 19000, 100, "Raj", "Sing", "sing@gmail.com", "7856903412");
            Console.WriteLine(sp);
            Console.WriteLine("Total Pay: " + sp.Computepay());
            Console.ReadLine();
        }
    }
}
