﻿namespace SortAlgo
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sort_button = new System.Windows.Forms.Button();
            this.input_tB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.testedLabel = new System.Windows.Forms.Label();
            this.changesCount = new System.Windows.Forms.Label();
            this.elementCount = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.random_button = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sort_button
            // 
            this.sort_button.Location = new System.Drawing.Point(197, 235);
            this.sort_button.Name = "sort_button";
            this.sort_button.Size = new System.Drawing.Size(75, 23);
            this.sort_button.TabIndex = 0;
            this.sort_button.Text = "Sortieren";
            this.sort_button.UseVisualStyleBackColor = true;
            this.sort_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // input_tB
            // 
            this.input_tB.Location = new System.Drawing.Point(12, 36);
            this.input_tB.Name = "input_tB";
            this.input_tB.Size = new System.Drawing.Size(100, 20);
            this.input_tB.TabIndex = 1;
            this.input_tB.Text = "3 2 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bubble - Sort.",
            "Insertation - Sort.",
            "Merge - Sort.",
            "Quick - Sort.",
            "Selection - Sort."});
            this.comboBox1.Location = new System.Drawing.Point(12, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Algorithmus";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.testedLabel);
            this.groupBox1.Controls.Add(this.changesCount);
            this.groupBox1.Controls.Add(this.elementCount);
            this.groupBox1.Controls.Add(this.time);
            this.groupBox1.Location = new System.Drawing.Point(15, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 79);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auswertung:";
            // 
            // testedLabel
            // 
            this.testedLabel.AutoSize = true;
            this.testedLabel.Location = new System.Drawing.Point(6, 55);
            this.testedLabel.Name = "testedLabel";
            this.testedLabel.Size = new System.Drawing.Size(62, 13);
            this.testedLabel.TabIndex = 13;
            this.testedLabel.Text = "Prüfungen: ";
            // 
            // changesCount
            // 
            this.changesCount.AutoSize = true;
            this.changesCount.Location = new System.Drawing.Point(6, 42);
            this.changesCount.Name = "changesCount";
            this.changesCount.Size = new System.Drawing.Size(88, 13);
            this.changesCount.TabIndex = 12;
            this.changesCount.Text = "Vertauschungen:";
            // 
            // elementCount
            // 
            this.elementCount.AutoSize = true;
            this.elementCount.Location = new System.Drawing.Point(6, 29);
            this.elementCount.Name = "elementCount";
            this.elementCount.Size = new System.Drawing.Size(110, 13);
            this.elementCount.TabIndex = 8;
            this.elementCount.Text = "Anzahl der Elemente: ";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(6, 16);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(28, 13);
            this.time.TabIndex = 0;
            this.time.Text = "Zeit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Schritte:";
            // 
            // random_button
            // 
            this.random_button.Location = new System.Drawing.Point(118, 33);
            this.random_button.Name = "random_button";
            this.random_button.Size = new System.Drawing.Size(59, 23);
            this.random_button.TabIndex = 10;
            this.random_button.Text = "Random";
            this.random_button.UseVisualStyleBackColor = true;
            this.random_button.Click += new System.EventHandler(this.random_button_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(278, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(292, 221);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Verzögerung:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 35);
            this.button2.TabIndex = 15;
            this.button2.Text = "10x Random";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 270);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.random_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_tB);
            this.Controls.Add(this.sort_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SortAlgo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sort_button;
        private System.Windows.Forms.TextBox input_tB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label elementCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button random_button;
        internal System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label changesCount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label testedLabel;
    }
}

