﻿using System.Threading;

namespace SortAlgo.Algorithmen
{
    class BubbleSort : Sort
    {
        int z;
        public void sort(int[] array, int elemente, Form1 f1)
        {
           var temparray = new int[array.Length];
            int i, temp;

            while (elemente >= 0)
            {
                for (i = 1; i <= elemente; i++)
                {
                    System.Array.Copy(array, temparray, array.Length);
                    f1.testedValue++;
                    if (array[i - 1] > array[i])
                    {
                        temp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = temp;
                        f1.changedValues++;
                    }
                    z = ColorNumbers(array, temparray, z, f1);
                }
                elemente--;
            }
            f1.richTextBox1.Update();
            Thread.Sleep(f1.delay);
            f1.richTextBox1.AppendText("Schritt " + z + ": " + string.Join(" ", array));
            z = 0;
        }
    }
}
