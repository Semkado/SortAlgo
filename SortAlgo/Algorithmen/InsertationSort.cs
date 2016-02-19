using System.Drawing;
using System.Threading;

namespace SortAlgo.Algorithmen
{
    class InsertationSort :Sort
    {
        int z = 0;
        public void sort(int[] array, int elemente, Form1 f1)
        {
            int temp, j;
            int[] temparray = new int[array.Length];

            for (int i = 1; i < array.Length; i++)
            {
                System.Array.Copy(array, temparray, array.Length);

                temp = array[i];
                j = i - 1;

                while (j >= 0 && array[j] > temp)
                {
                    array[j + 1] = array[j];
                    j--;
                    f1.changedValues++;
                }
                array[j + 1] = temp;
                
                z = ColorNumbers(array, temparray, z, f1);
            }
            f1.richTextBox1.Update();
            Thread.Sleep(f1.delay);
            f1.richTextBox1.AppendText("Schritt " + z + ": " + string.Join(" ", array));
            z = 0;
        }
    }
}
