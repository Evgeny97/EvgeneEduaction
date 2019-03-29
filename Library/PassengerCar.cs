using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
     class PassengerCar : Car
    {
        PassengerCar cars = new PassengerCar();
        public PassengerCar(string marka, string engineCapacity, string speed, int luggageSpace, string currentLoad) : base(marka, engineCapacity, speed, luggageSpace, currentLoad)
        {
        }

        public void debag()
        {
        }
    }
}
