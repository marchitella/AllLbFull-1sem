using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb4
{
    static class StatisticOperation
    {
        public static int Sum(Set A)
        {
            int sum = 0;
            foreach (int a in A.Arr)
            {
                sum += a;
            }
            return sum;
        }
        public static int Max(Set A)
        {
            int max = (int)A.Arr[0];
            foreach (int a in A.Arr)
            {
                if (a > max)
                {
                    max = a;
                }
            }
            return max;
        }
        public static int Min(Set A)
        {
            int min = (int)A.Arr[0];
            foreach (int a in A.Arr)
            {
                if (a < min)
                {
                    min = a;
                }
            }
            return min;
        }
        public static string FirstNum(this string str)
        {
            char[] num = { '1','2','3','4','5','6','7','8','9','0' };
            char firstNum;
            foreach (char a in str)
            {
                foreach (int b in num)
                {
                    if (a == b)
                    {
                        firstNum = a;
                        return firstNum.ToString();
                    }
                }
            }
            return "Нет цифр в строке";
        }        
        public static Set DeleteMass(this Set S1)
        {

            for (int i = 0; i < S1.Arr.Length; i++)
            {
                if (S1.Arr[i]>0)
                {
                   S1.Arr[i] = null;
                }
            }
            return S1;
        }


    }
}
