using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Cars_1_
{
    class car
    {
        public string Marka = 4;
        private string EngineCapacity;// объем двигателя
        protected string Speed;//текущая скорость
        private string LuggageSpace;// объем багажного отделения
        private string CurrentLoad;//текущая нагрузка
        protected bool PresenceOfIgnition; //наличие зажигание 

        public void setValues(string EngineCapacity, string Speed, string LuggageSpace, string CurrentLoad, bool PresenceOfIgnition)
        {
            Marka = marka;
            EngineCapacity = engineCapacity;
            Speed = speed;
            LuggageSpace = luggageSpace;
            CurrentLoad = currentLoad;
            public void getValues () {
                Console.WriteLine("car speed is: " + Marka + ",car is enEngineCapacity" + EngineCapacity);
        }
    }

        class MainClass
        public static void Main(string[] args)
            car audi = new car();
            Console.WriteLine();

          //  audi.setValues(0, true);
     //       audi.getValues();

            car volvo = new car();
            volvo.Marka = 6;
            volvo.setValues (159.6F,false);
            volvo.getValues ();
            Console.WriteLine();
        }
    }
}
        