using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb7
{
    class Multfilm : Films
    {
        public Multfilm(int volume, int Year, bool ChannelIsOn = true) : base(volume, Year, ChannelIsOn)
        {
            this.Year = Year;
            this.Volume = volume;
            this.ChannelIsOn = ChannelIsOn;
        }
    }
}
