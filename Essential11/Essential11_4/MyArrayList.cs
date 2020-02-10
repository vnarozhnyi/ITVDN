﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential11.Essential11_4
{
    class MyArrayList
    {
        private object[] array;

        public MyArrayList()
        {
            array = new object[0];
        }

        public void Add(object a)
        {
            object[] tempArray = new object[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            tempArray[array.Length] = a;
            array = tempArray;
        }

        public object this[int index]
        {
            get { return array[index]; }
        }

        public int Count
        {
            get { return array.Length; }
        }

        public void Clear()
        {
            array = new object[0];
        }

        public bool Contains(object item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == item)
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            string stringS = null;
            for (int i = 0; i < array.Length; i++)
            {
                stringS += array[i] + " ";
            }
            return "Array Dimension " + array.Length + " Array Elements:" + stringS;
        }
    }
}
