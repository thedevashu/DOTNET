using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using BOL;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class EmployeeDAO
    {
        public static bool CreateStoredProcedure()
        {
            bool status = false;
            string conString = ConfigurationManager.ConnectionStrings["MysqlDB"].ConnectionString;
            MySqlConnection con = new MySqlConnection(conString);
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                con.Open();
                //Create Stored Procedure : DDL
                cmd.CommandText = "DROP  PROCEDURE IF EXISTS add_people";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "DROP  TABLE  IF  EXISTS people";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE TABLE people ( " +
                                  "id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY, first_name VARCHAR(20)," +
                                  "last_name VARCHAR(20), birthdate DATE)";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE PROCEDURE add_people(" +
                                  "IN fname VARCHAR(20), IN lname VARCHAR(20), IN bday DATETIME, OUT id INT)" +
                                  "BEGIN INSERT INTO people(first_name, last_name, birthdate) " +
                                  "VALUES(fname, lname, DATE(bday)); SET id = LAST_INSERT_ID(); END";

                cmd.ExecuteNonQuery();
                status = true;
                con.Close();
            }
            catch (MySqlException exp)
            {
                Console.WriteLine(exp);
            }
            finally
            {
            }

            return status;
        }
        public static bool InvokeStoredProcedure()
        {
            bool status = false;

            string conString = ConfigurationManager.ConnectionStrings["MysqlDB"].ConnectionString;
            MySqlConnection con = new MySqlConnection(conString);
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "add_people";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@lname", "Kulkarni");
                cmd.Parameters["@lname"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@fname", "Sudhir");
                cmd.Parameters["@fname"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@bday", "1976-01-05");
                cmd.Parameters["@bday"].Direction = ParameterDirection.Input;

                cmd.Parameters.Add("@id", MySqlDbType.Int32);
                cmd.Parameters["@id"].Direction = ParameterDirection.Output;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (MySqlException exp)
            {
                Console.WriteLine(exp);
            }

            finally
            {
            }

            return status;
        }

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
