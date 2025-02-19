using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_POO_Genericite_1902
{
    class ListLifo<T> : MainList<T>
    {
        protected override T Get()
        {
            return elements.Last();
        }

        protected override T GetAndRemove()
        {
            int index = elements.Count - 1;
            element = elements.Last();

            elements.RemoveAt(index);

            return element;
        }

        protected override void Remove()
        {
            int index = elements.Count - 1;
            elements.RemoveAt(index);
        }

    }
}
