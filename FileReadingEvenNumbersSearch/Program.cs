using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReadingEvenNumbersSearch
{
    class Program
    {
        static byte[] array;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите название файла");
            string File_name = Console.ReadLine();
            array = new byte[100];
            int ReadCount = 1;
            int i = 0;
            int n = 0;
            string text = string.Empty;
            using (FileStream fstream = File.OpenRead(@"numbers.txt"))
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == ',')
                    while (i < n)
                    {
                        if (i % 2 != 0)
                        {
                         ReadCount = fstream.Read(array, 0, array.Length);
                         text += Encoding.Default.GetString(array);
                        }
                    }
                }
                Console.WriteLine("Текст из файла: {0}", i);
                ++i;
                Console.ReadLine();
            }
        }
    }
}