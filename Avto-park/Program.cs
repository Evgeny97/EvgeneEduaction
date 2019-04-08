using System;
using System.Collections.Generic;
using Library_avto_park;

namespace Avto_park
{
    class Program
    {
        static List<Car> Cars = new List<Car>();

        static void Main(string[] args)
        {
            {
                Console.WriteLine("Выберите, что хотите сделать:");
                Console.WriteLine("1 - Добавить новый автомобиль");
                Console.WriteLine("2 - Проссотреть списк существющих");
                Console.WriteLine("3 - Марки проданных автомобилей");
                foreach (var item in Cars)
                {
                    Console.WriteLine(item);
                }
                    string answer = Console.ReadLine();
                {
                    List<Car> marka; //первый элемент
                    List<Car> presenceOfIgnition; // последний/
                    int count;  // количество элементов в списке
                }
                if (answer == "1")
                {
                    Console.Write("Введите марку машины ");
                    string Marka = Convert.ToString(Console.ReadLine());
                    Car marka = null;
                    Cars.Add(marka);
                    Console.Write("Введите объем двигателя ");
                    int EngineCapacity = Convert.ToInt16(Console.ReadLine());
                    Car engineCapacity = null;
                    Cars.Add(engineCapacity);
                    Console.WriteLine("Введите цвет автомобиля");
                    string Colour = Convert.ToString(Console.ReadLine());
                    Car colour = null;
                    Cars.Add(colour);
                    Console.Write("Введите год выпуска ");
                    int Year = Convert.ToInt16(Console.ReadLine());
                    Car year = null;
                    Cars.Add(year);
            //        for (node = List.First; node != null; node = node.Next)
          //              Console.Write(node.Value + "\t");
                    Console.WriteLine("Для выхода нажмите - Enter");
                    //     Console.WriteLine("Ваша машина добавлена");
                    // Создаём автомобиль

                }
                else if (answer == "2")
                {
                    Console.WriteLine("Данный автомобиль");
                    Console.WriteLine("Offroad - tayota 3.5 white 290 200 1300 true");
                    Console.WriteLine("");
                    Offroad tayota = new Offroad("tayota", (float)1.6, "black", 222,222,222,false);
                    Cars.Add(tayota);
                    PassengerCar vaz = new PassengerCar("vaz", (float)6.0, "black", 290, 200, 1300, true);
                    Cars.Add(vaz);
                    Console.WriteLine("Для выхода нажмите - Enter");

                    // выводим все в консоль
                }
                else if (answer == "3")
                {
                    Console.WriteLine("Offroad - 1");
                    Console.WriteLine("Passenger Car - 2");
                    Console.WriteLine("Trucks - 3");
                    // сохраням в файл
                }
                else
                    Console.WriteLine("Не известная команда");
                {
                    Console.ReadLine();
                    {

                        PassengerCar vaz = new PassengerCar("vaz", (float)6.0, "black", 290, 200, 1300, true);
                        Cars.Add(vaz);
                  //      PassengerCar marka = new PassengerCar("vaz", (float)6.0, "black", 290, 200, 1300, true);
                   //     Cars.Add(marka);

                        //
                        Offroad tayota = new Offroad("tayota", (float)3.5, "white", 290, 250, 1800, true);
                        Cars.Add(tayota);

                        Trucks KAMAZ = new Trucks("KAMAZ", (float)4.6, "red", 160, 360, 3750, true);
                        Cars.Add(KAMAZ);
                        Console.ReadLine();
                        //     {
                        //        Console.WriteLine("\tМарка автомобиля: {0} ", car.Marka);
                        //        Console.WriteLine("\tОбъем двигателя: {0}", car.EngineCapacity);
                        //        Console.WriteLine("\tТекущая скорость: {0}", car.Colour);
                        //         Console.WriteLine("\tОбъем багажного отделения: {0}", car.LuggageSpace);
                        //          Console.WriteLine("\tТекущая нагрузка: {0}", car.Сar_weight);
                        //          Console.WriteLine("\tМаксимальная скорость: {0}", car.MaxSpeed);
                        //          Console.WriteLine("\tНаличие зажигание: {0}", car.PresenceOfIgnition);
                        //          Console.ReadLine();
                        //     }

                    }
                }
            }
        }
    }
}
