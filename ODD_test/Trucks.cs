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
        public Trucks(string marka, float engineCapacity, int current_Speed, int maxspeed, int luggageSpace, int currentLoad, bool presenceOfIgnition)
              : base(marka, engineCapacity, current_Speed, maxspeed, luggageSpace, currentLoad, presenceOfIgnition)
        {

        }

        public void body_unloading()
        {
            Console.WriteLine("<<разгрузка кузова>>");
        }
    }
}