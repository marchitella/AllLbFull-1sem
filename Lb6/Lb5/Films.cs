using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb6
{
    class Films : TelevisionProgram, ITVControlable
    {
        public void turnOff()
        {
            ChannelIsOn = false;
        }

        public override void turnOn()//Перегружаем
        {
            ChannelIsOn = true;
        }

        public void VolumeDown()
        {
            Volume--;
        }

        public void VolumeUp()
        {
            Volume++;
        }

        void ITVControlable.turnOn()//Реализуем
        {
            ChannelIsOn = true;
        }

        public Films(int volume, int Year, bool ChannelIsOn = true)  : base(volume, Year, ChannelIsOn)
        {
            this.Volume = volume;
            this.ChannelIsOn = ChannelIsOn;
            this.Year = Year;
        }


}
}
