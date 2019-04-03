using ODD_Car.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODD_test
{
    class PassengerCar : Car
    {

        public PassengerCar(string marka, float engineCapacity, int current_Speed, int maxspeed, int LuggageSpace, int currentLoad, bool PresenceOfIgnition)
            : base(marka, engineCapacity, current_Speed, maxspeed, LuggageSpace, currentLoad, PresenceOfIgnition)
        {
        }


        public PassengerCar()
        {
        }

        public PassengerCar(object vaz, double v1, int v2, int v3, int v4, int v5, bool v6)
        {
        }

        public void RideToVillage()
        {
            throw new NotImplementedException();
        }
        public string rideToVillage { get; set; }
    }
}
