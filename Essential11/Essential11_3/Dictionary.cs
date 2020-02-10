using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential11.Essential11_3
{
    class Dictionary<TKey, TValue>
    {
        private readonly MyList<TKey> key;
        private readonly MyList<TValue> value;

        public Dictionary()
        {
            key = new MyList<TKey>();
            value = new MyList<TValue>();
        }

        public void AddToDictionary(TKey k, TValue v)
        {
            key.Add(k);
            value.Add(v);
        }

        public string this[int index]
        {
            get { return key[index] + " " + value[index]; }
        }

        public string this[TKey index]
        {
            get
            {
                for (int i = 0; i < key.Count; i++)
                {
                    if ((string)(object)key[i] == (string)(object)index)
                    {
                        return "By key " + index.ToString().ToUpper() + " found value: " + value[i].ToString().ToUpper();
                    }
                }
                return "By key " + index + " no value found ";
            }
        }

        public int Lenght
        {
            get { return key.Count; }
        }

        public override string ToString()
        {
            string stringS = string.Empty;
            for (int i = 0; i < key.Count; i++)
            {
                stringS += key[i] + " " + value[i] + "\n";
            }
            if (stringS != null)
                return stringS;
            return "The dictionary has no meanings.";
        }
    }
}
