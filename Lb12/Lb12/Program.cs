using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nЗадание 1");
            Abonents pass1 = new Abonents();
            Type type1 = pass1.GetType();
            Console.WriteLine($"\nТип: {type1}");

            Console.WriteLine($"\n{type1} Сборка :");
            Reflector.AssemblyName(pass1);  

            Console.WriteLine($"\n{type1} Методы:");
            Reflector.Methods(pass1);

            Console.WriteLine($"\n{type1} Поля:");
            Reflector.Fields(pass1);

            Console.WriteLine($"\n{type1} Свойства:");
            Reflector.Properties(pass1);

            Console.WriteLine($"\n{type1} Конструкторы:");
            Reflector.PublicConstructors(pass1);

            Console.WriteLine($"\n{type1} Интерфейсы:");
            Reflector.Interfaces(pass1);

            string p = "Int32";
            Console.WriteLine($"\n{type1} Методы с параметром {p}:");
            Reflector.MethodsByParametr(pass1, p);

            Console.WriteLine($"\nВызывыем метод:");
            Reflector.Invoke(pass1, "Abonentdolg", Reflector.ParamsGenerater("Lb12.Abonents", "Abonentdolg"));

            Console.WriteLine($"\nВызывыем метод:");
            Reflector.Invoke(pass1, "Abonentdolg", Reflector.FileRead("Lb12.Abonents", "Abonentdolg"));

            Phone<int, string> Abonents1 = new Phone<int, string>(2, "Abonent1");
            Type type2 = Abonents1.GetType();
            Console.WriteLine($"\nТип: {type2}");

            Console.WriteLine($"\n{type2} Сборка :");
            Reflector.AssemblyName(Abonents1);

            Console.WriteLine($"\n{type2} Конструкторы:");
            Reflector.PublicConstructors(Abonents1);

            Console.WriteLine($"\n{type2} Методы:");
            Reflector.Methods(Abonents1);

            Console.WriteLine($"\n{type2} Свойства:");
            Reflector.Properties(Abonents1);

            Console.WriteLine($"\n{type2} Поля:");
            Reflector.Fields(Abonents1);

            Console.WriteLine($"\n{type2} Интерфейсы:");
            Reflector.Interfaces(Abonents1);

            string p2 = "Int32";
            Console.WriteLine($"\n{type2} Методы с параметром {p2}:");
            Reflector.MethodsByParametr(Abonents1, p2);

            Console.WriteLine($"\nВызывыем метод:");
            Reflector.Invoke(Abonents1, "AbonentRename", Reflector.ParamsGenerater("Lb12.Phone`2[System.Int32,System.String]", "AbonentRename"));

            Console.WriteLine($"\nВызывыем метод:");
            Reflector.Invoke(Abonents1, "AbonentRename", Reflector.FileRead("Lb12.Phone`2[System.Int32,System.String]", "AbonentRename"));


            Console.WriteLine("\nЗадание 2");
            Console.WriteLine($"Создаём объект:");
            Type type3 = pass1.GetType();
            Reflector.Create(type3);



            //-----------------------------------------------------------------
            Type myType = typeof(Abonents);
            Console.WriteLine(myType.ToString());

            Abonents abonent3 = new Abonents();  //Получение типа с помощью метода GetType класса Object
            Type myType2 = abonent3.GetType();
            Console.WriteLine(myType2);

            Type myType3 = Type.GetType("TestConsole.Abonents", false, true);  //Получения типа, с помощью статического метода Type.GetType()
            Console.WriteLine(myType3);


        }
    }
}
