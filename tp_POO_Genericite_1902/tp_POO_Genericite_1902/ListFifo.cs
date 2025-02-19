using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tp_POO_Genericite_1902
{
    class ListFifo<T>: MainList<T>
    {
        public override T Get()
        {
            return elements[0];
        }

        public override T GetAndRemove()
        {
            element = elements[0];

            elements.RemoveAt(0);

            return element;
        }

        public override void Remove()
        {
            elements.RemoveAt(0);
        }
    }
}
