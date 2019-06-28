﻿using Library_avto_park;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Avto_park
{
    [Serializable]
    class Program
    {
        static List<Car> Car = new List<Car>();
        private static byte[] array;

        public static string Marka { get; set; }
        public static int EngineCapacity { get; set; }
        public static string Colour { get; set; }
        public static int Year { get; set; }
        public static int car_weight { get; set; }
        public static int luggageSpace { get; set; }
        public static bool PresenceOfIgnition { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("\tВыберите, что хотите сделать:");
            Console.WriteLine("\t1 - Добавить новый автомобиль");
            Console.WriteLine("\t2 - Проссотреть список существющих");
            Console.WriteLine("\t3 - Сохранить файл");
            Console.WriteLine("\t4 - Выгрузить данные из файла");
            Console.WriteLine("\t0 - Выйти из программы");
            while (true)
            {
                string answer = Console.ReadLine();
                if (answer == "1")
                {
                    AddnewCar();
                    // Создаём автомобиль
                }
                else if (answer == "2")
                {
                    PrintAllCars();
                    // выводим все в консоль
                }
                else if (answer == "3")
                {
                    SaveFiles();
                    // сохраням в файл
                }
                else if (answer == "4")
                {
                    ReadFiles();
                    // выгрузить данные из файла
                }
                else if (answer == "0")
                {
                    break;
                }
                else
                    Console.WriteLine("\tНе известная команда");
            }
        }

        private static void PrintAllCars()
        {
            Console.WriteLine("\tДанные автомобиля");
            Console.WriteLine("\tOffroad - tayota 3.5 white 290 200 1300 true");
            Console.WriteLine("\tPassengerCar - vaz 1.6 blue 270 200 980 true");
            Console.WriteLine("\tTrucks - man 5.0 black 200 140 3640 true");
            Console.WriteLine("\tДля выхода нажмите - 0");
        }

        private static void AddnewCar()
        {
            Console.WriteLine("\tВыберите класс автомобиля");
            Console.WriteLine("\tPassengerCar {1}, Offroad {2}, Trucks{3}");
            int classAvto = Convert.ToUInt16(Console.ReadLine());
            Car newCar = null;
            Console.Write("\tВведите марку машины ");
            string Marka = Convert.ToString(Console.ReadLine());
            Console.Write("\tВведите объем двигателя ");
            float EngineCapacity = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\tВведите цвет автомобиля");
            string Colour = Convert.ToString(Console.ReadLine());
            Console.Write("\tВведите год выпуска ");
            int Year = Convert.ToInt16(Console.ReadLine());
            Console.Write("\tОбъем багажного отделения");
            int luggageSpace = Convert.ToInt16(Console.ReadLine());
            Console.Write("\tВес автомобиля");
            int car_weight = Convert.ToInt16(Console.ReadLine());
            Console.Write("\tНаличие зажигание");
            bool PresenceOfIgnition = Convert.ToBoolean(Console.ReadLine());
            switch (classAvto)
            {
                case 1:
                    newCar = new PassengerCar(Marka, EngineCapacity, Colour, Year, classAvto, luggageSpace, car_weight, PresenceOfIgnition);
                    break;
                case 2:
                    newCar = new Offroad(Marka, EngineCapacity, Colour, Year, classAvto, luggageSpace, car_weight, PresenceOfIgnition);
                    break;
                case 3:
                    newCar = new Trucks(Marka, EngineCapacity, Colour, Year, classAvto, luggageSpace, car_weight, PresenceOfIgnition);
                    break;
            }
            Car.Add(newCar);
        }
        private static void SaveFiles()
        {
            array = new byte[100];
            string text = string.Empty; // = ""  
          //  using (FileStream fstream = new FileStream(@"file1.txt", FileMode.OpenOrCreate))
            using (StreamWriter fstream = new StreamWriter(@"file1.txt", true, Encoding.Default))
            {
                {
                    text += Encoding.Default.GetString(array);
                }
            }
        }
        private static void ReadFiles()
        {
            array = new byte[100];
            int ReadCount = 1;
            string text = string.Empty; // = ""  
            using (FileStream fstream = File.OpenRead(@"file1.txt"))
            {
                while (ReadCount != 0)
                {
                    ReadCount = fstream.Read(array, 0, array.Length);
                    text += Encoding.Default.GetString(array);
                }

               // StreamWriter writer = new StreamWriter(@"text1.txt");
            //    XmlSerializer serializer = new XmlSerializer(typeof(Car));
             //   serializer.Serialize(writer, Car);
             //   writer.Close();

                //Чтение из файла
            //    Stream streamout = new FileStream(@"text1.txt", FileMode.Open, FileAccess.Read);
             //   XmlSerializer xml = new XmlSerializer(typeof(Car));
             //   Car Cars = (Car)xml.Deserialize(streamout);
             //   streamout.Close();


              //  Console.WriteLine("Марка  " + "Объем двигателя  " + "Цвет  " + "Год выпуска  " + "Объем багажного отделение  " + "Вес автомобиля  " + "Наличие зажигание  ");
             //   Console.WriteLine ( Marka + "    " + EngineCapacity + "    " + Colour + "    " + Year + "    " + luggageSpace + "    " + car_weight + "    " + PresenceOfIgnition );
             //   Console.ReadLine();
                  string[] PassengerCar = new string[] { "Марка  " + "Объем двигателя  " + "Цвет  " + "Год выпуска  " + "Объем багажного отделение  " + "Вес автомобиля  " + "Наличие зажигание  " };
                 string[] Offroad = new string[] { "Марка  " + "Объем двигателя  " + "Цвет  " + "Год выпуска  " + "Объем багажного отделение  " + "Вес автомобиля  " + "Наличие зажигание  " };
                  Console.WriteLine ( "Марка  " + "Объем двигателя  " + "Цвет  " + "Год выпуска  " + "Объем багажного отделение  " + "Вес автомобиля  " + "Наличие зажигание  " );
                  Console.WriteLine ( Marka + "    " + EngineCapacity + "    " + Colour + "    " + Year + "    " + luggageSpace + "    " + car_weight + "    " + PresenceOfIgnition );
                   string[] separatingChars = { "+", "," };
                  string[] car = text.Split(separatingChars, StringSplitOptions.RemoveEmptyEntries);
                  Console.WriteLine(text);
            }
        }
    }
}