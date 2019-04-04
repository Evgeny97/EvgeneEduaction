namespace ODD_Car
{
    using System;

    namespace Car
    {
        public class Car
        {
            /// <summary>
            /// Счетчик автомобилей
            /// </summary>
            public static int CarCount { get; private set; }
            /// <summary>
            /// марка автомобиля
            /// </summary>
            public string Marka { get; private set; }
            /// <summary>
            /// Объем двигателя
            /// </summary>
            public float EngineCapacity { get; private set; }
            /// <summary>
            /// Текущая скорость
            /// </summary>
            public int Current_Speed { get; private set; }
            /// <summary>
            /// максимальная скорость
            /// </summary>
            public int MaxSpeed { get; protected set; }
            /// <summary>
            /// объем багажного отделения
            /// </summary>
            public int LuggageSpace { get; private set; }
            /// <summary>
            /// текущая нагрузка
            /// </summary>
            public int CurrentLoad { get; protected set; }
            /// <summary>
            /// наличие зажигание 
            /// </summary>
            public bool PresenceOfIgnition { get; protected set; }

            //        public bool NewPresenceOfIgnition
            //        {
            //          get
            //            {
            //                return Current_Speed > 0;
            //           }
            //     }

//            public void getValues()
      //     {
   //            Console.WriteLine("car Marka is: " + Marka + ", car EngineCapacity is: " + EngineCapacity + ", car Current_Speed is: " + Current_Speed + ",car MaxSpeed is: " + MaxSpeed + ", car LuggageSpace is: " + luggageSpace + ", car CurrentLoad is: " + CurrentLoad + ", car PresenceOfIgnition is: " + PresenceOfIgnition);
  //         }

            public Car(string Marka, float EngineCapacity, int Current_Speed, int MaxSpeed, int LuggageSpace, int CurrentLoad, bool PresenceOfIgnition)
            {
                CarCount++;
                this.Marka = Marka;
                this.EngineCapacity = EngineCapacity;
                this.Current_Speed = Current_Speed;
                this.MaxSpeed = MaxSpeed;
                this.LuggageSpace = LuggageSpace;
                this.CurrentLoad = CurrentLoad;
                this.PresenceOfIgnition = PresenceOfIgnition;
            }

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