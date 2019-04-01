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

        public string marka = "Jeep";
        public new int current_Speed ;
        public new double engineCapacity = 2.4;
        public int Maxspeed = 290;
        public new int luggageSpace = 150;
        public int currentLoad;
        public new bool PresenceOfIgnition;

        public new double MaxSpeed
        {
            get { return current_Speed * engineCapacity; }
            set { MaxSpeed = value; }
        }
        public new int Current_Speed
        {
            get { return current_Speed; }
            set { if (value > 0) Maxspeed = value; }
        }
    //    public int currentLOad
   //     {
    //        get { return currentLoad;  }
    //        set { if (value > 0) currentLoad = value; }
        }
    }
