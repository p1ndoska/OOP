using System;
using System.Collections.Generic;
using System.Text;

namespace lab07_OOP
{
    interface IGenericInterface<T> where T : class
    {
        void Add(T type);
        void Delete(T type);
        void Show();
    }
}