using System.Threading;

namespace SortAlgo.Algorithmen
{
    class SelectionSort : Sort
    {
        int z = 0;
        public void sort(int[] array, int elemente, Form1 f1)
        {
            int index, index_klein,
                wert, wert_klein;

            int[] temparray = new int[array.Length];

            for (index = 0; index < elemente; index++)
            {
                System.Array.Copy(array, temparray, array.Length);

                wert = index;
                for (index_klein = index + 1; index_klein <= elemente; index_klein++)
                {
                    if (array[index_klein] < array[wert])
                    {
                        wert = index_klein;
                    }
                }

                if (wert != index)
                {
                    wert_klein = array[wert];
                    array[wert] = array[index];
                    array[index] = wert_klein;
                    f1.changedValues++;
                }
                z = ColorNumbers(array, temparray, z,  f1);
            }
            f1.richTextBox1.Update();
            Thread.Sleep(f1.delay);
            f1.richTextBox1.AppendText("Schritt " + z + ": " + string.Join(" ", array));
            z = 0;
        }
        
    }
}
