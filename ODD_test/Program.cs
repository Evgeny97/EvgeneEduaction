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
        public int massa;        //текущвя нагрузка
        public bool ignition = true;     //наличие зажигание
    }
    public Car(string newMark, string newVolume, int newSpeed, int newLuggage, // конструктор
    int newMassa, double newIgnition)
    {
        mark = newMark;
        volume = newVolume;
        speed = newSpeed;
        luggage = newLuggage;
        massa = newMassa;
        ignition = newIgnition;
    }
    Cars Volvo = new Cars("volvo", 3.2, 260, 200, 2400, true);
    class Program
    {
        public static void Main(string[] args);
        {
        Console.Write("Введите массу автомобиля - ");
            Volvo.massa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Масса автомобиля - {0}тонн(ы)", Volvo.massa);
            }
    Console.Write("Введите марку автомобиля - ");
            Volvo.mark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Марка автомобиля - {0} км", Volvo.mark);

            Console.Write("Введите максимальную скорость автомобиля - ");
            Volvo.speed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Максимальная скорость - {0} км/ч", Volvo.speed);

            Console.ReadKey();
        }
}








                  // марка
                  // объем двигателя
                  // текущая скорость
                  // объем багажного отделения
                  //текущвя нагрузка
                  //наличие зажигание 