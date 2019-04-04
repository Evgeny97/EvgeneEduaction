using ODD_Car.Car;
using System;
using System.Collections.Generic;

namespace ODD_test
{
    class Program
    {
        static List<Car> avalibleCars = new List<Car>();

        static void Main(string[] args)
        {
            PassengerCar vaz = new PassengerCar("vaz", (float)1.6, 80, 50, 70, 220, true);
            avalibleCars.Add(vaz);
                //      Console.WriteLine("<<Мам, не полезет твоя рассада, мы уже саженец яблони закинули>>", vaz.rideToVillage) ;

            
            Offroad jeep = new Offroad("jeep", (float)2.0, 0, 350, 85, 240, false);
            avalibleCars.Add(jeep);
     //       Console.WriteLine("Я персона вип - вип, у меня есть джип - джип: ", jeep.doOffroad);

            Trucks man = new Trucks("man", (float)4.6, 88, 150 , 375, 160, true);
            avalibleCars.Add(man);
            for (int i = 0; i < avalibleCars.Count; ++i)
            {
                Car currCar = avalibleCars[i];
                if (currCar is PassengerCar)
                {
                    Console.WriteLine("Легковое авто");
                    PassengerCar pcar = currCar as PassengerCar;
                    pcar.RideToVillage();
                }
                else if (currCar is Offroad)
                {
                    Console.WriteLine("Внедорожник");
                    Offroad offroad = currCar as Offroad;
                    offroad.DoOffroad();
                }
                else if (currCar is Trucks)
                {
                    Console.WriteLine("Грузовик");
                    Trucks trucks = currCar as Trucks;
                    trucks.body_unloading();
                }
                else
                    Console.WriteLine("Не известный тип автомобля");
                PrintCar(currCar);
            }
            //Console.WriteLine("Рагрузка кузова: ", man.try_Download_Item_To_Luggage);
            Console.ReadKey();
        }

        static void PrintCar(Car car)
        {
            Console.WriteLine("\tМарка автомобиля: {0} ", car.Marka);
            Console.WriteLine("\tОбъем двигателя: {0}", car.EngineCapacity);
            Console.WriteLine("\tТекущая скорость: {0}", car.Current_Speed);
            Console.WriteLine("\tОбъем багажного отделения: {0}", car.LuggageSpace);
            Console.WriteLine("\tТекущая нагрузка: {0}", car.CurrentLoad);
            Console.WriteLine("\tМаксимальная скорость: {0}", car.MaxSpeed);
            Console.WriteLine("\tНаличие зажигание: {0}", car.PresenceOfIgnition);
        }

    }
}