using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential10.Essential10_3
{
    class MyDictionary<TKey, TValue>
    {
        private readonly TKey[] key;
        private readonly TValue[] value;
        private readonly int lenght;

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
    }
}
