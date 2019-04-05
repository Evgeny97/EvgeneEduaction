using System;
using System.Collections.Generic;

namespace Library_avto_park
{
    public class Trucks : Car
    {


        public Trucks(string marka, float engineCapacity, string colour, int maxspeed, int luggageSpace, int car_weight, bool PresenceOfIgnition)
            : base(marka, engineCapacity, colour, maxspeed, luggageSpace, car_weight, PresenceOfIgnition)
        {

        }

    }
}
