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
        { }

        public Trucks()
        {
        }

        public string marka = "man";
        public new double engineCapacity = 3.6;
        public new int current_Speed;
        public new int maxspeed = 150;
        public new int luggageSpace = 400;
        public int currentLoad;
        public new bool PresenceOfIgnition;
        public new int Luggagespace
        {
            get { return luggageSpace; }
            set { if (value > 50) luggageSpace = currentLoad; }
        }
        //      public new bool PresenceOfIgnition;
        //   public new double MaxSpeed
        //    {
        //       get { return maxspeed; }
        //      set { MaxSpeed = value * engineCapacity; }
        //   }
    }
}