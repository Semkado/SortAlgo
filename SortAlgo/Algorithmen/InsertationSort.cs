using System.Drawing;

namespace SortAlgo.Algorithmen
{
    class InsertationSort
    {
        public void sort(int[] array, int elemente, Form1 f1)
        {
            int temp, j;
            int z = 0;
            int[] temparray = new int[array.Length];

            for (int i = 1; i < array.Length; i++)
            {
                System.Array.Copy(array, temparray, array.Length);
                f1.richTextBox1.AppendText("Schritt " + z + ": ");
                z++;

                temp = array[i];
                j = i - 1;

                while (j >= 0 && array[j] > temp)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
                ColorNumbers(array, temparray, f1);
            }
        }
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
