using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataProvider
    {
       
        
            const string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=DbCars;Integrated Security=True";
            public void InsertCarModel()
            {
                // Создать объект для записи в БД
         //       CarModel carModel = new CarModel
         //       {
           //         ModelName = "car"
                   // BodyType = 2
            //    };

            // Создать объект контекста
          //  UserContext context = new UserContext();

                // Вставить объект в БД и сохранить изменения
            //    context.carModels.Add(carModel);
            //    context.SaveChanges();
            }
        }

}

        /*
        public static CarModel GetCarModelById(int id)

        {




            //таблица 
            Table_CarModel();

            //добавление
            addingCarModel();

            //удаление
            DeleteCarModel();


            //изменение
            UpdateCarModel();
            List<clients> clients = new List<clients>();
            clients.Where(c => c.dob > DateTime.Parse("01.01.2000"));



            string sqlExpression = "SELECT * FROM car_models WHERE Id = " + id;


            SqlConnection connectionn;
            using ( connectionn = new SqlConnection(connectionString))
            {
                connectionn.Open();
                SqlCommand commandd = new SqlCommand(sqlExpression, connectionn);

                SqlDataReader readerr = commandd.ExecuteReader();

                CarModel result = null;

                while (readerr.Read())
                {
                    result = new CarModel()
                    {
                        Id = id,
                        ModelName = readerr.GetValue(1).ToString(),
                        ModelDate = DateTime.Parse(readerr.GetValue(2).ToString()),
                        BodyType = (MachineBodyType)Enum.Parse(typeof(MachineBodyType), readerr.GetValue(3).ToString()),
                        WarriantyRun = decimal.Parse(readerr.GetValue(4).ToString())
                    };

                }
                readerr.Close();
                return result;

            }
        }

        private static void Table_CarModel()
        {
            //таблица
            Console.WriteLine("\tВыберите автомобиль");
            string sqlExpressionnns = "SELECT * FROM car_models";
            using (SqlConnection connectionnn = new SqlConnection(connectionString))
            {
                connectionnn.Open();
                SqlCommand commandd = new SqlCommand(sqlExpressionnns, connectionnn);
                SqlDataReader readerr = commandd.ExecuteReader();
                if (readerr.HasRows) 
                {
                    // выводим названия столбцов
                    Console.WriteLine("\t{0} \t{1} \t{2} \t{3}", readerr.GetName(0), readerr.GetName(1), readerr.GetName(2), readerr.GetName(3));

                    while (readerr.Read()) // построчно считываем данные
                    {
                        object model_name = readerr.GetValue(1);
                        object model_date = readerr.GetValue(2);
                        object model_body = readerr.GetValue(3);
                        object warranty_run = readerr.GetValue(4);

                        Console.WriteLine("\t{0} \t{1} \t{2} \t{3} ", model_name, model_date, model_body, warranty_run);
                    }
                }
            }
        }

        private static void DeleteCarModel()
        {
            //удаление
            string sqlExpressionn = "DELETE  FROM car_models WHERE model_name='2121'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpressionn, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine("Удалено объектов: {0}", number);
            }
        }

        private static void addingCarModel()
        {

            //добавление
            Console.WriteLine("model_name:");
            string model_name = Console.ReadLine();

            Console.WriteLine("model_body:");
            int model_body = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Данные внесены");

            string sqlExpressionnn = String.Format("INSERT INTO car_models (model_name, model_body) VALUES ('{0}', {1})", model_name, model_body);
        }

        private static void UpdateCarModel()
        {
            //изменение
            string sqlExpressions = "UPDATE car_models SET model_name = 'Johnson' WHERE LastName = 'model_date'";
           // string sqlExpressions = $"UPDATE car_models SET model_body=20 WHERE model_name='qq'";
        //    string sqlExpressions = $"UPDATE car_models SET model_body= {(byte)model.BodyType}, model_date = '{model.ModelDate}' WHERE model_name='{model.ModelName}'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpressions, connection);
            }
        }



        public List<CarModel> GetAllCarModel()
        {
            List<CarModel> result = new List<CarModel>();
            string sqlExpression = "SELECT * FROM car_models";
            using (SqlConnection connectionn = new SqlConnection(connectionString))
            {
                connectionn.Open();
                SqlDataReader readerr = null;
                SqlCommand command = new SqlCommand(sqlExpression, connectionn);
                try
                {
                    readerr = command.ExecuteReader();


                    CarModel carModel = null;
                    while (readerr.Read())
                    {
                        carModel = new CarModel()
                        {
                            Id = int.Parse(readerr.GetValue(0).ToString()),
                            ModelName = readerr.GetValue(1).ToString(),
                            ModelDate = DateTime.Parse(readerr.GetValue(2).ToString()),
                            BodyType = (MachineBodyType)Enum.Parse(typeof(MachineBodyType), readerr.GetValue(3).ToString()),
                            WarriantyRun = decimal.Parse(readerr.GetValue(4).ToString())
                        };
                        result.Add(carModel);
                    }
                }
                finally
                {
                    readerr?.Close();
                }
                return result;
            }
        }

        public static Cars GetCarsByWin(int win)
        {
            string sqlExpression = "SELECT * FROM cars WHERE Win = " + win;

            //добавление
            addingCars();

            //удаление
            DeleteCars();

            //изменение
            UpdateCars();

            SqlConnection connectionn;
            using (connectionn = new SqlConnection(connectionString))
            {
                connectionn.Open();
                SqlCommand commandd = new SqlCommand(sqlExpression, connectionn);
                SqlDataReader readerr = commandd.ExecuteReader();
                Cars result = null;
                while (readerr.Read())
                {
                    result = new Cars()
                    {
                        Win = win,
                        CarDate = DateTime.Parse(readerr.GetValue(2).ToString()),
                        Color = readerr.GetValue(1).ToString(),
                        Model = int.Parse(readerr.GetValue(0).ToString())
                    };
                }
                readerr.Close();
                return result;
            }
        }

        private static void UpdateCars()
        {
            //изменение
            string sqlExpressions = "UPDATE cars SET color=011 WHERE win='1234'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpressions, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine("изменение: {0}", number);
            }
        }

        private static string addingCars()
        {


            //добавление
            Console.WriteLine("win:");
            int win = Int32.Parse(Console.ReadLine());

            Console.WriteLine("color:");
            string color = Console.ReadLine();
            Console.WriteLine("Данные внесены");

            string sqlExpressionnn = String.Format("INSERT INTO cars (win, color) VALUES ('{0}', {1})", win, color);
            return sqlExpressionnn;
        }

        private static void DeleteCars()
        {
            //удаление
            string sqlExpressionn = "DELETE  FROM cars WHERE win='1'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpressionn, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine("Удалено объектов: {0}", number);
            }
        }

        public List<Cars> GetAllCars()
        {
            List<Cars> result = new List<Cars>();
            string sqlExpression = "SELECT * FROM cars";
            using (SqlConnection connectionn = new SqlConnection(connectionString))
            {
                connectionn.Open();
                SqlDataReader readerr = null;
                SqlCommand commandd = new SqlCommand(sqlExpression, connectionn);
                try
                {
                    readerr = commandd.ExecuteReader();
                    Cars cars = null;
                    while (readerr.Read())
                    {
                        cars = new Cars()
                        {
                            Win = int.Parse(readerr.GetValue(0).ToString()),
                            CarDate = DateTime.Parse(readerr.GetValue(2).ToString()),
                            Color = readerr.GetValue(1).ToString()
                        };
                        result.Add(cars);
                    }
                }
                finally
                {
                    readerr?.Close();
                }
                return result;
            }
        }
        ///
        
            

        public static clients GetclientsByPhone(string phone)
        {

            string sqlExpression = "SELECT * FROM clients WHERE phone = " + phone;
            SqlConnection connectionn;
            using (connectionn = new SqlConnection(connectionString))
            {
                connectionn.Open();
                SqlCommand commandd = new SqlCommand(sqlExpression, connectionn);
                SqlDataReader readerr = commandd.ExecuteReader();
                clients result = null;
                if (readerr.Read())
                {
                    result = new clients()
                    {
                        Phone = phone,
                        fio = readerr.GetValue(2).ToString(),
                        dob = DateTime.Parse(readerr.GetValue(3).ToString()),
                        id = int.Parse(readerr.GetValue(0).ToString())
                    };
                }
                readerr.Close();
                return result;
            }
        }
        
        public List<clients> GetAllClients()
        {
            List<clients> result = new List<clients>();
            string sqlExpression = "SELECT * FROM clients";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataReader readerr = null;
                SqlCommand commandd = new SqlCommand(sqlExpression, connection);
                try
                {
                    readerr = commandd.ExecuteReader();
                    clients clients = null;
                    while (readerr.Read())
                    {
                        clients = new clients()
                        {
                            Phone = readerr.GetValue(2).ToString(),
                            fio = readerr.GetValue(2).ToString(),
                            dob = DateTime.Parse(readerr.GetValue(4).ToString()),
                            id = int.Parse(readerr.GetValue(0).ToString())
                        };
                        result.Add(clients);
                    }
                }
                finally
                {
                    readerr?.Close();
                }
                return result;
            }
        }

        public static sales GetSales(int car)
        {
            string sqlExpression = "SELECT * FROM sales WHERE car = " + car;
            using (SqlConnection connectionn = new SqlConnection(connectionString))
            {
                connectionn.Open();
                SqlCommand commandd = new SqlCommand(sqlExpression, connectionn);
                SqlDataReader readerr = commandd.ExecuteReader();
                sales result = null;
                while (readerr.Read())

                {
                    result = new sales()
                    {
                        car = car,
                        client = readerr.GetValue(1).ToString(),
                        buy_date = DateTime.Parse(readerr.GetValue(2).ToString())
                    };
                }
                readerr.Close();
                return result;
            }
        }

        public List<sales> GetAllSales()
        {
            List<sales> result = new List<sales>();
            string sqlExpression = "SELECT * FROM sales";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataReader readerr = null;
                SqlCommand commandd = new SqlCommand(sqlExpression, connection);
                try
                {
                    readerr = commandd.ExecuteReader();
                    sales sales = null;
                    while (readerr.Read())
                    {
                        sales = new sales()
                        {
                            car = int.Parse(readerr.GetValue(0).ToString()),
                            client = readerr.GetValue(1).ToString(),
                            buy_date = DateTime.Parse(readerr.GetValue(2).ToString()),
                        };
                        result.Add(sales);
                    }
                }
                finally
                {
                    readerr?.Close();
                }
                return result;
            }
        }
    }
}

        
        public static void CreateAutoSaleRecord()
        {
            {
                //string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Cars_cars;Integrated Security=True";
                
                Console.WriteLine("\tВыберите, что хотите сделать:");
                Console.WriteLine("\t1 - Продать авто");
                Console.WriteLine("\t2 - Изменить модельный ряд");
                Console.WriteLine("\t3 - Обновить информацию о клиенте");
                Console.WriteLine("\t4 - Принять партию автомобилей");
                Console.WriteLine("\t0 - Не известная команда");

                while (true)
                {
                    string answer = Console.ReadLine();
                    if (answer == "1")
                    {
                        //salesAvto();
                    }
                    else if (answer == "2")
                    {
                        //Change_model_range();
                    }
                    else if (answer == "3")
                    {
                        //Update_client();
                    }
                    else if (answer == "4")
                    {
                        //lot_of_cars();
                    }
                    else if (answer == "0")
                    {
                        break;
                    }
                    else
                        Console.WriteLine("\tНе известная команда");
                }
                
                //void salesAvto()
                {
                    Console.WriteLine("\tВыберите автомобиль");
                    string sqlExpression = "SELECT * FROM car_models";
                    using (SqlConnection connectionn = new SqlConnection(connectionString))
                    {
                        connectionn.Open();
                        SqlCommand commandd = new SqlCommand(sqlExpression, connectionn);
                        SqlDataReader readerr = commandd.ExecuteReader();
                        if (readerr.HasRows) // если есть данные
                        {
                            // выводим названия столбцов
                            Console.WriteLine("\t{0} \t{1} \t{2} \t{3}", readerr.GetName(0), readerr.GetName(1), readerr.GetName(2), readerr.GetName(3), readerr.GetName(4));

                            while (readerr.Read()) // построчно считываем данные
                            {
                                object id = readerr.GetValue(0);
                                object model_name = readerr.GetValue(1);
                                object model_date = readerr.GetValue(2);
                                object model_body = readerr.GetValue(3);
                                object warranty_run = readerr.GetValue(4);

                                Console.WriteLine("\t{0} \t{1} \t{2} \t{3} \t{4}", id, model_name, model_date, model_body, warranty_run);
                            }
                            //
                            Console.WriteLine("\tКупить автомобиль");
                            Console.WriteLine("\tВыберите клинта ");
                            string sqlExppression = "SELECT * FROM clients";
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();
                                SqlCommand command = new SqlCommand(sqlExppression, connection);
                                SqlDataReader reader = command.ExecuteReader();
                                if (reader.HasRows) // если есть данные
                                {
                                    // выводим названия столбцов
                                    Console.WriteLine("\t{0} \t{1} \t{2} \t{3}", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3));

                                    while (reader.Read()) // построчно считываем данные
                                    {
                                        object phone = reader.GetValue(0);
                                        object fio = reader.GetValue(1);
                                        object dob = reader.GetValue(2);
                                        object id = reader.GetValue(3);

                                        Console.WriteLine("\t{0} \t{1} \t{2} \t{3}", id, phone, fio, dob, id);
                                    }
                                    Console.WriteLine("\tДанные сохр");
                                }
                            }
                        }
                            {
                                Console.WriteLine("\tПринять партию автомобилей");
                                string sqlExpressionqq = "SELECT * FROM cars";
                                using (SqlConnection connection = new SqlConnection(connectionString))
                                {
                                    connection.Open();
                                    SqlCommand command = new SqlCommand(sqlExpressionqq, connection);
                                    SqlDataReader reader = command.ExecuteReader();

                                    if (reader.HasRows) // если есть данные
                                    {
                                        Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3));

                                        while (reader.Read()) // построчно считываем данные
                                        {
                                            object win = reader.GetValue(0);
                                            object car_date = reader.GetValue(1);
                                            object color = reader.GetValue(2);
                                            object model = reader.GetValue(3);

                                            Console.WriteLine("\t{0} \t{1} \t{2} \t{3}", win, car_date, color, model);
                                        }
                                    }
                                    reader.Close();
                                }
                            }
                            {
                                Console.WriteLine("\tПродажи");
                                string sqlExpressionq = "SELECT * FROM sales";
                                using (SqlConnection connection = new SqlConnection(connectionString))
                                {
                                    connection.Open();
                                    SqlCommand command = new SqlCommand(sqlExpressionq, connection);
                                    SqlDataReader reader = command.ExecuteReader();
                                    if (reader.HasRows)
                                    {
                                        Console.WriteLine("\t{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));

                                        while (reader.Read()) // построчно считываем данные
                                        {
                                            object car = reader.GetValue(0);
                                            object client = reader.GetValue(1);
                                            object buy_date = reader.GetValue(2);

                                            Console.WriteLine("\t{0} \t{1} \t{2}", car, client, buy_date);
                                        }
                                    }
                                    reader.Close();
                                }
                                Console.ReadLine();
                            }
                        }
                    }
                }
            }
        }
    }
    */
      