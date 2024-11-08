using DMMDotNetCore.ConsoleApp;
using System.Data;
using System.Data.SqlClient;

// Ctrl + .  => suggestion
//nuget

//F10
//F11 
// F9 => breakpoint
// DatTable, SqlConnection, SqlConnectionStringBuilder, SqlCommand, SqlDataAdapter

// ############################################

AdoDotNetExample adoDotNetExample = new AdoDotNetExample();

adoDotNetExample.Read();
//adoDotNetExample.Create("title", "author", "content");


Console.ReadKey();