using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb12
{
    class Spam
    {
        public bool inCityCalls { get; set; }
        public byte SpamId { get; set; }

        public Spam(bool inCityCalls, byte SpamId)
        {

            this.inCityCalls = inCityCalls;
            this.SpamId = SpamId;
        }

    }
}
