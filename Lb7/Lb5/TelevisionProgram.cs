using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb7
{
    abstract class TelevisionProgram
    {
        private int _year;
        private int _volume;
        public bool ChannelIsOn { get; set; }
        public int Year
        {
            get { return _year; }
            set 
            {
                if (value > 2020)
                    throw new YearExeption("Значение года должно быть меньше 2020");
                else
                    _year = value;
            }

        }
        public int Volume
        {
            get { return _volume; }
            set
            {
                if (value <= 0 || value >= 100)
                    throw new VolumExeption("Значение громкости должно быть не меньше 0, но и  не больше 100");
                else
                    _volume = value;
            }

        }
        public abstract void turnOn();

        public TelevisionProgram(int volume, int Year, bool ChannelIsOn = true) 
        {
            this.Volume = volume;
            this.ChannelIsOn = ChannelIsOn;
            this.Year = Year;
        }

        public override string ToString()
        {
            return $"Объект типа {this.GetType()}";
        }


        public TelevisionProgram Next { get; set; }
        public TelevisionProgram NextElement()
        {
            return this.Next;
        }

        public void Status()
        {
            Console.WriteLine($"Программа {this.GetType()}. Включена ли программа = {ChannelIsOn}. Громкость звука = {Volume}. Год выхода программы = {Year}");
        }

    }
}
