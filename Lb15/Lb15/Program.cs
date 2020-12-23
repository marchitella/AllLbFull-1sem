using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;
using System.Security.Permissions;
using System.Threading;
using System.IO;

namespace Lb15
{
    class Program
        {
         static Mutex mutex = new Mutex();
         static void Main(string[] args)
         {
             Console.WriteLine("Задание 1");
             foreach (Process process in Process.GetProcesses())
             {
                 // выводим id и имя процесса
                 Console.WriteLine($"ID: {process.Id}  Name: {process.ProcessName}");
             }
             Console.ReadKey();
             Console.WriteLine();
             Console.WriteLine("Процесс по ключевому слову Discord");
             Console.WriteLine();
             Process proc = Process.GetProcessesByName("Discord")[0];
             ProcessThreadCollection processThreads = proc.Threads;

             foreach (ProcessThread thread in processThreads)
             {
                 Console.WriteLine($"ThreadId: {thread.Id} StartTime: {thread.StartTime}");
             }

             Console.ReadKey();

             Console.WriteLine("\nЗадание 2");
             Console.WriteLine("Информация о домене:");
             AppDomain domain = AppDomain.CurrentDomain;
             InfoDomainApp(domain);
             Console.WriteLine();
             Assembly[] assemblies = domain.GetAssemblies();
             Console.WriteLine("Сборки:");
             foreach (Assembly asm in assemblies)
             Console.WriteLine(asm.GetName().Name);

             // новый домен приложения
             AppDomain newDomain = AppDomain.CreateDomain("NewDomain");
             string longName = "system, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
             Assembly assem = Assembly.Load(longName);

             Console.WriteLine("\nИнформация о новом домене: ");
             InfoDomainApp(newDomain);
             // Уничтожение домена приложения
             AppDomain.Unload(newDomain);

             Console.ReadKey();
             Console.WriteLine("\nЗадание 3");
             Console.Write("Введите b: ");
             int n = Convert.ToInt32(Console.ReadLine());

             Thread second = new Thread(new ParameterizedThreadStart(Count));
             second.Start(n);
             second.Suspend();
             Console.WriteLine("Поток приостанвлен");
             Console.ReadKey();
             second.Resume();
             
             Console.ReadKey();
             Console.WriteLine("\nЗадание 4");
             Console.WriteLine("Два потока:");
             Console.WriteLine();

             Thread thread1 = new Thread(new ParameterizedThreadStart(CountA));
             thread1.Start(0);
             Thread thread2 = new Thread(new ParameterizedThreadStart(CountA));
             thread2.Start(1);

             Console.ReadKey();
             Console.WriteLine();
             Console.WriteLine("Синхронизация двух потоков: ");
             Console.WriteLine();
             Thread thread3 = new Thread(new ParameterizedThreadStart(CountB));
             thread3.Start(0);
             Thread thread4 = new Thread(new ParameterizedThreadStart(CountB));
             thread4.Start(1);

             Console.ReadKey();
             Console.WriteLine("\nЗадание 5");

             TimerCallback tm = new TimerCallback(CountTime);
             Timer timer = new Timer(tm, null, 0, 3000);
             Console.ReadKey();
         }

         public static void Count(object n)
         {
             int m = Convert.ToInt32(n);
             for (int i = 0; i < m; i++)
             {
                 Console.Write("поток A: ");
                 Console.WriteLine(i);
                 Thread.Sleep(400);
             }
             Thread t = Thread.CurrentThread;
             
             t.Name = "поток A";
             Console.WriteLine();
             Console.WriteLine($"Имя потока: {t.Name}");
             Console.WriteLine($"Статус потока: {t.ThreadState}");
             Console.WriteLine($"Запущен ли поток: {t.IsAlive}");

         }
         public static void CountA(object n)
         {
         int nn = (int)n;
         mutex.WaitOne();
         for (int i = nn; i <= 16; i += 2)
         {
             Console.WriteLine(i);
             Thread.Sleep(300);
         }
         mutex.ReleaseMutex();
         }
         public static void CountB(object n)
         {
             int nn = (int)n;
             for (int i = nn; i <= 16; i += 2)
             {
                 mutex.WaitOne();
                 Console.WriteLine(i);
                 Thread.Sleep(400);
                 mutex.ReleaseMutex();
             }

         }


         public static void CountTime(object obj)
         {
             string[] strmas = new string[3];
             strmas[0] = "нажмите";
             strmas[1] = "любую";
             strmas[2] = "клавишу";

             Random rnd = new Random();
             Console.WriteLine(strmas[rnd.Next(0, 3)]);

         }

         static void InfoDomainApp(AppDomain domain)
         {
             Console.WriteLine($"Имя домена: {domain.FriendlyName}");
             Console.WriteLine($"ID: {domain.Id}");
             Console.WriteLine($"Базовый каталог: {domain.BaseDirectory}");
             Console.WriteLine($"IsDefault: {domain.IsDefaultAppDomain()}");

         }
    }
}