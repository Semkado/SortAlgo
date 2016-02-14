using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgo.Algorithmen
{
    class BubbleSort
    {
        public int[] sort(int[] array, int elemente)
        {
            int i, temp;

            while (elemente >= 0)
            {
                for (i = 1; i <= elemente; i++)
                    if (array[i - 1] > array[i])
                    {
                        temp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = temp;
                    }
                elemente--;
            }
            return array;

        }
    }
}
