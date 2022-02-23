using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using BLL;
using DAL;

namespace EcomTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------");
            Employee emp = new Employee();
            Console.WriteLine("Enter Id,Name,Desig,Salary of Employee");
            emp.Id = Convert.ToInt32( Console.ReadLine());
            emp.Name = (Console.ReadLine());
            emp.Designation = (Console.ReadLine());
            emp.Salary = Convert.ToInt32(Console.ReadLine());
            EmployeeManager.Insert(emp);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Enter Id to be Deleted: ");
            int id=Convert.ToInt32(Console.ReadLine());
            EmployeeManager.Delete(id);

            List<Employee> el = new List<Employee>();
            el = EmployeeManager.GetAllEmployee();
            foreach(Employee e in el)
            {
                Console.WriteLine("ID: " + e.Id + " Name: " + e.Name + " Desigination: " + e.Designation + " Salary: "+e.Salary);

            }
            Console.WriteLine("-------Want To Continue? Yes/No-------");
            string s=Console.ReadLine();
            if (s.Equals("Yes")) { Main(args); }
            else { Console.WriteLine("End"); }
        }

    }
}
