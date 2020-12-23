using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb4
{
    class Program
    {
        static void Main(string[] args)
        {
            Set S1 = new Set(1,2,3,4);
            Set S2 = new Set(1,2,3);
            Console.WriteLine(S2 > S1);
            Console.WriteLine(S1 < S2);
            DateTime date1 = (DateTime)S1;
            Console.WriteLine(date1);
            Set.Date date2 = new Set.Date(2020, 11, 6);
            Console.WriteLine("Сумма - " + StatisticOperation.Sum(S1));
            Console.WriteLine("Максимальный элемент - " + StatisticOperation.Max(S1));
            Console.WriteLine("Минимальный элемент - " + StatisticOperation.Min(S1));
            string str = "a72v";
            str.FirstNum();
            Set S3 = new Set(1, -2, -3, 4);

            S3 = S3.DeleteMass();

            foreach (int? a in S3.Arr)
            {
                if (a != null)
                {
                    Console.Write(a + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
