using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODD_Car
{
    class Cars
    {
        public string mark; // марка
        public float volume;  // объем двигателя
        public speed // текущая скорость
        public int luggage;   // объем багажного отделения
        public int load;        //текущвя нагрузка
        public bool ignition = true;     //наличие зажигание
    }
    public Car(string newMark, string newVolume, int newSpeed, int newLuggage,
    int newLoad, double newIgnition)
    {
        mark = newMark;
        volume = newVolume;
        speed = newSpeed;
        luggage = newLuggage;
        load = newLoad;
        ignition = newIgnition;
    }
        Cars c = new Cars("volvo", 3.2, 260, 200, 2400, true);
        class Program
    {
        static void Main(string[] args);

            }
}

                  // марка
                  // объем двигателя
                  // текущая скорость
                  // объем багажного отделения
                  //текущвя нагрузка
                  //наличие зажигание 