using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_5
{
    internal interface IStorage<T>
    {
        void Add(T item);
        T Get(int index);
    }
}
