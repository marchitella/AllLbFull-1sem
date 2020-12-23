using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb5
{
    class ArtFilm : Films
    {
        public ArtFilm(int volume, bool ChannelIsOn = true) : base(volume, ChannelIsOn)
        {
            this.Volume = volume;
            this.ChannelIsOn = ChannelIsOn;
        }

    }
}
