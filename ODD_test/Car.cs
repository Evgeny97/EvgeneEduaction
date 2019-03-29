using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODD_Car
{
    using System;

    namespace Car
    {
        public class Car
        {
            enum Models { Offroad, Truck, PassengerCar }
            /// <summary>
            /// марка автомобиля
            /// </summary>
            public string Marka;
            /// <summary>
            /// объем двигателя
            /// </summary>
            private float EngineCapacity;// объем двигателя
            /// <summary>
            /// текущая скорость
            /// </summary>
            protected int Speed;//текущая скорость
            /// <summary>
            /// объем багажного отделения
            /// </summary>
            private int LuggageSpace;// объем багажного отделения
            /// <summary>
            /// текущая нагрузка
            /// </summary>
            private int CurrentLoad;//текущая нагрузка
            /// <summary>
            /// наличие зажигание 
            /// </summary>
            protected bool PresenceOfIgnition; //наличие зажигание 
            public void SetValues(string Marka, float EngineCapacity, int Speed, int LuggageSpace, int CurrentLoad, bool PresenceOfIgnition)
            {
                this.Marka = Marka;
                this.EngineCapacity = EngineCapacity;
                this.Speed = Speed;
                this.LuggageSpace = LuggageSpace;
                this.CurrentLoad = CurrentLoad;
            }

            public void GetValues()
            {
                Console.WriteLine("car Marka is: " + Marka + ", car Speed is: " + Speed + ", car LuggageSpace is: " + LuggageSpace + ", car CurrentLoad is: " + CurrentLoad);
            }

            public Car(string marka, float engineCapacity, int speed, int luggageSpace, int currentLoad)
            {
                Marka = marka;
                EngineCapacity = engineCapacity;
                Speed = speed;
                LuggageSpace = luggageSpace;
                CurrentLoad = currentLoad;
            }

            public Car()
            {

            }

            public string Mark
            {
                get { return Marka; }
                set { Marka = value; }
            }
            public int EngineCapacity // обьем двигателя 
            {
                get { return EngineCapacity; }
                set { if (value > 0) EngineCapacity = value; }
            }
            public int luggageSpace // обьем 
            {
                get { return luggageSpace; }
                set { if (value > 0) luggageSpace = value; }
            }
            public void StartEngine()//
            {
                PresenceOfIgnition = true;
                Console.WriteLine("Двигатель запущен");
            }

            public void StopEngine() //
            {
                PresenceOfIgnition = false;
                Console.WriteLine("Двигатель выключин");
            }

            public int MaxSpeed  // скорость
            {
                get { return MaxSpeed; }
                set { if (value > 0) MaxSpeed = value; }

            }
            public void Start()
            {
                Console.WriteLine("Машина {0} {0} Завести двигатель", Marka);
            }

            public void Stop()
            {
                Console.WriteLine("Машина {0} {0} Заглушить двигатель", Marka);
            }

            public void SpeedUP()
            {
                Console.WriteLine("Машина {0} {0} Ускориться", Marka);
            }

            public void SlowDown()
            {
                Console.WriteLine("Машина {0} {0} Замедлиться", Marka);
            }


            static void Main(string[] args)
            {
                //            Car car = new Car("volvo", "3.2", "0", 200, "1170");
                //             Console.WriteLine(car.PresenceOfIgnition);
                //          car.Stop();
                //         car.SpeedUP();
                //         car.SlowDown();
                //         Console.ReadLine();
            }
        }
        //         Car trucks = new Car("trucks", "3.2");



        //   class trucks : Car
        //     public trucks(string marka, string engineCapacity, string speed, int luggageSpace, string currentLoad) 
        //     : base(marka,engineCapacity, speed, luggageSpace, currentLoad)
        //trucks man = new trucks("man", "2.0", "0", "2000", "3240");
        //Console.WriteLine();
    }
}


// объем двигателя
//    public int Value
//      {
//         get { return Value; }
//         set { if (value > 0) Value = value; }
//     }
// скорость
//     public int speed
//       {
//           get { return speed; }
//          set { if (value > 0) speed = value; }
//       }
// объем багажного отделения
//     public int LuggageSpace
//   {
//        get { return LuggageSpace; }
//        set { if (value > 0) LuggageSpace = value; }
//      }
//   }

//     class Cars
//       {
//       public static void Main()
//       {
//          Car A = new Car("Volvo");
//        A.Start();
//
// A.Stop();
//      A.SpeedUP();
//A.SlowDown();

// марка
// объем двигателя
// текущая скорость
// объем багажного отделения
//текущвя нагрузка
//наличие зажигание 