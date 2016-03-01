using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SortAlgo.Algorithmen;
using System.Threading;

namespace SortAlgo
{
    public partial class Form1 : Form
    {
        // Algorithmen
        SelectionSort mSelectionSort = new SelectionSort();
        InsertationSort mInsertationSort = new InsertationSort();
        BubbleSort mBubbleSort = new BubbleSort();
        MergeSort mMergeSort = new MergeSort();
        QuickSort mQuickSort = new QuickSort();

        //Vertauschungen
        public int changedValues { get; set; }
        public int delay { get; private set; } = 0;
        public int testedValue { get; set; } = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> l = new List<int>();
            Performance mPerformance = new Performance();
            int arrayLaenge;

            //Richtextbox leeren
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
            elementCount.Text = "Anzahl der Elemente: " + arrayLaenge;
            #endregion

            #region Sicherheit
            /*if(arrayLaenge > 40)
            {
                MessageBox.Show("Bitte geben Sie maximal 40 Zahlen zum sortieren an.",
                    "Zu viele Zahlen",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }*/
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
                mMergeSort.sort(input,0, arrayLaenge-1, this);
                    
            }
            else if(comboBox1.Text == "Quick - Sort.")
            {
                mQuickSort.sort(input, 0, arrayLaenge - 1, this);
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
            time.Text = "Zeit: " + mPerformance.Duration;
            changesCount.Text = "Vertauschungen: " + changedValues;
            testedLabel.Text = "Prüfungen: " + testedValue;

            changedValues = 0;        
        }

        private void random_button_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            input_tB.Text += r.Next(1, 100)+ " ";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try {
                delay = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Random r = new Random();
                input_tB.Text += r.Next(1, 100) + " ";
                Thread.Sleep(100);
            }
        }
    }
}
