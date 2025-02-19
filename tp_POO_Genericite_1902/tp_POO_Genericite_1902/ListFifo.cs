using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_POO_Genericite_1902
{
    class ListFifo<T>: MainList<T>
    {
        protected override T Get()
        {
            return elements[0];
        }

        protected override T GetAndRemove()
        {
            element = elements[0];

            elements.RemoveAt(0);

            return element;
        }

        protected override void Remove()
        {
            elements.RemoveAt(0);
        }
    }
}
