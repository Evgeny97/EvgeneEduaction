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
        public PassengerCar(string marka, float engineCapacity, int current_Speed, int Maxspeed, int luggageSpace, int currentLoad, bool presenceOfIgnition)
            : base(marka, engineCapacity, current_Speed, Maxspeed, luggageSpace, currentLoad, presenceOfIgnition)
        {
        }

        public PassengerCar()
        {
        }

        public string marka = "Vaz";
        public new double engineCapacity = 1.6;
        public new int current_Speed = 70;
        public int Maxspeed = 220;
        public new int luggageSpace = 100;
        public int CurrentLoad;
        public new bool PresenceOfIgnition;
        public int EngineCapacity

        {
            get { return EngineCapacity; }
            set { if (value > 0) EngineCapacity = value; }
        }


        //   public new double Speed
        //      {
        //         get { return Speed; }
        //        set { Speed = value + (1.6 * engineCapacity); }
    }
}
