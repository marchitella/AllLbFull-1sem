using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb5
{
    class Films : TelevisionProgram, ITVControlable
    {
        public void turnOff()
        {
            ChannelIsOn = false;
        }

        public override void turnOn()
        {
            ChannelIsOn = true;
            Console.WriteLine("Метод наследуемый от класса ТП");
        }

        public void VolumeDown()
        {
            Volume--;
        }

        public void VolumeUp()
        {
            Volume++;
        }

        void ITVControlable.turnOn()
        {
            ChannelIsOn = true;
            Console.WriteLine("Метод наследуемый от интерфейса");
        }

        public Films(int volume, bool ChannelIsOn = true) : base(volume, ChannelIsOn)
        {
            this.Volume = volume;
            this.ChannelIsOn = ChannelIsOn;
        }


    }
}
