using System;

namespace Library_avto_park
{
    public class Offroad : Car
        {

        public Offroad(string marka, float engineCapacity, string colour, int maxspeed, int luggageSpace, int car_weight, bool PresenceOfIgnition)
                : base(marka, engineCapacity, colour, maxspeed, luggageSpace, car_weight, PresenceOfIgnition)
            {

            }
        public void Offroad_jeep()
        {
            Console.WriteLine("tayota");
            Console.WriteLine("3.5");
            Console.WriteLine("black");
            Console.WriteLine("290");
            Console.WriteLine("250");
            Console.WriteLine("1800");
            Console.WriteLine("true");
        }
        }
    }