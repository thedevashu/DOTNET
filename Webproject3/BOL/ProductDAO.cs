using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace BOL
{
    public class ProductDAO
    {
        public static bool Insert(Product p)
        {
            bool status = false;
            string url = ConfigurationManager.ConnectionStrings["MysqlDB"].ConnectionString;
            try
            {
                MySqlConnection con = new MySqlConnection(url);
                MySqlCommand command = new MySqlCommand();
                con.Open();
                command.Connection = con;
                command.CommandText = "insert into product values(@id,@pname,@dsc,@price,@quantity)";
                command.Parameters.AddWithValue("@id", p.Id);
                command.Parameters.AddWithValue("@pname", p.PrductName);
                command.Parameters.AddWithValue("@dsc", p.Dsc);
                command.Parameters.AddWithValue("@price", p.Price);
                command.Parameters.AddWithValue("@quantity", p.Quantity);

                command.ExecuteNonQuery();
                con.Close();
                status = true;
            }
            catch
            {

            }
            return status;
        }
        public List<Product> GetAllProducts()
        {
            List<Product> plist = new List<Product>();
            String url = ConfigurationManager.ConnectionStrings["MysqlDB"].ConnectionString;
            MySqlConnection con = new MySqlConnection(url);
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * from Product";
                con.Open();
                MySqlDataReader rd= cmd.ExecuteReader();
                while (rd.Read())
                {
                    Product p = new Product()
                    {
                        Id = Convert.ToInt32(rd["Id"]),
                        PrductName = rd["PrductName"].ToString(),
                        Dsc = rd["Dsc"].ToString(),
                        Price = Convert.ToInt32(rd["Price"]),
                        Quantity = Convert.ToInt32(rd["Quantity"])
                    };
                    plist.Add(p);
                }

            }
            catch 
            {
            }
            con.Close();

            return plist;
        }
    }
}
