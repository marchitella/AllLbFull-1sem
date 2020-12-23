using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 4
            Films film1 = new Films(10);
            film1.turnOn();
            film1.VolumeUp();
            film1.VolumeDown();
            //Задание 5
            Console.WriteLine("\n Задание 5");
            Films film2 = new Films(35);
            if (film2 is TelevisionProgram)
                Console.WriteLine("Объект film2 принадлежит классу TelevisionProgram");
            else
                Console.WriteLine("Объект film2 не принадлежит классу TelevisionProgram");

            if(film2 is ITVControlable)
                Console.WriteLine("Объект film2 принадлежит интерфейсу ITVControlable");
            else
                Console.WriteLine("Объект film2 не принадлежит интерфейсу ITVControlable");


            Films film3 = new Films(10);
            if (film3 is Multfilm)//Проверка на принадлежность.
            {
                Multfilm mt = film3 as Multfilm;//Приведение типов. 
            }

            Console.WriteLine(film3.ToString());
            Multfilm mult1 = new Multfilm(15);
            ArtFilm art1 = new ArtFilm(25);
             
            Printer printer = new Printer();
            Films[] Films = new Films[] { mult1, art1 };
            foreach (var item in Films)
            {
                printer.IAmPrinting(item);
            }

        }
    }
}
