using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb6
{
    class ArtFilm : Films
    {
        public ArtFilm(int volume, int Year, bool ChannelIsOn = true) : base(volume, Year, ChannelIsOn)
        {
            this.Volume = volume;
            this.Year = Year;
            this.ChannelIsOn = ChannelIsOn;
        }

    }
}
