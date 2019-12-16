using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace lab3
{
    class SimpleStack<T> : SimpleList<T>
         where T : IComparable
    {
        public void Push(T element)
        {
            Add(element);
        }
        public T Pop()
        {
            T element = Get(Count - 1);
            SimpleListItem<T> listItem = GetItem(Count - 1);
            listItem = null;
            Count--;
            return element;
        }
    }
}
