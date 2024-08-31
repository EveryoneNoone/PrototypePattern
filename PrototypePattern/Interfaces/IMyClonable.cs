using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Interfaces
{
    internal interface IMyClonable<T>
    {
        T MyClone();
    }
}
