using System;

namespace ODD_test
{
    class Program
    {
        static void Main(string[] args)
        {
            PassengerCar Vaz = new PassengerCar(Vaz, 1.6, 58, 50, 58,220, false);
            Console.WriteLine("Марка автомобиля: {0} ", Vaz.Marka);
            Console.WriteLine("Объем двигателя: {0}", Vaz.engineCapacity);
            Console.WriteLine("Текущая скорость: {0}", Vaz.Current_Speed);
            Console.WriteLine("Объем багажного отделения: {0}", Vaz.luggageSpace);
            Console.WriteLine("Текущая нагрузка: {0}", Vaz.currentLoad);
            Console.WriteLine("Максимальная скорость: {0}", Vaz.maxspeed);
            Console.WriteLine("Наличие зажигание: {0}", Vaz.presenceOfIgnition);
            //         Console.WriteLine("<<Мам, не полезет твоя рассада, мы уже саженец яблони закинули>>", Vaz.rideToVillage) ;
            Vaz.getValues();

            Offroad jeep = new Offroad(jeep, 1.6, 58, 350, 58,240, true);
            Console.WriteLine("Марка автомобиля: {0} ", jeep.Marka);
            Console.WriteLine("Объем двигателя: {0}", jeep.engineCapacity);
            Console.WriteLine("Текущая скорость: {0}", jeep.Current_Speed);
            Console.WriteLine("Объем багажного отделения: {0}", jeep.luggageSpace);
            Console.WriteLine("Текущая нагрузка: {0}", jeep.currentLoad);
            Console.WriteLine("Максимальная скорость: {0}", jeep.maxspeed);
            Console.WriteLine("Наличие зажигание: {0}", jeep.presenceOfIgnition);
            //          Console.WriteLine("Я персона вип - вип, у меня есть джип - джип: ", Jeep.doOffroad);
            jeep.getValues();

            Trucks man = new Trucks(man, 4.6, 88, 905 , 88,160, true);
            Console.WriteLine("Марка автомобиля: {0} ", man.Marka);
            Console.WriteLine("Объем двигателя: {0}", man.engineCapacity);
            Console.WriteLine("Текущая скорость: {0}", man.Current_Speed);
            Console.WriteLine("Объем багажного отделения: {0}", man.luggageSpace);
            Console.WriteLine("Текущая нагрузка: {0}", man.currentLoad);
            Console.WriteLine("Наличие зажигание: {0}", man.presenceOfIgnition);
            //      Console.WriteLine("Рагрузка кузова: ", Jeep.try_Download_Item_To_Luggage);
            man.getValues();
            Console.ReadKey();
        }
        
    }
}