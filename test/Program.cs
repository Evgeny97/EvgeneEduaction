using System;
using System.IO;
using System.Xml.Serialization;

namespace Car
{
    [Serializable]
    public class Car//объявление класса
    {
        public string Marka; //марка 
        public string Cvet; //цвет 
        public string Model; //модель 
        public string Vypusk; //год    
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car avto = new Car(); //объявляем avto экземпляром класса
            Console.WriteLine("Введите данные автомобиля");
            Console.Write("Марка: ");
            avto.Marka = Console.ReadLine(); //считывает марку авто
            Console.Write("Модель: ");
            avto.Model = Console.ReadLine(); //считывает модель авто
            Console.Write("Цвет: ");
            avto.Cvet = Console.ReadLine(); //считывает цвет авто
            Console.Write("Год выпуска: ");
            avto.Vypusk = Console.ReadLine(); //считывает год выпуска авто

            //Запись в файл
            StreamWriter writer = new StreamWriter("text.txt");
            XmlSerializer serializer = new XmlSerializer(typeof(Car));
            serializer.Serialize(writer, avto);
            writer.Close();

            //Чтение из файла
            Stream streamout = new FileStream("d:\\text.txt", FileMode.Open, FileAccess.Read);
            XmlSerializer xml = new XmlSerializer(typeof(Car));
            avto = (Car)xml.Deserialize(streamout);
            streamout.Close();

            Console.WriteLine("Марка  " + "Модель  " + "Цвет  " + "Год выпуска  ");
            Console.WriteLine(avto.Marka + "    " + avto.Model + "    " + avto.Cvet + "    " + avto.Vypusk);
        }
    }
}