using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential14.Essential14_3
{
    class MyDictionary<TKey, TValue> : IEnumerable<object>, IEnumerator<object>
    {
        private readonly TKey[] key;
        private readonly TValue[] value;
        private readonly int lenght;

        int position = -1;

        public int Lenght
        {
            get { return lenght; }
        }

        public MyDictionary(int n)
        {
            key = new TKey[n];
            value = new TValue[n];
            lenght = n;
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index];
                return "An attempt to access outside the array.";
            }
        }

        public void Add(int i, TKey k, TValue l)
        {
            key[i] = k;
            value[i] = l;
        }

        public bool MoveNext()
        {
            if (position < key.Length - 1)
            {
                position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get { return key[position] + " " + value[position]; }
        }

        object IEnumerator.Current
        {
            get { return key[position] + " " + value[position]; }
        }

        public IEnumerator<object> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public void Dispose()
        {
            Reset();
        }
    }
}
