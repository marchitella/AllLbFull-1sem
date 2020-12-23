using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13._1
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Задание 2");
            BPD_DiskInfo.GetDriveInfo();
            Console.WriteLine();

            Console.WriteLine("Задание 3");
            BPD_FileInfo.AboutFile("D:/Lb GitHub/Lb12/lb12.txt");
            Console.WriteLine();

            Console.WriteLine("Задание 4");
            BPD_DirInfo.AboutDir("D:/Lb GitHub");
            Console.WriteLine();

            Console.WriteLine("Задание 5");
            BPD_FileManager.FileManager();
            Console.WriteLine();

            Console.WriteLine("Задание 6");
            BPD_FileManager.LogInfo();
            Console.WriteLine();
        }
    }
}
