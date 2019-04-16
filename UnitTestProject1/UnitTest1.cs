using System;
using System.IO;
using System.Xml.Serialization;

namespace Car
{
    [Serializable]
    public class Car//���������� ������
    {
        public string Marka; //����� 
        public string Cvet; //���� 
        public string Model; //������ 
        public string Vypusk; //���    
    }

    class Program
    {
        static void Main()
        {
            Car avto = new Car(); //��������� avto ����������� ������
            Console.WriteLine("������� ������ ����������");
            Console.Write("�����: ");
            avto.Marka = Console.ReadLine(); //��������� ����� ����
            Console.Write("������: ");
            avto.Model = Console.ReadLine(); //��������� ������ ����
            Console.Write("����: ");
            avto.Cvet = Console.ReadLine(); //��������� ���� ����
            Console.Write("��� �������: ");
            avto.Vypusk = Console.ReadLine(); //��������� ��� ������� ����

            //������ � ����
            StreamWriter writer = new StreamWriter("text.txt");
            XmlSerializer serializer = new XmlSerializer(typeof(Car));
            serializer.Serialize(writer, avto);
            writer.Close();

            //������ �� �����
            Stream streamout = new FileStream("d:\\text.txt", FileMode.Open, FileAccess.Read);
            XmlSerializer xml = new XmlSerializer(typeof(Car));
            avto = (Car)xml.Deserialize(streamout);
            streamout.Close();

            Console.WriteLine("�����  " + "������  " + "����  " + "��� �������  ");
            Console.WriteLine(avto.Marka + "    " + avto.Model + "    " + avto.Cvet + "    " + avto.Vypusk);
        }
    }
}