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
        public int current_Speed = 100;
        public new int Maxspeed = 150;
        public new int luggageSpace = 400;
        public int currentLoad = 50;
        public new bool PresenceOfIgnition;
        public new bool Try_Download_Item_To_Luggage;
        public new string Download_luggage_space;


        public new double MaxSpeed
            {
             get { return base.Maxspeed; }
             set { MaxSpeed = value * engineCapacity; }
           }
    }
}