using System;
using System.Threading;

namespace SortAlgo.Algorithmen
{
    internal class MergeSort : Sort
    {
        int z;
        public void sort(int[] input, int left, int right, Form1 f1)
        {
            var temparray = new int[input.Length];

            if (left < right)
            {
                var middle = (left + right) / 2;

                Array.Copy(input, temparray, input.Length);

                sort(input, left, middle, f1);
                sort(input, middle + 1, right, f1);

                //Merge
                var leftArray = new int[middle - left + 1];
                var rightArray = new int[right - middle];

                Array.Copy(input, left, leftArray, 0, middle - left + 1);
                Array.Copy(input, middle + 1, rightArray, 0, right - middle);
                f1.changedValues++;

                var i = 0;
                var j = 0;
                for (int k = left; k < right + 1; k++)
                {
                    if (i == leftArray.Length)
                    {
                        input[k] = rightArray[j];
                        j++;
                        f1.testedValue++;
                    }
                    else if (j == rightArray.Length)
                    {
                        input[k] = leftArray[i];
                        i++;
                        f1.testedValue++;
                    }
                    else if (leftArray[i] <= rightArray[j])
                    {
                        input[k] = leftArray[i];
                        i++;
                        f1.testedValue++;
                    }
                    else
                    {
                        input[k] = rightArray[j];
                        j++;
                        f1.testedValue++;
                    }
                }
                z = ColorNumbers(input, temparray, z, f1);
                Thread.Sleep(f1.delay);
                f1.richTextBox1.AppendText("Schritt " + z + ": " + string.Join(" ", input));
                f1.richTextBox1.AppendText("\n");
            }
        }
    }
}