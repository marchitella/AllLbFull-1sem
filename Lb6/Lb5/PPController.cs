using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb6
{
    static class PPController
    {
        public static void ShowByYear(PP pp, int Year)
        {
            foreach (TelevisionProgram tp in pp)
            {
                if(tp.Year == Year)
                {
                    tp.Status();
                }
            }
        }
        public static void AdCounter(PP pp)
        {
            int _adCounter = 0;
            foreach (TelevisionProgram tp in pp)
            {
                if (tp.ToString() == "Объект типа Lb6.Advertising")
                {
                    _adCounter++;
                }
            }
            Console.WriteLine($"Кол-во рекламных роликов = {_adCounter}");
        }
    }
}
