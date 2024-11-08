using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMMDotNetCore.ConsoleApp
{
    internal class AdoDotNetExample
    {
        private readonly SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = "localhost\\SQLEXPRESS",
            InitialCatalog = "DotNetTraining",
            UserID = "sa",
            Password = "pass",
        };

        public void Read()
        {
            SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);
            connection.Open();
            Console.WriteLine("Connection Open");
            string query = "select * from Tbl_Blog";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();
            Console.WriteLine("Connection Close");
        }

    }
}
