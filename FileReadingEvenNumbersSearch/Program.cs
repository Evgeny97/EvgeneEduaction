using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileReading
{
    internal class Program
    {
        private static readonly IEnumerable<object> numbers;
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
                array = new byte[fstream.Length]; ////считываем файл
                fstream.Read(array, 0, array.Length);
                string textFromFile = Encoding.Default.GetString(array); // декодируем строку в байты
                Console.WriteLine("Текст из файла: {0}", textFromFile);
                string[] separatingChars = { "," };
                System.Console.WriteLine("Original text: '{0}'", text);
                string[] numbers = text.Split(separatingChars, StringSplitOptions.RemoveEmptyEntries);
                System.Console.WriteLine("{0} substrings in text:", numbers.Length);
                foreach (string number in numbers)
                {
                    if (int.TryParse(number, out int intNum) && intNum % 2 == 0)
                    {
                        //sum
                            Console.WriteLine("Сумма всех четных чисел: {0}");
                        }
                   
                }
                Console.ReadKey();
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
                      //for (int i = 0; i<numbers.Length; i++)