using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb7
{
    class VolumExeption : Exception
    {
        public VolumExeption(string message)
           : base(message)
        { }
    }
}
