using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;
namespace BLL
{
    public class EmployeeManager
    {
        public static bool Delete(int id)
        {
            return EmployeeDAO.Delete(id);
        }
        public static bool Insert(Employee emp)
        {
            return EmployeeDAO.Insert(emp);
        }
        public static List<Employee> GetAllEmployee(){


            return EmployeeDAO.GetEmployees();
        }
    }
}
