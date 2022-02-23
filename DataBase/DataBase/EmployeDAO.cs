using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class EmployeDAO
    {
        public static List<Employee> ShowAll()
        {
            string url = "server=localhost;user=root;password=root;database=dotnet";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = url;

            try
            {
                con.Open();
                string query = "SELECT * from emp";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                List<Employee> empList = new List<Employee>();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    empList.Add(new Employee(Convert.ToInt32(reader["id"]), (string)reader["name"], Convert.ToInt32(reader["salary"])));


                }
                con.Close();
                return empList;
                
            }
            catch (Exception e)
            {
                return null;
            }
            
        }

        internal static void Delete(int v)
        {
            string url = "server=localhost;user=root;password=root;database=dotnet";
            MySqlConnection con = new MySqlConnection(url);
            try
            {
                con.Open();
                string query = "Delete from emp where id=" + v;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal static void Insert(Employee emp)
        {
            string url = "server=localhost;user=root;password=root;database=dotnet";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = url;

            try
            {
                con.Open();
                string query = "Insert into emp values("+emp.id+", '"+emp.name+"',"+emp.salary+")";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                
                cmd.ExecuteNonQuery();
                
                con.Close();
                

            }
            catch (Exception e)
            {
                
            }
        }
    }
}
