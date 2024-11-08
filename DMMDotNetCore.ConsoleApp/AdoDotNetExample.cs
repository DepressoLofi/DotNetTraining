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
           
            string query = "select * from Tbl_Blog";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();
            

            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine("Blog Id => " + dr["BlogId"]);
                Console.WriteLine("Blog Title => " + dr["BlogTitle"]);
                Console.WriteLine("Blog Author => " + dr["BlogAuthor"]);
                Console.WriteLine("Blog Content => " + dr["BlogContent"]);
                Console.WriteLine("#####################");
            }
        }

        public void Create(string title, string author, string content)
        {
            SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);

            connection.Open();

            string query = @"INSERT INTO [dbo].[Tbl_Blog]
           ([BlogTitle]
           ,[BlogAuthor]
           ,[BlogContent])
     VALUES
           (@BlogTitle
           , @BlogAuthor
           , @BlogContent)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@BlogTitle", title);
            cmd.Parameters.AddWithValue("@BlogAuthor", author);
            cmd.Parameters.AddWithValue("@BlogContent", content);
            int result = cmd.ExecuteNonQuery();
            connection.Close();

            string message = result > 0 ? "Saving Successful." : "Saving Failed.";
            Console.WriteLine(message);
        }

        public void Update(int id, string title, string author, string content)
        {

        }

    }
}
