using System;

namespace ODD_test
{
    class Program
    {
        static void Main(string[] args)
        {
            PassengerCar Vaz = new PassengerCar();
            Console.WriteLine("Текущая скорость Vaz (km/h): {0} ", Vaz.Current_Speed);
            Console.WriteLine("Максимальная скорость: {0} km/h", Vaz.Maxspeed);
            Console.WriteLine("Объем двигателя: {0}", Vaz.engineCapacity);
            Console.WriteLine("объем багажного отделения: {0}", Vaz.luggageSpace);
            Console.WriteLine("Текущая нагрузка: {0}", Vaz.CurrentLoad);
            Console.WriteLine("Наличие зажигание: {0}", Vaz.PresenceOfIgnition);
            Console.WriteLine("Мам, не полезет твоя рассада, мы уже саженец яблони закинули.");
           

            Offroad Jeep = new Offroad();
            Console.WriteLine("Текущая скорость Jeep (km/h): {0} ", Jeep.Current_Speed);
            Console.WriteLine("Максимальная скорость: {0} km/h", Jeep.MaxSpeed);
            Console.WriteLine("Объем двигателя: {0}", Jeep.engineCapacity);
            Console.WriteLine("Объем багажного отделения: {0}", Jeep.luggageSpace);
            Console.WriteLine("Текущая нагрузка: {0}", Jeep.currentLoad);
            Console.WriteLine("Наличие зажигание: {0}", Jeep.PresenceOfIgnition);
            Console.WriteLine("Я персона вип-вип,у меня есть джип-джип.");


            Trucks man = new Trucks();
            Console.WriteLine("Текущая скорость man (km/h):{0} ", man.Current_Speed);
            Console.WriteLine("Максимальная скорость: {0} km/h", man.maxspeed);
            Console.WriteLine("Объем двигателя: {0}", man.engineCapacity);
            Console.WriteLine("Объем багажного отделения: {0}", man.luggageSpace);
            Console.WriteLine("Текущая нагрузка: {0}", man.currentLoad);
            Console.WriteLine("Наличие зажигание: {0}", man.PresenceOfIgnition);
            Console.WriteLine("Разгрузка кузова.");
            Console.ReadKey();
        }
        
    }
}