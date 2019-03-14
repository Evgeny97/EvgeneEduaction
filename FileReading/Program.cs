using System;
using System.IO;
using System.Text;

namespace FileReading
{
    internal class Program
    {
        private static byte[] array;

        private static void Main(string[] args)
        {
            Console.WriteLine("Введите название файла");
            string File_name = Console.ReadLine();
            array = new byte[100];
            int ReadCount = 1;
            string text = string.Empty; // = ""  
            using (FileStream fstream = File.OpenRead(@"data.txt"))
            {
                while (ReadCount != 0)
                {
                    ReadCount = fstream.Read(array, 0, array.Length );
                    text += Encoding.Default.GetString(array);
                }
            }
            Console.WriteLine ("Текст из файла: {0}", text);
            Console.ReadLine();
            int sum = SomeFunctions.Sum(5, 10);
        }
    }
}