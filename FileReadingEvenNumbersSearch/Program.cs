using System;
using System.IO;
using System.Text;

namespace FileReadingEvenNumbersSearch
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
            Console.WriteLine(text.Length);
            {
                using (FileStream reader = File.OpenRead(@"numbers.txt"))
                {
                    ReadCount = reader.Read(array, 0, array.Length);
                    text += Encoding.Default.GetString(array);
                    {
                        Console.WriteLine("Текст из файла: {0}", text);
                        {
                            int[] n;
                            foreach (int i in n)
                            {
                                if (i % 2 == 0)
                                {
                                sw.WriteLine(i);
                                }
                                while (line = string.ReadLine())
                                {
                                    ;
                                }
                                Console.WriteLine("- Сумма всех четных чисел");
                                Console.ReadKey();
                            }
                        }
                    }
                }
            }
        }
    }
}