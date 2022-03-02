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
    public class EmployeeDAODisconnecte
    {
        public static string conString = ConfigurationManager.ConnectionStrings["MysqlDB"].ConnectionString;
        

        public static Boolean DeleteEmployee(int id)
        {
            Boolean status = false;
            MySqlConnection connection = new MySqlConnection(conString);
            MySqlCommand mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = connection;
            mySqlCommand.CommandText = "SELECT * from employee";

            try
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);
                DataSet dataSet = new DataSet();
                mySqlDataAdapter.Fill(dataSet);

                DataTable dataTable = dataSet.Tables[0];
                DataColumn[] dataColumn = new DataColumn[1];
                dataColumn[0] = dataTable.Columns["Id"];
                dataTable.PrimaryKey = dataColumn;

                DataRowCollection dataRowCollection = dataTable.Rows;
                DataRow foundRow = dataRowCollection.Find(id);
                foundRow.Delete();
                mySqlDataAdapter.Update(dataSet);
                status = true;
                return status;

            }
            catch (Exception)
            {

            }
            return status;
        }
        public static Boolean InsertEmployee(Employee e)
        {
            Boolean status = false;
            MySqlConnection connection = new MySqlConnection(conString);
            MySqlCommand mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = connection;
            mySqlCommand.CommandText = "SELECT * from employee";

            try
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);
                DataSet dataSet = new DataSet();
                mySqlDataAdapter.Fill(dataSet);

                DataTable dataTable = dataSet.Tables[0];
                DataRow newRow = dataTable.NewRow();
                newRow["Id"] = e.Id;
                newRow["Name"] = e.Name;
                newRow["Designation"] = e.Designation;
                newRow["Salary"] = e.Salary;

                DataRowCollection dataRowCollection = dataTable.Rows;
                dataRowCollection.Add(newRow);
                mySqlDataAdapter.Update(dataSet);
                status = true;
                return status;

            }
            catch(Exception)
            {

            }
            return status;
        }
        public static List<Employee> GetEmployees()
        {
            List<Employee> allEmp = new List<Employee>();
            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand sqlCommand = new MySqlCommand();
            sqlCommand.Connection = con;
            sqlCommand.CommandText = "SELECT * from Employee";
            try
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCommand);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                DataTable dataTable = ds.Tables[0];
                DataRowCollection rowCollection = dataTable.Rows;

                foreach(DataRow row in rowCollection)
                {
                    Employee employee = new Employee()
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Name = row["Name"].ToString(),
                        Designation = row["Designation"].ToString(),
                        Salary = Convert.ToInt32(row["Salary"])
                    };
                    allEmp.Add(employee);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }


            return allEmp;
        }
    }
}
