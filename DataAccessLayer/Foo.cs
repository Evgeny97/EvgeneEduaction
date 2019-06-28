using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class Foo
    {
        void DoStuff()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Cars_cars;Integrated Security=True";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Подключение открыто");
            }
            Console.WriteLine("Подключение закрыто...");

            Console.Read();
        }
    }
}