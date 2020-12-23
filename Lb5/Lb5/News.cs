using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb5
{
    sealed class News : TelevisionProgram
    {
        public News(int volume, bool ChannelIsOn = true) : base(volume, ChannelIsOn)
        {
            this.Volume = volume;
            this.ChannelIsOn = ChannelIsOn;
        }

        public override void turnOn()//Перегружаем
        {
            ChannelIsOn = true;
        }
    }
}
