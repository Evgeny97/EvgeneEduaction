using System;
using System.Collections.Generic;
using Library_avto_park;

namespace Avto_park
{
    class Program
    {
        static List<Car> engine_сapacity = new List<Car>();

        static void Main(string[] args)
        {

            Console.WriteLine("Выберите, что хотите сделать:");
            Console.WriteLine("1 - Добавить новый автомобиль");
            Console.WriteLine("2 - Проссотреть списк существющих");
            Console.WriteLine("3 - ");
            Console.WriteLine("4 - Сохранить в файл");
            Console.WriteLine("5 - ");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                Console.WriteLine("Добавить автомобиль");
                PassengerCar pcar = currCar as PassengerCar;
                Offroad offroad = currCar as Offroad;
                Trucks trucks = currCar as Trucks;
                
                // Создаём автомобиль
            }
            else if (answer == "2")
            {
                // выводим все в консоль
            }
            else if (answer == "3")
            {
                // сохраням в файл
            }
            else
                Console.WriteLine("Не известная команда");



            PassengerCar Mersedes_bens = new PassengerCar("Mercedes_benz", (float)6.0, "black", 290, 200, 1300, true);
            engine_сapacity.Add(Mersedes_bens);


            Offroad tayota = new Offroad("tayota", (float)3.5, "white", 290, 250, 1800, true);
            engine_сapacity.Add(tayota);

           Trucks KAMAZ = new Trucks("KAMAZ", (float)4.6, "red", 160, 360, 3750, true);
            engine_сapacity.Add(KAMAZ);
     //       for (int i = 0; i < engine_сapacity.Count; ++i)
    //        {
    //            Car currCar = engine_сapacity[i];
     //           if (currCar is PassengerCar)
     //           {
    //                Console.WriteLine("Легковое авто");
    //                PassengerCar pcar = currCar as PassengerCar;
    //                pcar.PassengerCar_Lada();
   //             }
       //         else if (currCar is Offroad)
        //        {
       //             Console.WriteLine("Внедорожник");
        //            Offroad offroad = currCar as Offroad;
       //             offroad.Offroad_jeep();
       //         }
       //         else if (currCar is Trucks)
         //       {
         //           Console.WriteLine("Грузовик");
         //           Trucks trucks = currCar as Trucks;
         //           trucks.Tracks_man();
         //       }
         //       else
             //       Console.WriteLine("Не известный тип автомобля");
             //   PrintCar(currCar);
            }

        }


        static void PrintCar(Car car)
        {
            Console.WriteLine("\tМарка автомобиля: {0} ", car.Marka);
            Console.WriteLine("\tОбъем двигателя: {0}", car.EngineCapacity);
            Console.WriteLine("\tТекущая скорость: {0}", car.Colour);
            Console.WriteLine("\tОбъем багажного отделения: {0}", car.LuggageSpace);
            Console.WriteLine("\tТекущая нагрузка: {0}", car.Сar_weight);
            Console.WriteLine("\tМаксимальная скорость: {0}", car.MaxSpeed);
            Console.WriteLine("\tНаличие зажигание: {0}", car.PresenceOfIgnition);
            Console.ReadLine();
        }

    }
}