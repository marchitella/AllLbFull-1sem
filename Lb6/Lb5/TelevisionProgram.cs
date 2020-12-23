using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb6
{
    abstract class TelevisionProgram
    {
        public bool ChannelIsOn { get; set; }
        public int Year { get; set; }
        public int Volume { get; set; }
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
