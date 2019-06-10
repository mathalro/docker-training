using System;
using System.Data.SqlClient;

namespace RegisterApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = @"Initial Catalog=master;Data Source=localhost,1433;User ID=sa;Password=yourStrong(!)Password";
            var cnn = new SqlConnection(connectionString);
            cnn.Open();
            var commandStr = "CREATE TABLE Customer(First_Name char(20), Second_Name char(20))";
            using (SqlCommand command = new SqlCommand(commandStr, cnn))
            command.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
