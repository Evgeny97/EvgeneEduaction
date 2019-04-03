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


        public Offroad()
        {
        }

        public Offroad(object jeep, double v1, int v2, int v3, int v4, int v5, bool v6)
        {
        }
        public void DoOffroad()
        {
            throw new NotImplementedException();
        }
        public string doOffroad { get; set; }
    }
}
