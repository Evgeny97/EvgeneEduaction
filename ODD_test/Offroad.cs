using ODD_Car.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODD_test
{
    class Offroad : Car
    {

        public Offroad(string marka, float engineCapacity, int current_Speed, int maxspeed, int luggageSpace, int currentLoad, bool PresenceOfIgnition) 
            : base(marka, engineCapacity, current_Speed, maxspeed, luggageSpace, currentLoad, PresenceOfIgnition)
        {
        }

        public void DoOffroad()
        {
            Console.WriteLine("Я персона вип - вип, у меня есть джип - джип: ");
        }
 //       public string doOffroad { get; set; }
    }
}
