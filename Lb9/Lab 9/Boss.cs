using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_9
{   
    class Boss
    {
        public delegate void EventHandler(string str);
        public event EventHandler Upgrading;
        public event EventHandler TurningOn;

        public int Level { get; private set; }
        public bool Status { get; private set; }
        public void Upgrade()
        {
            Level++;
            Upgrading?.Invoke("Уровень повышен");//Метод ивентов, пробуждает событие.
        }
        public void Upgrade(int levels)
        {
            Level += levels;
            Upgrading?.Invoke($"Уровень повышен на {levels}");
        }

        public void GetStatus()
        {
            if(Status)
                Console.WriteLine("Работает....");
            else
                Console.WriteLine("~Сломано~");
        }

        public void TurnOn(int pressure)
        {
            if (pressure > 220)
            {
                Status = false;
                TurningOn?.Invoke($"Превышено напряжение!");
            }
            else
            {
                Status = true;
                TurningOn?.Invoke($"Включено!");
            }
        }

        public Boss()
        {
            Level = 0;
        }
        public Boss(int level)
        {
            Level = level;
        }

    }
}
