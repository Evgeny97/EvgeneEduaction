namespace ODD_Car
{
    using System;

    namespace Car
    {
        enum Models { Offroad, PassengerCar, Trucks}
        class Car
        {
            /// <summary>
            /// марка автомобиля
            /// </summary>
            public string Marka;
            /// <summary>
            /// Объем двигателя
            /// </summary>
            private float EngineCapacity;
            /// <summary>
            /// Текущая скорость
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

            //        public bool NewPresenceOfIgnition
            //        {
            //          get
            //            {
            //                return Current_Speed > 0;
            //           }
            //     }
            public Models model;

            public void getValues()
           {
               Console.WriteLine("car Marka is: " + Marka + ", car EngineCapacity is: " + EngineCapacity + ", car Current_Speed is: " + Current_Speed + ",car MaxSpeed is: " + MaxSpeed + ", car LuggageSpace is: " + luggageSpace + ", car CurrentLoad is: " + CurrentLoad + ", car PresenceOfIgnition is: " + PresenceOfIgnition);
           }

            public Car(string Marka, float EngineCapacity, int Current_Speed, int MaxSpeed, int LuggageSpace, int CurrentLoad, bool PresenceOfIgnition)
            {
                this.Marka = Marka;
                this.EngineCapacity = EngineCapacity;
                this.Current_Speed = Current_Speed;
                this.MaxSpeed = MaxSpeed;
                this.LuggageSpace = LuggageSpace;
                this.CurrentLoad = CurrentLoad;
                this.PresenceOfIgnition = presenceOfIgnition;
            }

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
            
            public Car()
            {
                
            }
            
            /// <summary>
            /// Обьем двигателя
            /// </summary>
            public double engineCapacity { get; set; }
            /// <summary>
            /// Текущая скорость
            /// </summary>
            public int currentLoad { get; set; }
            /// <summary>
            /// объем багажного отделения
            /// </summary>
            public int luggageSpace { get; set; }
            /// <summary>
            /// Максимальная Скорость
            /// </summary>
            public int maxspeed { get; set; }
            /// <summary>
            /// Наличие зажигание
            /// </summary>
            public bool presenceOfIgnition { get; set; }


            //                                                    //
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
                {
                    return false;
                }

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

            public bool try_Download_Item_To_Luggage { get; set; }

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