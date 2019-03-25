using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTransfer
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirName = "C:\\Users\\user\\Downloads\\user.txt";
            string dirName = "C:\\";
 
            if (Directory.Exists(dirName))
            {
             Console.WriteLine("Подкаталоги:");
             string[] dirs = Directory.GetDirectories(dirName);
               foreach (string s in dirs)
             {
               Console.WriteLine(s);
               }
               Console.WriteLine();
               Console.WriteLine("user:");
                string[] files = Directory.GetFiles(dirName);
               foreach (string s in files)
               {
               Console.WriteLine(s);
              }
}
        }
    }
