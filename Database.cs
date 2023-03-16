using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB
{
    public class Database
    {
        private SqlConnectionStringBuilder connectionStringBuilder
        {
            get
            {
                var builder = new SqlConnectionStringBuilder();
                builder.DataSource = "WINAPTMDO3D7THZ\\SQLEXPRESS";
                builder.IntegratedSecurity = true;
                builder.InitialCatalog = "academynet";
                return builder;
            }
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionStringBuilder.ConnectionString);
        }

        public DataTable GetTables()
        {
            using (var conn = GetConnection())
            {
                var command = new SqlCommand();
                command.CommandText = "SELECT * " +
                    "FROM INFORMATION_SCHEMA.TABLES t " +
                    "WHERE t.TABLE_TYPE = 'Base Table' AND (T.TABLE_SCHEMA = 'production' OR T.TABLE_SCHEMA = 'sales')";
                command.Connection = conn;
                try
                {
                    conn.Open();
                    var reader = command.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public DataTable GetAllItems(string tableName)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand();
                command.CommandText = $"SELECT * FROM {tableName}";
                command.Connection = connection;
                try
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public DataTable GetAllProducts(string order, int value)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand();
                command.CommandText = $"SELECT * FROM production.products p\r\nWHERE p.list_price > {value.ToString()}\r\nORDER BY   p.product_id {order} ";
                command.Connection = connection;
                try
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
        public DataTable GetCategories()
        {
            using (var connection2 = GetConnection())
            {
                var command = new SqlCommand();
                command.CommandText = $"SELECT * FROM production.categories c";
                command.Connection = connection2;
                try
                {
                    connection2.Open();
                    var reader = command.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public DataTable GetBrands()
        {
            using (var connection2 = GetConnection())
            {
                var command = new SqlCommand();
                command.CommandText = $"SELECT * FROM production.brands b";
                command.Connection = connection2;
                try
                {
                    connection2.Open();
                    var reader = command.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public void AddProduct(string name, int brand_id, int category_id, int year, decimal list_price)

        {
            using (var conn = GetConnection())
            {
                var command = new SqlCommand();
                command.CommandText = $"INSERT INTO production.products (product_name, brand_id, category_id, model_year, list_price)   VALUES ('{name}','{brand_id}','{category_id}','{year}','{list_price}')";

                command.Connection = conn;
                try
                {
                    conn.Open();
                    MessageBox.Show("Hai inserito un prodotto!");
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public DataTable getStaff()
        {
            using (var conn = GetConnection())
            {

                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("dbo.getStaff", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = command.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);
                    return dt;
                }
                catch (Exception)
                {
                    throw;
                }
            }

        }
        public DataTable GetCustomers(string input)
        {
            using (var conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("dbo.getCustomers", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@City", input);
                    var reader = command.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    throw;
                }

            }
        }
        public DataTable GetCities()
        {
            using (var connection2 = GetConnection())
            {
                var command = new SqlCommand();
                command.CommandText = "SELECT DISTINCT c.city FROM sales.customers c";
                command.Connection = connection2;
                try
                {
                    connection2.Open();
                    var reader = command.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public DataTable GetFilteredProduct(int year , int brand , int category , decimal price)
        {
            using (var conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("dbo.getFilteredProduct", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Year", year);
                    command.Parameters.AddWithValue("@Brand", brand);
                    command.Parameters.AddWithValue("@Category", category);
                    command.Parameters.AddWithValue("@Price", price);

                    var reader = command.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    throw;
                }

            }
        }

    }
}


