using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb6
{
    class Advertising : TelevisionProgram
    {
        public Advertising(int volume, int Year, bool ChannelIsOn = true) : base(volume, Year, ChannelIsOn)
        {
            this.Year = Year;
            this.Volume = volume;
            this.ChannelIsOn = ChannelIsOn;
        }

        public override void turnOn()//Перегружаем
        {
            ChannelIsOn = true;
        }
    }
}
