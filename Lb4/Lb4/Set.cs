using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Lb4
{
    class Set
    {
        public int?[] Arr { get; set; }
        public Set(params int?[] arr)//params-для неопределенного кол-ва параметр. одного типа
        {
            this.Arr = arr;
        }
        public static bool operator > (Set S1, object obj)// проверка на принадлежность
        {
            if (obj is Set set){
                return set.Arr.Intersect(S1.Arr).SequenceEqual(S1.Arr);
            }
            return false;        
        }
        public static bool operator < (Set S1, object obj)// проверка на подмножество
        {
            if (obj is Set set)
            {
                return S1.Arr.Intersect(set.Arr).SequenceEqual(set.Arr);
            }
            return false;
        }
        public static explicit operator DateTime(Set set)
        {
            string s = "";
            foreach (int x in set.Arr)
            {
                s += x.ToString();
            }
            int value = Convert.ToInt32(s);
            DateTime dateSet = new DateTime();
            dateSet = DateTime.Now;

            return dateSet.AddSeconds(value);
        }
        Owner owner1 = new Owner(1,"Mark","BelSTU");//вложенный объект
        public class Date
        {
            public int Year { get; set; }
            public int Month { get; set; }
            public int Day { get; set; }
            public Date(int year, int month, int day)
            {
                this.Year = year;
                this.Month = month;
                this.Day = day;
            }
            public void Info()
            {
                Console.WriteLine($"year = {Year}, month = {Month}, day = {Day}, ");
            }
        }






    }
}
