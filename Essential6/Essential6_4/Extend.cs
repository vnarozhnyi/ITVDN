using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential6.Essential6_4
{
    static class Extend
    {
        static public void SortUp(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (array[i] > array[j])
                    {
                        int x = array[j];
                        array[j] = array[i];
                        array[i] = x;
                    }

                }
            }
        }
    }
}
