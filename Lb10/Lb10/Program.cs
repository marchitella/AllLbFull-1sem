using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Lb10
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Furniture<string> Furniture1 = new Furniture<string>("Диван");
            Furniture<string> Furniture2 = new Furniture<string>("Кровать");
            Furniture<string> Furniture3 = new Furniture<string>("Стул");
            Furniture<string> Furniture4 = new Furniture<string>("Стол");
            ArrayList list1 = new ArrayList() { Furniture1, Furniture2, Furniture3};           
            list1.Add(Furniture4);
            Console.WriteLine($"Добавили {Furniture4.Type}");
            Console.WriteLine();
            foreach (Furniture<string> furniture in list1)
            {
                Console.WriteLine($"Мебель: {furniture.Type}");
            }
            Console.WriteLine();
            list1.RemoveAt(3);//Метод удаления
            Console.WriteLine($"Удалили {Furniture4.Type}");
            Console.WriteLine();
            foreach (Furniture<string> furniture in list1)
            {
                Console.WriteLine($"Мебель: {furniture.Type}");
            }
            Console.WriteLine();
            Console.WriteLine($"Мебель {Furniture2.Type} в списке под номером: { list1.BinarySearch(Furniture2) + 1}");

            Console.WriteLine("\nЗадание 2");

            ArrayList list2 = new ArrayList() { 'm', 'a', 'r', 'c', 'h', 'i' };
            foreach (char ch in list2)
            {
                Console.Write($"{ch} ");
            }
            Console.WriteLine();
            Console.WriteLine("Сколько удалить элементов в начале?");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                list2.RemoveAt(0);
            }

            foreach (char ch in list2)
            {
                Console.Write($"{ch} ");
            }
            Console.WriteLine();
            list2.Add('t');
            char[] arr = { 'e', 'l', 'l', 'a' };
            list2.AddRange(arr);// Добавляем массив в лист 2
            foreach (char ch in list2)
            {
                Console.Write($"{ch} ");
            }
            Console.WriteLine();

            List<char> List = new List<char>();

            foreach (char ch in list2)
            {
                List.Add(ch);
            }
            Console.WriteLine();
            Console.WriteLine("Новый список содержит элементы: ");
            foreach (char ch in List)
            {
                Console.Write($" {ch} ");
            }
            Console.WriteLine();
            Console.WriteLine("Выберите элемент:");
            char search = Convert.ToChar(Console.Read());
            if (List.Contains(search))
            {
                Console.WriteLine("Такой элемент найден");
            }
            else
            {
                Console.WriteLine("К сожалению такого элемента нет");
            }

            Console.WriteLine("\nЗадание 3");
            ObservableCollection<Furniture<string>> furnitures = new ObservableCollection<Furniture<string>> { Furniture1, Furniture2, Furniture3 };
            furnitures.CollectionChanged += furnitures_CollectionChanged;//Событие + обработчик события
            foreach (Furniture<string> furniture in furnitures)
            {
                Console.WriteLine($"Мебель: {furniture.Type}");
            }
            furnitures.Add(Furniture4);
            foreach (Furniture<string> furniture in furnitures)
            {
                Console.WriteLine($"Мебель: {furniture.Type}");
            }
            furnitures.RemoveAt(1);

            foreach (Furniture<string> furniture in furnitures)
            {
                Console.WriteLine($"Мебель: {furniture.Type}");
            }
            //Работа с ArrayList
            ArrayList list = new ArrayList();
            list.Add(2.3); // заносим в список объект типа double
            list.Add(55); // заносим в список объект типа int
            foreach (object o in list)
            {
                Console.WriteLine(o);
            }
            list.RemoveAt(0);
            foreach (object o in list)
            {
                Console.WriteLine(o);
            }

        }       
        private static void furnitures_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: // если добавление
                    Console.WriteLine($"Добавлена новая мебель");
                    break;
                case NotifyCollectionChangedAction.Remove: // если удаление
                    Console.WriteLine($"Удалена мебель");
                    break;
                default:
                    Console.WriteLine($"Коллекция была изменена");
                    break;
            }
        }


    }
}
