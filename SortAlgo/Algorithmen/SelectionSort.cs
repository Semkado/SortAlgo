using System.Drawing;

namespace SortAlgo.Algorithmen
{
    class SelectionSort
    {
        public void sort(int[] array, int elemente, Form1 f1)
        {
            int index, index_klein,
                wert, wert_klein;
            int z = 0;
            int[] temparray = new int[array.Length];

            for (index = 0; index < elemente; index++)
            {
                System.Array.Copy(array, temparray, array.Length);
                f1.richTextBox1.AppendText("Schritt " + z + ": ");
                z++;
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
                }
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
