using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using BOL;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class EmployeeDAO
    {
        public static bool Delete(int id)
        {
            bool status = false;
            string conString = ConfigurationManager.ConnectionStrings["MysqlDB"].ConnectionString;
            MySqlConnection con = new MySqlConnection(conString);
            try
            {
                MySqlCommand sqlCommand = new MySqlCommand();
                sqlCommand.Connection = con;
                sqlCommand.CommandText = "Delete from employee where id=@id";
                sqlCommand.Parameters.AddWithValue("@id", id);
                con.Open();
                sqlCommand.ExecuteNonQuery();
                con.Close();
                status = true;
            }
            catch (Exception)
            {
                Console.WriteLine("err");
            }
            return status;
          }

                public static bool Insert(Employee emp)
        {
            bool status = false;
            string conString = ConfigurationManager.ConnectionStrings["MysqlDB"].ConnectionString;
            MySqlConnection con = new MySqlConnection(conString);
            try
            {
                MySqlCommand sqlCommand = new MySqlCommand();
                sqlCommand.Connection = con;
                sqlCommand.CommandText = "Insert into Employee values(@id,@name,@desigination,@salary)";
                sqlCommand.Parameters.AddWithValue("@id", emp.Id);
                sqlCommand.Parameters.AddWithValue("@name", emp.Name);
                sqlCommand.Parameters.AddWithValue("@desigination", emp.Designation);
                sqlCommand.Parameters.AddWithValue("@salary", emp.Salary);
                con.Open();
                sqlCommand.ExecuteNonQuery();
                status = true;
                con.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Mysql Error " + e.Message);
            }
            return status;
        }
        public static List<Employee> GetEmployees()
        {
            List<Employee> ls = new List<Employee>();
            string conString = ConfigurationManager.ConnectionStrings["MysqlDB"].ConnectionString;
            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                
                MySqlCommand sqlCommand = new MySqlCommand();
                sqlCommand.Connection = con;
                sqlCommand.CommandText = "Select * from employee";
                con.Open();
                MySqlDataReader rd = sqlCommand.ExecuteReader();
                while (rd.Read())
                {
                    Employee employee = new Employee();
                    employee.Id = Convert.ToInt32( rd["Id"]);
                    employee.Name = rd["Name"].ToString();
                    employee.Designation = rd["Designation"].ToString();
                    employee.Salary = Convert.ToInt32(rd["salary"]);

                    ls.Add(employee);

                }
                con.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Mysql Error"+e);
            }
            return ls;
        }
    }
}
