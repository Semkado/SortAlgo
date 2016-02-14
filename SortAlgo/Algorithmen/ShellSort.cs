using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgo.Algorithmen
{
    class ShellSort
    {

        public int[] shellsort(int[] array, int elemente)
        {
            int i, j, temp, n;

            /* Anfangswert für die Distanz errechnen */
            for (n = 1; n <= elemente / 9; n = 3 * n + 1) ;
            for (; n > 0; n /= 3)
            {
                for (i = n; i <= elemente; i++)
                {
                    temp = array[i];
                    /* Größer als temp und nicht elemente
                     * sowie >= und nicht > */
                    for (j = i;
                        j >= n && array[j - n] > temp;
                        j -= n)
                    {
                        array[j] = array[j - n];
                    }
                    array[j] = temp;
                }
            }
            return array;
        }
    }
}
