using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TouchID.Backend
{
    public static class MyDB
    {
        private static string connectionString = "server=localhost;user=root;password=1234;database=tubes3stima";

        public static string TestConnection()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Connection successful!");
                    return "skibidi";
                    // Example: Retrieve data from the database
                    //string query = "SELECT * FROM your_table_name";
                    //MySqlCommand cmd = new MySqlCommand(query, conn);

                    //using (MySqlDataReader reader = cmd.ExecuteReader())
                    //{
                    //    while (reader.Read())
                    //    {
                    //        Console.WriteLine(reader["your_column_name"].ToString());
                    //    }
                    //}
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return "error";
                }
                
            }
        }
    }
}
