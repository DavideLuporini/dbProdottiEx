using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB
{
    public class Database
    {
        private SqlConnectionStringBuilder connectionStringBuilder
        {
            get
            {
                var builder = new SqlConnectionStringBuilder();
                builder.DataSource = "DESKTOP-J3NH6E3";
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

    }
}
