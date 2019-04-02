﻿using ODD_Car.Car;
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
        public new string Marka = "Vaz";

        public int current_Speed = 10;
        public new double engineCapacity = 2.4;
        public new int Maxspeed = 290;
        public new int luggageSpace = 150;
        public int CurrentLoad = 30;
        public new bool PresenceOfIgnition;
        public new bool Try_Download_Item_To_Luggage;
        public new string Download_luggage_space;


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
    }
}
