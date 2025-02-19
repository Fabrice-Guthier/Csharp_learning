﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_POO_Genericite_1902
{
    public abstract class MainList<T>
    {
        protected List<T> elements = new List<T>();
        protected T element;

        protected void Add(T element)
        {
            elements.Add(element);
        }

        protected abstract T Get();

        protected abstract void Remove();

        protected abstract T GetAndRemove();
    }
}
