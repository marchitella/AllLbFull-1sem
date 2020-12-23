using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine();
            Afisha Af1;
            Af1 = Afisha.Venom;
            Console.WriteLine(Af1+"="+(byte)Af1);

            Afisha Af2;
            Af2 = Afisha.SpiderMan;
            Console.WriteLine(Af2 + "=" + (byte)Af2);

            Afisha Af3;
            Af3 = Afisha.IronMan;
            Console.WriteLine(Af3 + "=" + (byte)Af3);

            FilmInfo FI = new FilmInfo(90,7);
            Console.WriteLine($"Длительность: {FI.duration}");
            Console.WriteLine($"Стоимость: {FI.ticketPrice}");

            Console.WriteLine();
            Console.WriteLine("Задание 3");
           
            Films film1 = new Films(43, 2010, true);
            Films film2 = new Films(21, 2012, true);
            News news1 = new News(0, 2008, false);
            News news2 = new News(5, 2009, true);
            Advertising ad1 = new Advertising(5, 2019, true);
            PP PP1 = new PP(film1);
            PP1.Add(film2);
            PP1.Add(news1);
            PP1.Add(news2);
            PP1.Show();

            Console.WriteLine();
            PP1.DeleteLast();
            PP1.Show();

            Console.WriteLine();
            PP1.Delete(1);
            PP1.Show();

            Console.WriteLine("Задание 4");
            PP PP2 = new PP(film1, film2, news1, news2, ad1);
            PP2.Show();

            Console.WriteLine("Программы 2010 года:");
            PPController.ShowByYear(PP2,2010);

            PPController.AdCounter(PP2);

            Console.WriteLine("\nПолиморфизм");

            Overload ov1 = new Overload();
            ov1.DisplayOverload(100);
            ov1.DisplayOverload("Hello");
            ov1.DisplayOverload("hello", 100);

            NormalCar car1 = new NormalCar();
            ElectricCar car2 = new ElectricCar();
            car1.refuel();
            car2.refuel();
        }

    }
}
