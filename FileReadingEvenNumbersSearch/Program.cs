using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            //  for (int n = 0; n < array.Length; n++) // сортировка
            {
                // Console.Write("{0}-е число: ", n + 1);
                //   array[n] = Int32.Parse(Console.ReadLine());//
                string text = string.Empty;//--
                using (FileStream fstream = File.OpenRead(@"numbers.txt"))
                {
                    int ReadCount = 0;
                    do
                    {
                        ReadCount = fstream.Read(array, 0, array.Length);
                        if(ReadCount < array.Length)
                        {
                            byte[] endBytes = new byte[ReadCount];
                            for (int i = 0; i < ReadCount; i++)
                                endBytes[i] = array[i];
                            text += Encoding.Default.GetString(endBytes);
                        }
                        else
                            text += Encoding.Default.GetString(array);
                    } while (ReadCount != 0);
                }
                Console.WriteLine("Текст из файла: {0}", text);
                string[] separatingChars = { "," };
                string[] numbers = text.Split(separatingChars, StringSplitOptions.RemoveEmptyEntries);
                //  Console.WriteLine("{0} substrings in text:", numbers.Length);
                //сортировка
                // int temp;//
                //   for (int n = 0; n < array.Length - 1; n++)
                // {
                //  for (int j = n + 1; j < array.Length; j++)
                //   {
                //   if (array[n] > array[j])
                //  {
                //      temp = array[n];
                //     array[n] = array[j];
                //     array[n] = temp;
                //      for (int n = 0; n < array.Length; n++)
                //         Console.WriteLine(array[n]);//
                foreach (string number in numbers)
                {
                    if (int.TryParse(number, out int intNum) && intNum % 2 == 1)
                    {
                        int summa = 0;
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            summa += intNum;
                        }
                        Console.WriteLine("\n Сумма всех четных чисел: {0}", summa);

                    }

                }
                Console.ReadLine();                
            }
        }
    }
}





//int n = 0, sum = 0;
//{
//n = Convert.ToInt32(array[i]);
//if (n % 2 == 0)
//sum += n;
//for (int i = 0; i<numbers.Length; i++)

//while (ReadCount != 0)
//{
//ReadCount = fstream.Read(array, 0, array.Length);
//text += Encoding.Default.GetString(array);