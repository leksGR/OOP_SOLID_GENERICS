using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_3
{
    public class Repository<T> where T : class
    {
        private List<T> items;
        public Repository()
        {
            items = new List<T>();
        }
        public void Add(T item)
        {
            items.Add(item);
        }
        public T Get(int index)
        {
            return items[index];
        }
    }
}
