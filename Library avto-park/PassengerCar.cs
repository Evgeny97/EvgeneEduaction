using System;
using Library_avto_park;

namespace Library_avto_park
{
   public class PassengerCar : Car
        {

        public PassengerCar(string marka, float engineCapacity, string colour, int maxspeed, int luggageSpace, int car_weight, bool PresenceOfIgnition)
                : base(marka, engineCapacity, colour, maxspeed, luggageSpace, car_weight, PresenceOfIgnition)
            {
            }
        public void PassengerCar_Lada()
        {
            Console.WriteLine("Lada");
            Console.WriteLine("1.6");
            Console.WriteLine("white");
            Console.WriteLine("220");
            Console.WriteLine("150");
            Console.WriteLine("950");
            Console.WriteLine("true");
        }
    }
}
