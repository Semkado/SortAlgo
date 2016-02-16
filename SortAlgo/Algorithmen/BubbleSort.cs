using System.Drawing;

namespace SortAlgo.Algorithmen
{
    class BubbleSort
    {
        int z = 0;
        public void sort(int[] array, int elemente, Form1 f1)
        {
            int i, temp;
            
            int[] temparray = new int[array.Length];

            
            while(elemente >= 0)
            {
                for (i = 1; i <= elemente; i++)
                {
                    System.Array.Copy(array, temparray, array.Length);
                    
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
            f1.richTextBox1.AppendText("Schritt " + z + ": " + string.Join(" ", array));
            z = 0;
        }

        private void ColorNumbers(int[] neu, int[] alt, Form1 f1)
        {
            f1.richTextBox1.AppendText("Schritt " + z + ": ");
            z++;

            for (int x = 0; x < neu.Length; x++)
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
