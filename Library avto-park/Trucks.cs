using System;

namespace Library_avto_park
{
    public class Trucks : Car
    {


        public Trucks(string marka, float engineCapacity, string colour, int maxspeed, int luggageSpace, int car_weight, bool PresenceOfIgnition)
            : base(marka, engineCapacity, colour, maxspeed, luggageSpace, car_weight, PresenceOfIgnition)
        {

        }
        public void Tracks_man()
        {
            Console.WriteLine("Man");
            Console.WriteLine("5.0");
            Console.WriteLine("red");
            Console.WriteLine("290");
            Console.WriteLine("180");
            Console.WriteLine("1950");
            Console.WriteLine("true");
        }
    }
}
