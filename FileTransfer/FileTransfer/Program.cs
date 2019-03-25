using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTransfer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название файла");
            string File_name = Console.ReadLine();
            byte[] array = new byte[100];
            string text = string.Empty;
            using (FileStream fstream = File.OpenRead(@"TextFile1.txt"))
            {
                int byfer = 0;
                do
                {
                    byfer = fstream.Read(array, 0, array.Length);
                    if (byfer < array.Length)
                    {
                       byte[] bytes = new byte[byfer];
                       for (int i = 0; i < byfer; i++)
                       bytes[i] = array[i];
                       text += Encoding.Default.GetString(bytes);
                    }
                    else
                        text += Encoding.Default.GetString(array);
                } while (byfer > 0);
            }
            Console.WriteLine("Текст из файла: {0}", text);
            string[] separatingChars = { "," };
            string[] numbers = text.Split(separatingChars, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}