// See https://aka.ms/new-console-template for more information
using DoteNet8.SqlTableDependency.Models;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Channels;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.EventArgs;

Console.WriteLine("Hello, World!");

string _connection = "Server=.;Database=TestDb;User Id=sa;Password=sasa@123;TrustServerCertificate=True;";


using (var dep = new SqlTableDependency<BlogModel>(_connection, "Tbl_Blog")) 
{
    dep.OnChanged += Changed;
    dep.Start();

    Console.WriteLine("Press a key to exit");
    Console.ReadKey();

    dep.Stop();
}
void Changed(object sender, RecordChangedEventArgs<BlogModel> e)
{
    var changedEntity = e.Entity;

    Console.WriteLine("DML operation: " + e.ChangeType);
    Console.WriteLine("Blog Id: " + changedEntity.BlogId);
    Console.WriteLine("Blog Title: " + changedEntity.BlogTitle);
    Console.WriteLine("Blog Author: " + changedEntity.BlogAuthor);
    Console.WriteLine("Blog Content: " + changedEntity.BlogContent);
}