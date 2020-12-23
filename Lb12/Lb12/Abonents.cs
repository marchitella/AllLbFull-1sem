using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb12
{
    public class Abonents
    {
        public bool inCityCalls { get; set; }
        public bool outCityCalls { get; set; }
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
        public Abonents()
        { }
        public Abonents(int id, string Fam, string Name, string Otch, string Adress, int Karta, int Debet, int Kredit)
        {

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
        public Abonents(bool outCityCalls, int Debet, bool inCityCalls, string Name = "Mark", string Fam = "Kuleshov", string Otch = "Sergeevich", int Karta = 43, string Adress = "Gusko,14", int Kredit = 1000)
        {
            this.outCityCalls = outCityCalls;
            this.inCityCalls = inCityCalls;
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
        
        public void Abonentdolg(string name)
        { 
            Console.WriteLine($"Абонент-должник: {name}");
        }

        public void Ostatok2(int balans, int Kredit, int ost)
        {
            ost = balans - Kredit;
            Console.WriteLine($"Остаток: {ost}");
        }
        public void info()
        {
            Console.WriteLine($"{Fam} {Name}, Дебет {Debet}");
        }

        interface ITVControlable
        {
            void turnOn();
            void turnOff();
            void VolumeUp();
            void VolumeDown();

        }

        private Abonents(string Name)
        {
            this.Name = Name;
        }


        private void Abonts()
        {

        }

    }

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public User(string n, int a)
        {
            Name = n;
            Age = a;
        }
        public void Display()
        {
            Console.WriteLine($"Имя: {Name}  Возраст: {Age}");
        }
        public int Payment(int hours, int perhour)
        {
            return hours * perhour;
        }
    }
}
