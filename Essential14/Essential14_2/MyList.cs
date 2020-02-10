﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential14.Essential14_2
{
    class MyList<T>
    {
        T[] array = null;

        public MyList()
        {
            array = new T[0];
        }

        public int Count
        {
            get { return array.Length; }
        }

        public void Add(T elem)
        {
            T[] arr = new T[array.Length + 1];
            array.CopyTo(arr, 0);
            arr[array.Length] = elem;
            array = arr;
        }

        public T this[int index]
        {
            get { return array[index]; }
        }

        int position = -1;

        public void Reset()
        {
            position = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            while (true)
            {
                if (position < array.Length - 1)
                {
                    position++;
                    yield return array[position];
                }
                else
                {
                    Reset();
                    yield break;
                }
            }
        }
    }
}
