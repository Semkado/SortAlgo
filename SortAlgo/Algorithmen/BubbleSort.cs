using System.Drawing;

namespace SortAlgo.Algorithmen
{
    class BubbleSort
    {
        public void sort(int[] array, int elemente, Form1 f1)
        {
            int i, temp;
            int z = 0;
            int[] temparray = new int[array.Length];

            while (elemente >= 0)
            {
                for (i = 1; i <= elemente; i++)
                {
                    System.Array.Copy(array, temparray, array.Length);
                    f1.richTextBox1.AppendText("Schritt " + z + ": ");
                    z++;
                    if (array[i - 1] > array[i])
                    {
                        temp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = temp;
                    }
                    ColorNumbers(array, temparray, f1);
                }
                elemente--;
            }
        }
        #region sort 2
        public void sort2(int[] data, Form1 f1)
        {
            int i, j;
            int z = 0;
            int N = data.Length;
            int[] temparray = new int[data.Length];

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    System.Array.Copy(data, temparray, data.Length);
                    f1.richTextBox1.AppendText("Schritt " + z + ": ");
                    z++;
                    if (data[i] > data[i + 1])
                        exchange(data, i, i + 1);
                    ColorNumbers(data, temparray, f1);
                }
            }
        }
        public static void exchange(int[] data, int m, int n)
        {
            int temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }
        #endregion
        private void ColorNumbers(int[] neu, int[] alt, Form1 f1)
        {
            for (int x = 0; x < alt.Length; x++)
            {
                if (alt[x] != neu[x])
                {
                    f1.richTextBox1.SelectionColor = Color.CornflowerBlue;
                    f1.richTextBox1.AppendText(alt[x].ToString());
                    f1.richTextBox1.SelectionColor = Color.Black;
                    f1.richTextBox1.AppendText(" ");
                }
                else
                {
                    f1.richTextBox1.AppendText(alt[x].ToString());
                    f1.richTextBox1.AppendText(" ");
                }
            }
            f1.richTextBox1.AppendText("\n");
        }
    }
}
