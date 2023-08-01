using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_Generics
{
    internal class Repository<T,U> where T : U
    {
    }
}
