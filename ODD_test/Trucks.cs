using ODD_Car.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODD_test
{
    class Trucks : Car
    {



        public Trucks()
        {
        }
        public Trucks(string marka, float engineCapacity, int current_Speed, int maxspeed, int luggageSpace, int currentLoad, bool presenceOfIgnition)
              : base(marka, engineCapacity, current_Speed, maxspeed, luggageSpace, currentLoad, presenceOfIgnition)
        { }

        public Trucks(Trucks man, double v1, int v2, int v3, int v4, int v5, bool v6)
        {
        }
    }
}