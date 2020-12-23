using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb10
{
    class Furniture<T> : IList<T>
    {
        public string Type { get; set; }
        public Furniture(string type)
        {
            Type = type;
        }
        T IList<T>.this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int ICollection<T>.Count => throw new NotImplementedException();
        bool ICollection<T>.IsReadOnly => throw new NotImplementedException();
        void ICollection<T>.Add(T item)
        {
            throw new NotImplementedException();
        }
        void ICollection<T>.Clear()
        {
            throw new NotImplementedException();
        }
        bool ICollection<T>.Contains(T item)
        {
            throw new NotImplementedException();
        }
        void ICollection<T>.CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        int IList<T>.IndexOf(T item)
        {
            throw new NotImplementedException();
        }
        void IList<T>.Insert(int index, T item)
        {
            throw new NotImplementedException();
        }
        bool ICollection<T>.Remove(T item)
        {
            throw new NotImplementedException();
        }
        void IList<T>.RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }
}
