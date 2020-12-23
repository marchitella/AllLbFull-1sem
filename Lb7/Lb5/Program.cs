using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lb7
{
    class Program
    {
        static void Main(string[] args)
        {
            Films film1 = new Films(39,2010,true);            
            Films film2 = null;

            PP PP1 = new PP(film1);
            
            
                try
                {
                    Films film3 = new Films(39, 2021, true);
                }
                catch (YearExeption ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }

                try
                {
                    Films film3 = new Films(110, 2010, true);
                }
                catch (VolumExeption ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }

                try
                {
                    Films film3 = new Films(-3, 2010, true);
                }
                catch (VolumExeption ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }

                try
                {
                    Films film3 = new Films(12, 2023, true);
                }
                catch (YearExeption ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }

                try
                {
                    PP1.Add(film2);
                }
                 catch (YearExeption ex)
                 {
                Console.WriteLine("Ошибка 2 : " + ex.Message);
                 }
                 catch (NullReferenceException ex)
                {
                    Console.WriteLine("Ошибка 1: " + ex.Message);
                }
               
                catch (Exception ex)
                {
                Console.WriteLine("Ошибка 3: " + ex.Message);
                }
            try
           {
                Films film4 = new Films(39, 2030, true);
           }
            catch (Exception ex)
           {
                Console.WriteLine("Исключение: " + ex.Message);
                Console.WriteLine($"{ex.StackTrace}");
           }
            finally
           {
                int ID;
                ID = -10;
                Debug.Assert(ID > 0, "ID должно быть больше нуля");
                Console.WriteLine($"Выполнение программы завершено");
           }
        }

    }
}
