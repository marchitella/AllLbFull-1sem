using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb7
{
    class NullReferenceExeption : Exception
    {
        public NullReferenceExeption(string message)
            : base(message) 
        { }
    }
}
