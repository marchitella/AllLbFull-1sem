using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb11
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine("Задание 1");
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            string[] Months = { "June", "July", "August", "December", "January", "February", "March", "April", "May", "September", "October", "November" };
            Console.WriteLine("\nВыбор месяцев по длине названия n = ");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            var nLengthMonths = from i in Months
                                where i.Length == n
                                select i;
            Console.WriteLine($"\nМесяца с длиной названия {n} символов");
            foreach (string s in nLengthMonths)
                Console.WriteLine(s);

            Console.WriteLine("\nЛетние и зимние месяцы:");
            var SummerAndWinter = Months.Take(6);
            foreach (string s in SummerAndWinter)
                Console.WriteLine(s);

            Console.WriteLine("\nВ алфавитном порядке:");
            var AlphabetOrder = from i in Months
                                orderby i
                                select i;
            foreach (string s in AlphabetOrder)
                Console.WriteLine(s);

            Console.WriteLine("\nСодержит 'u' и длина >= 4:");
            var hasU = from i in Months
                       where i.Contains("u")
                       where i.Length >= 4
                       select i;
            foreach (string s in hasU)
                Console.WriteLine(s);
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine("\nЗадания 2 и 3");
            Console.WriteLine("------------------------------------------------------------------------------------------------");

            List<Abonents> abonents = new List<Abonents> {
                new Abonents(false,111,false, "Марк", "Кулешов"),
                new Abonents(false,300,true, "Павел", "Бондарович"),
                new Abonents(true,340,false, "Влад", "Беринчик"),
                new Abonents(true,0,true, "Рыгор", "Матулис"),
                new Abonents(false,900,true, "Гриша", "Булгак"),
                new Abonents(true,746,true, "Настюшa", "Гиль"),
                new Abonents(true,7418,false, "Татьяна", "Цягунович"),
                new Abonents(false,312,false, "Лиза", "Кашуба"),
                new Abonents(true,523,false, "Марк", "Степанюк"),
                new Abonents(true,721,false, "Максим", "Друщиц")
            };

            Console.WriteLine("\nВремя внутригородских разговоров превышает норму: ");
            var inCity = from a in abonents
                         where a.inCityCalls == true
                         select a;
            foreach (Abonents ai in inCity)
                ai.info();

            Console.WriteLine("\nПользовались междугородней связью: ");
            var outCity = from a in abonents
                          where a.outCityCalls == true
                          select a;
            foreach (Abonents ai in outCity)
                ai.info();

            Console.WriteLine("\nУкажите кол-во дебета:");
            int newDebet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Абоненты кол-вом дебета больше {newDebet}");
            var debet = from a in abonents
                        where a.Debet >= newDebet
                        select a;
            foreach (Abonents ai in debet)
                ai.info();

            Console.WriteLine("\nМаксимальный абонент по дебету:");
            var max = from a in abonents
                      orderby a.Debet descending
                      select a;
            max.First().info();

            Console.WriteLine("\nАбоненты по фамилии:");
            var orderedBySurn = from a in abonents
                                orderby a.Fam
                                select a;
            foreach (Abonents ai in orderedBySurn)
                ai.info();

            Console.WriteLine("\nЗадание 4");
            Console.WriteLine("Своя выборка:");
            var Own = (from a in abonents where a.Debet >= 300 where a.inCityCalls == true orderby a.Fam select a).Skip(1);
            foreach (Abonents ai in Own)
                ai.info();

            Console.WriteLine("\nTask5");
            Console.WriteLine("Использование внутригородских разговоров за последние 3 дня:");
            List<Spam> spam = new List<Spam> {
                new Spam(true, 01),
                new Spam(false, 02)
            };
            var result = from ai in abonents
                         join p in spam on ai.inCityCalls equals p.inCityCalls
                         select new { Name = ai.Name, Fam = ai.Fam, Debet = ai.Debet, SpamId = p.SpamId };
            foreach (var item in result)
                Console.WriteLine($"id{item.SpamId} - {item.Fam} {item.Name} debet = {item.Debet}");





            Console.WriteLine("--------------------------------------------------------------------------------------");
            //Sum Min Max Count Average
            int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
            int size = (from i in numbers where i > 10 && i < 70 select i).Count();
            Console.WriteLine($"Кол-во чисел удовлетворяющим условию: {size}");


            IEnumerable<int> ints = Enumerable.Range(1, 100);
            int sum = ints.Sum();
            Console.WriteLine("Сумма чисел от 1 до 100: " + sum);

            int[] nums = { 34, 578, 200, 9, 72, 1399 };
            int min = nums.Min(); 
            int maxx = nums.Max();
            Console.WriteLine($"Минимальное значение: {min}");
            Console.WriteLine($"Максимальное значение: {maxx}");
            
            IEnumerable<int> numss = Enumerable.Range(1, 10);
            Console.WriteLine("Последовательность чисел: \n");

            foreach (int i in numss)
                Console.Write(i);

            double average = numss.Average();
            Console.WriteLine("\n\nСреднее арифметическое: " + average);

        }
    }
}
