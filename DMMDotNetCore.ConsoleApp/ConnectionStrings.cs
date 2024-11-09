using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMMDotNetCore.ConsoleApp
{
    internal class ConnectionStrings
    {
        public static SqlConnectionStringBuilder SqlConnectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = "localhost\\SQLEXPRESS",
            InitialCatalog = "DotNetTraining",
            UserID = "sa",
            Password = "pass",
        };
    }
}
