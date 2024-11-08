using System.Data;
using System.Data.SqlClient;

// Ctrl + .  => suggestion
//nuget

//F10
//F11 
// F9 => breakpoint
// DatTable, SqlConnection, SqlConnectionStringBuilder, SqlCommand, SqlDataAdapter


Console.WriteLine("Hello, World!");

SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
stringBuilder.DataSource = "localhost\\SQLEXPRESS"; //server name
stringBuilder.InitialCatalog = "DotNetTraining"; //database name
stringBuilder.UserID = "sa";
stringBuilder.Password = "pass";

SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);

connection.Open();
Console.WriteLine("Connection is open.");

string query = "select * from tbl_blog";
SqlCommand cmd = new SqlCommand(query, connection);
SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
DataTable dt = new DataTable();
sqlDataAdapter.Fill(dt);

connection.Close();
Console.WriteLine("Connection is close");


foreach (DataRow dr in dt.Rows)
{
    Console.WriteLine("Blog Id => " + dr["BlogId"]);
    Console.WriteLine("Blog Title => " + dr["BlogTitle"]);
    Console.WriteLine("Blog Author => " + dr["BlogAuthor"]);
    Console.WriteLine("Blog Content => " + dr["BlogContent"]);
    Console.WriteLine("#####################");
}



Console.ReadKey();