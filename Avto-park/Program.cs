﻿using Library_avto_park;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Avto_park
{
    class Program
    {
        static List<Cars> Cars = new List<Cars>();

        public static byte[] array { get; private set; }
        public static byte[] Array { get; private set; }

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
                    FileReading();
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
            //TODO прописать цикл для отобрадения всего списка автомобией.
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
            Cars newCar = null;
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
            Cars.Add(newCar);
        }
        private static void SaveFiles()
        {
            Console.WriteLine("\tВведите название файла");
            string File_name = Console.ReadLine();
            array = new byte[50];
            string TextWriter = string.Empty;//
            using (FileStream fstream = new FileStream(@"file1.txt", FileMode.OpenOrCreate))
            fstream.Write(array, 0, array.Length);
            byte[] Array = Encoding.Default.GetBytes(TextWriter);
            string[] separatingChars = { "," };
            string[] numbers = TextWriter.Split(separatingChars, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("\tТекст из файла: {0}", TextWriter);
            Console.WriteLine("\tТекст записан в файл");
        }
        private static void FileReading()
        {
            Console.WriteLine("\tВведите название файла");
            string File_name = Console.ReadLine();
            Array = new byte[50];
            int ReadCount = 1;
            string text = string.Empty; // = ""  
            using (FileStream fstream = File.OpenRead(@"file1.txt"))

                while (ReadCount != 0)
                {

                    ReadCount = fstream.Read(Array, 0, Array.Length);
                    text += Encoding.Default.GetString(Array);
                }
            Console.WriteLine("\tТекст из файла: {0}", text);
        }
    }
}