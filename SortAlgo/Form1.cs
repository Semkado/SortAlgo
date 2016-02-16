using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SortAlgo.Algorithmen;

namespace SortAlgo
{
    public partial class Form1 : Form
    {
        SelectionSort mSelectionSort = new SelectionSort();
        InsertationSort mInsertationSort = new InsertationSort();
        BubbleSort mBubbleSort = new BubbleSort();
        MergeSort mMergeSort = new MergeSort();        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> l = new List<int>();
            Performance mPerformance = new Performance();
            int arrayLaenge;

            //Listbox leeren
            richTextBox1.Clear();

            mPerformance.Start();
            #region Textbox to String List
            char[] delimiterChars = { ' ', ';' }; //Zeichen, bei denen gesplittet werden soll
            string text = input_tB.Text; //Text aus der Textbox
            string[] words = text.Split(delimiterChars);    //Array mit gesplitteten Strings wird erstellt

            foreach (string s in words)
            {
                try
                {
                    l.Add(Convert.ToInt32(s));
                }
                catch (Exception)
                {
                    continue;
                    throw;
                }

            }
            #endregion

            #region List<String> to Int[]
            int[] input = l.ToArray();
            arrayLaenge = input.Length;
            label6.Text = "Anzahl der Elemente: " + arrayLaenge;
            #endregion

            //Algorithmus auswählen
            #region Algorithmen auswahl
            if (comboBox1.Text == "Selection - Sort.")
            {
                mSelectionSort.sort(input, arrayLaenge -1, this);
            }
            else if (comboBox1.Text == "Insertation - Sort.")
            {
                mInsertationSort.sort(input, arrayLaenge -1, this);
            }
            else if (comboBox1.Text == "Bubble - Sort.")
            {
                mBubbleSort.sort(input, arrayLaenge - 1, this);
            }
            else if (comboBox1.Text == "Merge - Sort.")
            {
                MessageBox.Show("Noch nicht verfügbar!",
                    "Algorithmus nicht gefunden",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (comboBox1.Text == "<bitte wählen>")
            {
                MessageBox.Show("Bitte geben sie ein Verfahren an!");
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einen gültigen Algorithmus!",
                    "Algorithmus nicht gefunden",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            #endregion

            mPerformance.Stop();
            label4.Text = "Zeit: " + mPerformance.Duration;            
        }

        private void random_button_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            input_tB.Text += r.Next(1, 100)+ " ";
        }
    }
}
