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
        class car
        {
            public class Car
            {
                /// <summary>
                /// марка автомобиля
                /// </summary>
                public string Marka;
                private string EngineCapacity;// объем двигателя
                protected string Speed;//текущая скорость
                private string LuggageSpace;// объем багажного отделения
                private string CurrentLoad;//текущая нагрузка
                protected bool PresenceOfIgnition; //наличие зажигание 

                public Car(string marka, string engineCapacity, string speed, string luggageSpace, string currentLoad)
                {

                    Marka = marka;
                    EngineCapacity = engineCapacity;
                    Speed = speed;
                    LuggageSpace = luggageSpace;
                    CurrentLoad = currentLoad;
                }

                public void StartEngine()
                {
                    PresenceOfIgnition = true;
                    Console.WriteLine("Двигатель запущен");
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
                    Car car = new Car("volvo", "3.2f", "0", "200", "1170");
                    car.Start();
                    car.Stop();
                    car.SpeedUP();
                    car.SlowDown();
                    Console.ReadLine();
                }
                    class trucks : car
                {
                    public trucks(string marka, string engineCapacity, string speed, string luggageSpace, string currentLoad) 
                {
                    Marka = marka;
                    EngineCapacity = engineCapacity;
                    Speed = speed;
                    LuggageSpace = luggageSpace;
                    CurrentLoad = currentLoad;
                }
                trucks man = new trucks("man", "2.0", "0", "2000", "3240");

                }
            }
        }
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
           //         public static void Main()
         //           {
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