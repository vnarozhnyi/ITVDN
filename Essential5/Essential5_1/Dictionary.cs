﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential5.Essential5_1
{
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] ENG = new string[5];
        private string[] UA = new string[5];

        public Dictionary()
        {
            key[0] = "книга"; UA[0] = "книга"; ENG[0] = "book";
            key[1] = "ручка"; UA[1] = "ручка"; ENG[1] = "pen";
            key[2] = "солнце"; UA[2] = "сонце"; ENG[2] = "sun";
            key[3] = "яблоко"; UA[3] = "яблуко"; ENG[3] = "apple";
            key[4] = "стол"; UA[4] = "стіл"; ENG[4] = "table";
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + UA[index] + " - " + ENG[index];
                return "An attempt to access outside the array.";
            }
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] == index)
                        return key[i] + " - " + UA[i] + " - " + ENG[i];
                    if (UA[i] == index)
                        return UA[i] + " - " + key[i] + " - " + ENG[i];
                    if (ENG[i] == index)
                        return ENG[i] + " - " + key[i] + " - " + UA[i];
                }

                return string.Format("{0} - there is no translation for this word.", index);
            }
        }
    }
}
