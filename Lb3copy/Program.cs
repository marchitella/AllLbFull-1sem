using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone Phone1 = new Phone(9, "Kuleshova", "Darina", "Mihaylovna", "Bobik 16", 13, 431, 800);
            Phone Phone2 = new Phone(3);
            Phone Phone3 = new Phone();
            Console.WriteLine("Phone1.ToString() = " + Phone1.ToString());//ToString – вывода строки - информации об объекте.
            Console.WriteLine("Phone2.Equals(Phone1) = " + Phone2.Equals(Phone1));//Equals, для сравнения объектов.
            Console.WriteLine("Phone3.GetHashCode() = " + Phone3.GetHashCode());

            Phone1.Ostatok(ref Phone1.balans, ref Phone1.Kredit, out Phone1.ost);//Остаток на счёте

            var AnonPhone = new { Karta = 21, Name = "Mark" };// Анонимный тип 
            Console.WriteLine("Сколько будет лиц?");
            int count = Convert.ToInt32(Console.ReadLine());
            Phone[] Phone = new Phone[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Создаём {i + 1} лицо:");
                Phone[i] = new Phone();
                Console.WriteLine("Введите id: ");
                Phone[i].id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите Фамилию: ");
                Phone[i].Fam = Console.ReadLine();
                Console.WriteLine("Введите Имя: ");
                Phone[i].Name = Console.ReadLine();
                Console.WriteLine("Введите номер карты: ");                          
                Phone[i].Karta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Кредит: ");
                Phone[i].Kredit = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Поиск по фамилии");
            string Fam = Console.ReadLine();
            foreach (Phone PhoneSearch in Phone) 
            {
                if (PhoneSearch.Fam == Fam)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Фамилия - {PhoneSearch.Fam}");
                    Console.WriteLine($"Имя - {PhoneSearch.Name}");
                    Console.WriteLine($"Номер карты - {PhoneSearch.Karta}");
                    Console.WriteLine();
                }

            }
        }

    }
    public partial class Phone
    {
        //Тип и свойства. Устанавливаем поля.
        public int id { get; set; }
        public string Fam { get; set; }
        public string Name { get; set; }
        public string Otch { get; set; }
        public string Adress { get; set; }
        public int Karta { get; set; }
        public int Debet { get; set; }
        public int Kredit;
        public int balans = 1000;
        public int ost;
        public string Time { get; set; }
        
        readonly int mark;//Поле только для чтения
        const double PI=3.14;

        static int numPhones = 0; //статическое поле
        public Phone()                                      
        {
            numPhones++;
        }
        static Phone()// Статический констр, вызывается перед вызовом первого констр. --!!!!--
        {
            Console.WriteLine("Вызван статический констр.");
        }

        public Phone(int id, string Fam, string Name, string Otch, string Adress, int Karta, int Debet, int Kredit) 
        {
            numPhones++;
            this.id = id;
            this.Fam = Fam;
            this.Name = Name;
            this.Otch = Otch;
            this.Adress = Adress;
            this.Karta = Karta;
            this.Debet = Debet;
            this.Kredit = Kredit;
        }
        //Нет типа у конструктора
        public Phone(int id, string Name="Mark", string Fam = "Kuleshov", string Otch="Sergeevich", int Karta=43, string Adress = "Gusko,14", int Debet=431, int Kredit=1000)
        {
            numPhones++;
            this.id = id;
            this.Fam = Fam;
            this.Name = Name;
            this.Otch = Otch;
            this.Adress = Adress;
            this.Karta = Karta;
            this.Debet = Debet;
            this.Kredit = Kredit;
        }
        
        public void Ostatok(ref int balans, ref int Kredit, out int ost) 
        {
            ost = balans - Kredit;
            Console.WriteLine($"Остаток: {ost}");
        }
        
        
    }
      


}
