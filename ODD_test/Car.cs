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
            private double EngineCapacity;
            /// <summary>
            /// текущая скорость
            /// </summary>
            public int Current_Speed;
            /// <summary>
            /// максимальная скорость
            /// </summary>
            protected int MaxSpeed;
            /// <summary>
            /// объем багажного отделения
            /// </summary>
            private int LuggageSpace;
            /// <summary>
            /// текущая нагрузка
            /// </summary>
            private int CurrentLoad;
            /// <summary>
            /// наличие зажигание 
            /// </summary>
            protected bool PresenceOfIgnition;

            public void SetValues(string Marka, float EngineCapacity, int Current_Speed, int MaxSpeed, int LuggageSpace, int CurrentLoad, bool PresenceOfIgnition)
            {
                this.Marka = Marka;
                this.EngineCapacity = EngineCapacity;
                this.Current_Speed = Current_Speed;
                this.MaxSpeed = MaxSpeed;
                this.LuggageSpace = LuggageSpace;
                this.CurrentLoad = CurrentLoad;
                this.PresenceOfIgnition = PresenceOfIgnition;
            }
            public void GetValues()
            {
                Console.WriteLine("car Marka is: " + Marka + ", car EngineCapacity is: " + EngineCapacity + ", car Current_Speed is: " + Current_Speed + ",car MaxSpeed is: " + MaxSpeed + ", car LuggageSpace is: " + luggageSpace + ", car CurrentLoad is: " + CurrentLoad + ", car PresenceOfIgnition is: " + PresenceOfIgnition);
            }

            public Car(string marka, float engineCapacity, int current_speed, int maxspeed, int luggageSpace, int currentLoad, bool PresenceOfIgnition)
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
            public int Maxspeed  // максимальная скорость
            {
                get { return MaxSpeed; }
                set { if (value > 0) MaxSpeed = value; }
            }

            public void StartEngine()//Запустить двигатель
            {
                PresenceOfIgnition = true;
                Console.WriteLine("Двигатель запущен");
            }
            public void StopEngine() // Заглушить двигатель
            {
                    Current_Speed = Current_Speed - 0;
                    PresenceOfIgnition = false;
                Console.WriteLine("Заглушить двигатель");
            }
            public void SpeedUP() //Ускориться
            {
                PresenceOfIgnition = true;
                Current_Speed = Current_Speed - 10;
            }
            public void SlowDown() //Замедлиться 
            {
                if (Current_Speed >= 10)
                    Current_Speed = Current_Speed - 10;
                else
                    Current_Speed = 0;
            }

            protected bool Try_Download_Item_To_Luggage(int itemSize)
            {
                if (itemSize > LuggageSpace - CurrentLoad)
                    return false;
                CurrentLoad += itemSize;
                return true;
            }

            public string Download_luggage_space(int size)// загрузить багажное отделение
            {
                //return ((question) ? true : false)
                return Try_Download_Item_To_Luggage(size)
                    ? "погружено"
                    : "Багажник полон";
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





// объем багажного отделения
//     public int LuggageSpace
//   {
//        get { return LuggageSpace; }
//        set { if (value > 0) LuggageSpace = value; }
//      }
//   }