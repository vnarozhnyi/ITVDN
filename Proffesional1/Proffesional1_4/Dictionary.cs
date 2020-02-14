using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proffesional1.Proffesional1_4
{
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] valueEn = new string[5];
        private string[] valueUa = new string[5];

        public int Count { get { return key.Length; } }

        public Dictionary()
        {
            key[0] = "книга"; valueEn[0] = "book"; valueUa[0] = "книга";
            key[1] = "ручка"; valueEn[1] = "pen"; valueUa[1] = "ручка";
            key[2] = "солнце"; valueEn[2] = "sun"; valueUa[2] = "сонце";
            key[3] = "яблоко"; valueEn[3] = "apple"; valueUa[3] = "яблуко";
            key[4] = "стол"; valueEn[4] = "table"; valueUa[4] = "стiл";
        }

        public void Add(string ru, string ua, string en)
        {
            for(int i = 0; i < key.Length; i++)
            {
                if(key[i] == ru)
                {
                    valueEn[i] = en;
                    valueUa[i] = ua;
                    return;
                }
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + valueEn[index] + " - " + valueUa[index];
                else
                    return "Attempt to access outside the array.";
            }
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] == index)
                        return key[i] + " - " + valueEn[i] + " - " + valueUa[i];
                    if (valueEn[i] == index)
                        return key[i] + " - " + valueEn[i] + " - " + valueUa[i];
                    if (valueUa[i] == index)
                        return key[i] + " - " + valueEn[i] + " - " + valueUa[i];
                }
                return string.Format("{0} - no translation for this word.", index);
            }
        }
    }
}
