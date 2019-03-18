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
            using (FileStream fstream = File.OpenRead(@"numbers.txt"))
            {
                while (ReadCount != 0)
                    ReadCount = fstream.Read(array, 0, array.Length);
                text += Encoding.Default.GetString(array);
                {
                    fstream.Seek(-40, SeekOrigin.End); //передвигаем указатель
                    fstream.Seek(0, SeekOrigin.Begin); //передвигаем указатель
                    array = new byte[fstream.Length]; ////считываем файл
                    fstream.Read(array, 0, array.Length);
                    string textFromFile = Encoding.Default.GetString(array); // декодируем строку в байты
                    Console.WriteLine("Текст из файла: {0}", textFromFile);
                    {
                        int a = 0;
                        for (int i = 0; i < text.Length; i++)
                            if (text[i] == ',') a++;
                        Console.WriteLine();
                        int n = 0;
                        int m = 0;
                        for (int i = n; i <= m; i++)
                        {
                            if (i % 2 == 0)
                                Console.WriteLine(i + "Сумма всех четных чисел:{0}");
                            Console.ReadKey();
                        }
                    }
                }
            }
        }
    }
}

//int n = 0, sum = 0;
//for (int i = 0; i<array.Length; i++)
//{
//n = Convert.ToInt32(array[i]);
//if (n % 2 == 0)
//sum += n;