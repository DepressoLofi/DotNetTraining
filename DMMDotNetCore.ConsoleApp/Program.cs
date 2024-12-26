using DMMDotNetCore.ConsoleApp;
using DMMDotNetCore.ConsoleApp.AdoDotNetExamples;
using System.Data;
using System.Data.SqlClient;

// Ctrl + .  => suggestion
//nuget

//F10
//F11 
// F9 => breakpoint
// DatTable, SqlConnection, SqlConnectionStringBuilder, SqlCommand, SqlDataAdapter

// ############################################


//AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Read();
//adoDotNetExample.Create("title", "author", "content");
//adoDotNetExample.Update(1, "updated title", "updated author", "updated content");
//adoDotNetExample.Delete(1);
//adoDotNetExample.Edit(1);

// #########################################



//DapperExample dapperExample = new DapperExample();
//dapperExample.Run();


// ###########################################

//EFCoreExample eFCoreExample = new EFCoreExample();
//eFCoreExample.Run();

AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
adoDotNetExample.Read();


Console.ReadKey();