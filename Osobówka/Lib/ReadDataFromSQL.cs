using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace Osobówka.Lib
{
    public class ReadDataFromSQL
    {
        public void ReadData(string queryString, string connectionString)
        {
            
        }

        private static void CreateCommand(string queryString,
            string connectionString)
        {
            var query = "Select * from Persons";
            using (SqlConnection connection = new SqlConnection(
                       connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            
        }
    }
}