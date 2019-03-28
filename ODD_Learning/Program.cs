using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODD_Learning
{
    namespace CarClass
    {
        //Класс Car
        class Car
        {
            //Поля
            private int maxSpeed;
            private string mark;

            //Свойства
            public int MaxSpeed
            {
                get
                { return maxSpeed; }
                set
                { maxSpeed = value; }
            }
            public string Mark
            {
                get
                { return mark; }
                set
                { mark = value; }
            }

            //Конструктор класса Car
            public Car(int maxSpeed, string mark)
            {
                this.maxSpeed = maxSpeed;
                this.mark = mark;
            }
        }
    }
}