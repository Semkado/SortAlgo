using System.Drawing;
using System.Threading;

namespace SortAlgo.Algorithmen
{
    internal class Sort
    {
        public int ColorNumbers(int[] neu, int[] alt, int z, Form1 f1)
        {
            f1.richTextBox1.AppendText("Schritt " + z + ": ");
            z++;
            f1.richTextBox1.Update();
            Thread.Sleep(f1.delay);
            for (int x = 0; x < neu.Length; x++)
            {
                if (alt[x] != neu[x])
                {
                    f1.richTextBox1.SelectionColor = Color.Red;
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
            //Scrollen
            f1.richTextBox1.Select(f1.richTextBox1.Text.Length, 1);
            f1.richTextBox1.ScrollToCaret();

            f1.richTextBox1.Update();
            return z;
        }
    }
}
