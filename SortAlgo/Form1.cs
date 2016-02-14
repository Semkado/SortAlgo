using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SortAlgo.Algorithmen;

namespace SortAlgo
{
    public partial class Form1 : Form
    {
        SelectionSort mSelectionSort = new SelectionSort();
        InsertationSort mInsertationSort = new InsertationSort();
        BubbleSort mBubbleSort = new BubbleSort();

        List<int> l = new List<int>();


        int[] output;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Performance mPerformance = new Performance();
            int arrayLaenge;

            mPerformance.Start();
            #region Textbox to String List
            char[] delimiterChars = { ' ', ';'}; //Zeichen, bei denen gesplittet werden soll
            string text = textBox1.Text; //Text aus der Textbox
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

            #region String List to Int[]
            int[] input = l.ToArray();
            arrayLaenge = input.Length;
            label6.Text = "Anzahl der Elemente: " + arrayLaenge;
            #endregion

            //Sortieralgorithmen wählen
            switch (comboBox1.Text)
            {
                case "Selection - Sort.":
                    output = mSelectionSort.sort(input, arrayLaenge-1);
                        break;
                case "Insertation - Sort.":
                    output = mInsertationSort.sort(input, arrayLaenge - 1);
                    break;
                case "Bubble - Sort.":
                    output = mBubbleSort.sort(input, arrayLaenge - 1);
                    break;
                case "<bitte wählen>": MessageBox.Show("Bitte geben sie ein Verfahren an!");
                    break;
                default: MessageBox.Show("Bitte tragen sie in Input ein paar Zeichen ein und wählen sie ein Sortierverfahren!");
                    break;
            }

            if(output != null)
            {
                textBox2.Text = string.Join("", output);
            }

            output = null;
            mPerformance.Stop();
            label4.Text = "Zeit: " + mPerformance.Duration;
        }
    }
}
