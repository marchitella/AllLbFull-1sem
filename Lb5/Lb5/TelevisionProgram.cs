using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb5
{
    abstract class TelevisionProgram
    {
        public bool ChannelIsOn { get; set; }
        public int Volume { get; set; }

        public abstract void turnOn();//<--


        public TelevisionProgram(int volume, bool ChannelIsOn = true) 
        {
            this.Volume = volume;
            this.ChannelIsOn = ChannelIsOn;
        }

        public override string ToString()
        {
            return $"Объект типа {this.GetType()}";
        }
    }
}
