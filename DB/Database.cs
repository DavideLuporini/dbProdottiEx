using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public void AddProduct(string nome, decimal prezzo, int categoria, int brand, int anno)
        {
            //INSERT INTO production.products (product_id,product_name,brand_id,model_year,list_price)
            using (var connection2 = GetConnection())
            {
                var command = new SqlCommand();
                command.Parameters.AddWithValue("@val1", nome);
                command.Parameters.AddWithValue("@val2", brand);
                command.Parameters.AddWithValue("@val3", categoria);
                command.Parameters.AddWithValue("@val4", anno);
                command.Parameters.AddWithValue("@val5", prezzo);
                command.CommandText = $"INSERT INTO production.products (product_name,brand_id,category_id,model_year,list_price)\r\nVALUES (@val1 , @val2 , @val3, @val4 , @val5)";
                command.Connection = connection2;


                try
                {
                    connection2.Open();
                    var writer = command.ExecuteNonQuery();
                    //var dt = new DataTable();
                    //dt.Load(reader);
                    //reader.Close();
                    //return dt;
                }
                catch (Exception ex)
                {
                    throw;
                }



            }

        }


    }

}

