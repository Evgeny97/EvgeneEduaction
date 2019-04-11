using System;
using System.Collections.Generic;

namespace Library_avto_park
{
    public class Offroad : Cars
        {

        public Offroad(string marka, float engineCapacity, string colour, int year, int classAvto, int luggageSpace, int car_weight, bool PresenceOfIgnition)
                : base(marka, engineCapacity, colour, year, classAvto, luggageSpace, car_weight, PresenceOfIgnition)
            {
            }

        }
    }