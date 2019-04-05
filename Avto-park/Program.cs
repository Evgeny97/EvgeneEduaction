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
                string answer = Console.ReadLine();
                if (answer == "1")
                {
                    Console.WriteLine("Добавить автомобиль");
                    Console.Write("Введите марку машины ");
                    string Marka = Convert.ToString(Console.ReadLine());
                    Console.Write("Введите количество лошадиных сил ");
                    int EngineCapacity = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Введите год выпуска ");
                    int year = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Ваша машина добавлена");
                    Console.WriteLine("Вернуться назад - 0");
                    // Создаём автомобиль
                }
                else if (answer == "2")
                {
                    Console.WriteLine("Данный автомобиль");
                    Console.WriteLine("Для выхода нажмите - Enter");
                    //      Console.WriteLine("Offroad - tayota 3.5 white 290 200 1300 true");
                    //        Console.WriteLine("Passenger Car - vaz 1.6 black 290 200 1300 true");
                    PassengerCar bmw = new PassengerCar("bmw", (float)1.6, "black", 222,222,222,false);
                    PassengerCar vaz = new PassengerCar("vaz", (float)6.0, "black", 290, 200, 1300, true);
                    Cars.Add(vaz);
         //           Console.WriteLine("Trucks - KAMAZ 4.6 red 160 360 3750 true");
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

                //        PassengerCar vaz = new PassengerCar("vaz", (float)6.0, "black", 290, 200, 1300, true);
                  //      Cars.Add(vaz);
                  //      PassengerCar marka = new PassengerCar("vaz", (float)6.0, "black", 290, 200, 1300, true);
                   //     Cars.Add(marka);

                        //
                        Offroad tayota = new Offroad("tayota", (float)3.5, "white", 290, 250, 1800, true);
                        Cars.Add(tayota);

                        Trucks KAMAZ = new Trucks("KAMAZ", (float)4.6, "red", 160, 360, 3750, true);
                        Cars.Add(KAMAZ);
                        Console.ReadLine();

                        //        Car ap = new Car();
                        //          public Car(string Marka, float EngineCapacity, string Colour, int MaxSpeed, int LuggageSpace, int Сar_weight, bool PresenceOfIgnition)
                        //   static void PrintCar(Car car)
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
