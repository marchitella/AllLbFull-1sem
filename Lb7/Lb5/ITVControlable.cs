using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb7
{
    interface ITVControlable
    {
        void turnOn();
        void turnOff();
        void VolumeUp();
        void VolumeDown();

    }

    enum Afisha : byte //<----
    {
        Venom = 1,
        SpiderMan,
        IronMan
    }

    struct FilmInfo
    {

        public int duration { get; set; }
        public int ticketPrice { get; set; }


        public FilmInfo(int duration,int ticketPrice)
        {
            this.duration=duration;
            this.ticketPrice = ticketPrice;
        }
    }


}
