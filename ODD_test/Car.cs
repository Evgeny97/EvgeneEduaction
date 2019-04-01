namespace ODD_Car
{
    using System;

    namespace Car
    {
        class Car
        {
            enum Models { Offroad, Truck, PassengerCar }
            /// <summary>
            /// марка автомобиля
            /// </summary>
            public string Marka;
            /// <summary>
            /// объем двигателя
            /// </summary>
            private double EngineCapacity;// объем двигателя
            /// <summary>
            /// текущая скорость
            /// </summary>
            public int Current_Speed; /// текущая скорость
                                      /// <summary>
                                      /// максимальная скорость
                                      /// </summary>
            protected int MaxSpeed;//максимальная скорость
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
            public void SetValues(string Marka, float EngineCapacity, int Current_Speed, int MaxSpeed, int LuggageSpace, int CurrentLoad, bool PresenceOfIgnition)
            {
                this.Marka = Marka;
                this.EngineCapacity = EngineCapacity;
                this.Current_Speed = Current_Speed;
                this.MaxSpeed = MaxSpeed;
                this.luggageSpace = LuggageSpace;
                this.CurrentLoad = CurrentLoad;
                this.PresenceOfIgnition = PresenceOfIgnition;
            }
            public void GetValues()
            {
                Console.WriteLine("car Marka is: " + Marka + ", car EngineCapacity is: " + EngineCapacity + ", car Current_Speed is: " + Current_Speed + ",car MaxSpeed is: " + MaxSpeed + ", car LuggageSpace is: " + luggageSpace + ", car CurrentLoad is: " + CurrentLoad + ", car PresenceOfIgnition is: " + PresenceOfIgnition);
            }

            public Car(string marka, float engineCapacity, int Current_Speed, int maxspeed, int luggageSpace, int currentLoad, bool PresenceOfIgnition)
            {

            }

            public Car()
            {

            }

            public string Mark
            {
                get { return Marka; }
                set { Marka = value; }
            }
            public int engineCapacity // обьем двигателя 
            {
                get { return engineCapacity; }
                set { if (value > 0) engineCapacity = value; }
            }
            public int luggageSpace // обьем багажного отделение
            {
                get { return luggageSpace; }
                set { if (value > 0) luggageSpace = value; }
            }

            public void current_Speed()
            {
                Current_Speed = 0;
            }
            //         public void Currentload()
            //          {
            //             Currentload = 0;
            //          }
            public void StartEngine()//
            {
                PresenceOfIgnition = true;
                Console.WriteLine("Двигатель запущен");
            }
            public int StopEngine //заглушить двигатель
            {
                get { return Current_Speed; }
                set { if (value > 0) PresenceOfIgnition = false; }
            }
            public int SpeedUP // Ускориться
            {
               if (Current_Speed <= 10)
                PresenceOfIgnition
        }
            //public int SlowDown // Замедлиться
            //{
            //    get { return Current_Speed; }
            //    set { if (value < 10) Current_Speed = value; }
            //}

            public void SlowDown()
            {
                if (Current_Speed >= 10)
                    Current_Speed = Current_Speed - 10;
                else
                    Current_Speed = 0;
            }
        //    }
        //    public void add_luggage() //Добавить багаж в багажное отделение
          //  {
                //            CurrentLoad = 
        //    }
            /// ///////////////////////////////
            public int maxspeed  // максимальная скорость
            {
                get { return MaxSpeed; }
                set { if (value > 0) MaxSpeed = value; }
            }
            public int Luggagespace
            {
                get { return luggageSpace; }
                set { if (value > 0) luggageSpace = CurrentLoad; }
            }
            //     public void Start()
            //      {
            //          Console.WriteLine("Машина {0} {0} Завести двигатель", Marka);
            //       }
            //
            //     public void Stop()
            //           {
            //             Console.WriteLine("Машина {0} {0} Заглушить двигатель", Marka);
            //       }

            //            public void SpeedUP()
            //         {
            //              Console.WriteLine("Машина {0} {0} Ускориться", Marka);
            //           }

            //         public void SlowDown()
            //         {
            //           Console.WriteLine("Машина {0} {0} Замедлиться", Marka);
        }
    }
}
            //    static void Main(string[] args)

            //            Car car = new Car("volvo", "3.2", "0", 200, "1170");
            //             Console.WriteLine(car.PresenceOfIgnition);
            //          car.Stop();
            //         car.SpeedUP();
            //         car.SlowDown();
            //         Console.ReadLine();
            //    }
            //      }
            //         Car trucks = new Car("trucks", "3.2");



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