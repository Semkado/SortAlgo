using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgo.Algorithmen
{
    class SelectionSort
    {
        public int[] sort(int[] array, int elemente)
        {
            int index, index_klein,
                wert, wert_klein;

            /* Schleife wird von links nach rechts durchlaufen. */
            for (index = 0; index < elemente; index++)
            {
                /* aktuelle Position */
                wert = index;
                /* Schleife läuft durch bis ein kleineres Element als
                 * die aktuelle Position gefunden wurde oder bis zum Ende,
                 * was bedeutet, die aktuelle Position ist schon
                 * das kleinste Element. */
                for (index_klein = index + 1; index_klein <= elemente;
                  index_klein++)
                { /* Ein kleineres Element gefunden? */
                    if (array[index_klein] < array[wert])
                        /* Neues kleinstes Element */
                        wert = index_klein;
                }
                /* kleinstes Element an die aktuelle
                 * Position falls nötig */
                if (wert != index)
                {
                    wert_klein = array[wert];
                    array[wert] = array[index];
                    array[index] = wert_klein;
                }
            }
            return array;
        }
    }
}
