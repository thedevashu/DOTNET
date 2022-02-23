using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(13, "Janardhan Sind", 21000);
            EmployeDAO.Insert(emp);
            EmployeDAO.Insert(new Employee( 1, "Rakesh Soppaahekar", 1200) );
            EmployeDAO.Insert(new Employee(2, "GondalKae Navkve", 3000));
            EmployeDAO.Insert(new Employee(4, "Bulkan Tarmnt", 9900));
            EmployeDAO.Insert(new Employee(5, "Rohan Mohan ", 120));
            //EmployeDAO.Delete(13);
            //EmployeDAO.Delete(1);
            //EmployeDAO.Delete(2);
            // EmployeDAO.Delete(3);
            List<Employee> l = EmployeDAO.ShowAll();

            foreach(Employee e in l)
            {
                Console.WriteLine(e);
            }


            Console.ReadLine();
        }
    }

    
}
