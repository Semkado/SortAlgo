using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgo.Algorithmen
{
    class InsertationSort
    {
        public int[] sort(int[] array, int elemente)
        {
            int index, index_klein, wert_klein;

            /* Schleife von links-1 nach rechts */
            for (index = 1; index <= elemente; index++)
            {
                /* aktuelle Position zwischenspeichern */
                wert_klein = array[index];
                /* Kleineren Wert als wert_klein suchen. Schleife  läuft
                 * von aktueller Position von rechts nach links durch. */
                for (index_klein = index;
                     array[index_klein - 1] > wert_klein && index_klein > 0;
                     index_klein--)
                    /* wenn Vorgänger größer als aktuelles
                     * Element in wert_klein */
                    array[index_klein] = array[index_klein - 1];
                /* gespeichertes Element an neue Position ->
                 * Lücke auffüllen */
                array[index_klein] = wert_klein;
            }
            return array;
        }
    }
}
