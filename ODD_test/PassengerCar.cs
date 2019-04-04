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

        public void RideToVillage()
        {
            Console.WriteLine("<<Мам, не полезет твоя рассада, мы уже саженец яблони закинули>>");
        }
    }
}
