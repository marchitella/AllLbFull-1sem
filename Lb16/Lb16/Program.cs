using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab16
{
    class Program
    {
        private static CancellationTokenSource s = new CancellationTokenSource();
        private static CancellationToken token = s.Token;
        public static void Z1()
        {
            int k = 3; // Кол-во операций
            Stopwatch stopwatch = new Stopwatch();   //Cоздаём таймер
            while (k > 0)
            {
                stopwatch.Start();
                Task tk = new Task(Tasks);
                tk.Start();
                Console.WriteLine($"Tk {k}: Id: {tk.Id}, Status: {tk.Status}");

                if (Console.ReadKey().KeyChar == 'm')
                {
                    s.Cancel();    //Метод Cancel() передает запрос на отмену операции у объекта CancellationTokenSource
                }

                tk.Wait();
                stopwatch.Stop();
                Console.WriteLine($"Время ожидания: {stopwatch.Elapsed.TotalMilliseconds}ms");
                stopwatch.Reset();  //Обнуляем таймер
                k--;
            }

        }
       
        public static void Z3()
        {   // Вычисление чисел Фибоначчи
            Task<int> tk1 = new Task<int>(() => Fibonachi(13));

            Task<int> tk2 = new Task<int>(() => Fibonachi(25));

            Task<int> tk3 = new Task<int>(() => Fibonachi(37));

            tk1.Start(); tk2.Start(); tk3.Start();
            tk1.Wait(); tk2.Wait();  tk3.Wait();

            Task task = new Task(() =>
            {
                Console.WriteLine($"Произведение: {tk1.Result * tk2.Result * tk3.Result}");
            });
            task.Start();
            task.Wait();
        }
        public static void Z4()
        {
            Task<int> tk1 = new Task<int>(() => mult(3, 3));
            Task<int> tk2 = new Task<int>(() => mult(4, 4));
            Task<int> tk3 = new Task<int>(() => mult(5, 5));
            
            Task tka = tk1.ContinueWith(t => Rezlt(t.Result)); //ContinueWith для задачи продолжения
            Task tkb = tk2.ContinueWith(t => Rezlt(t.Result));
            Task tkc = tk3.ContinueWith(t => Rezlt(t.Result));
            tk1.Start(); tk2.Start();  tk3.Start();
            tka.Wait(); tkb.Wait(); tkc.Wait();

            Console.WriteLine("Методы GetAwaiter и GetResult");
           
            tk3.ContinueWith(t => Rezlt(t.Result)).GetAwaiter();
            tk2.ContinueWith(t => Rezlt(t.Result)).GetAwaiter().GetResult();

        }
        public static void Z5()
        {
            Random simv1 = new Random();
            int[] massv1 = new int[mas];
            int[] massv2 = new int[mas];
            Console.WriteLine("Работаем с обычным циклов");
            Stopwatch stopWatch = Stopwatch.StartNew();
            for (int j = 0; j < 16; j++)
            {
                for (int i = 0; i < mas; i++)
                {
                    massv2[i] = 5 + 5;
                }
            }
            stopWatch.Stop();
            double msec2 = stopWatch.Elapsed.Milliseconds;
            Console.WriteLine($"speed: {msec2}ms");
            Console.WriteLine("Работаем с Parallel");
            stopWatch.Restart();
            Parallel.For(0, 16, (Count) =>
            {
                Parallel.ForEach(massv1, (el) =>
                {
                    el = 5 + 5;
                });
            });
            stopWatch.Stop();
            double msec1 = stopWatch.Elapsed.Milliseconds;
            Console.WriteLine($"speed: {msec1}ms");


        }
        public static void Z6()
        {
            Parallel.Invoke(Factorial, Factorial);
        }
        public static void Z7()
        {
            Random simv1 = new Random();
            BlockingCollection<int> sklad = new BlockingCollection<int>();
            int x = 0, t = 0;
            for (int post = 0; post < 3; post++)
            {
                t = simv1.Next(100, 400);
                Task.Factory.StartNew(() => {
                    Task.Delay(3000);
                    x++;
                    for (int ii = 0; ii < 3; ii++)
                    {
                        x++;
                        Thread.Sleep(1000);
                        int id = x;
                        sklad.Add(id);
                        Console.WriteLine($"Id товара, который прибыл на склад: {id}");
                    }
                });
            }
            for (int cup = 0; cup < 7; cup++)
            {
                Task consumer = Task.Factory.StartNew(() =>
                {
                    int n;
                    while (!sklad.IsCompleted)
                    {
                        if (sklad.TryTake(out n))
                            Console.WriteLine($"Id товара, который был убран со склада: {n}");
                    }
                });
            }
            Console.ReadKey();
        }
        public static async void Z8()
        {
            await Task.Run(() => Factorial());
            Console.WriteLine("Задача завершилась");
        }
        public static void Tasks()
        {
            var num = new List<uint>();
            for (var i = 2u; i < 1000; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Прервана!");
                    return;
                }
                num.Add(i);
            }

            for (var i = 0; i < num.Count; i++)
            {
                for (var j = 2u; j < 10000; j++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Прервана!");
                        return;
                    }
                    
                    num.Remove(num[i] * j);     //Удаляем кратные числа

                }
            }
        }


        static int Fibonachi(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }

        static void Factorial()
        {
            int result = 1;

            for (int n = 1; n <= 10000; n++)
            {
                result *= n;
            }
            Thread.Sleep(2000);
            Console.WriteLine("Посчитано");
        }

        static int mult(int a, int b) => a * b;
        static void Rezlt(int mult)
        {
            Console.WriteLine($"Произведение: {mult}");
        }


        private const int mas = 100000000;
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------Задание 1-2-----------------------------");
            Z1(); Console.ReadKey();

            Console.WriteLine("-----------------------------Задание 3-----------------------------");
            Z3(); Console.ReadKey();

            Console.WriteLine("-----------------------------Задание 4-----------------------------");
            Z4(); Console.ReadKey();

            Console.WriteLine("-----------------------------Задание 8-----------------------------");
            Z8(); Console.ReadKey();

            Console.WriteLine("-----------------------------Задание 5-----------------------------");
            Z5(); Console.ReadKey();

            Console.WriteLine("-----------------------------Задание 6-----------------------------");
            Z6(); Console.ReadKey();

            Console.WriteLine("-----------------------------Задание 7-----------------------------");
            Z7(); Console.ReadKey();

        }
    }
}