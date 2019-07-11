using RegisterApi.Models;
using System.Data.SqlClient;

namespace RegisterApi.Services
{
    public class DataBaseService : IDataBaseService
    {
        public string CreateRegister(Person person)
        {
            try
            {
                var connectionString = @"Initial Catalog=master;Data Source=mssql;User ID=sa;Password=yourStrong(!)Password";
                var cnn = new SqlConnection(connectionString);
                cnn.Open();

                var commandStr = "IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Customers' and xtype='U') CREATE TABLE Customers(First_Name varchar(20), Second_Name varchar(20))";
                using (SqlCommand command = new SqlCommand(commandStr, cnn)) 
                {
                    command.ExecuteNonQuery();
                }
                
                commandStr = $"INSERT INTO Customers (First_Name, Second_Name) VALUES('{person.FirstName}', '{person.LastName}')";
                using (SqlCommand command = new SqlCommand(commandStr, cnn)) 
                {
                    command.ExecuteNonQuery();
                }

                cnn.Close();
                return "Register created succesfully";
            }
            catch (System.Exception ex) {
                return ex.ToString();
            }
        }

        Person[] IDataBaseService.GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}