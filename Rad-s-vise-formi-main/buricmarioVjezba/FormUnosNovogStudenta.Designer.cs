namespace buricmarioVjezba
{
    partial class FormUnosNovogStudenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonSnimi = new System.Windows.Forms.Button();
            this.buttonOtkazi = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelBrojIndeksa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(139, 63);
            this.textBoxIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(132, 22);
            this.textBoxIme.TabIndex = 0;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(139, 159);
            this.textBoxPrezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(132, 22);
            this.textBoxPrezime.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(583, 63);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 2;
            // 
            // buttonSnimi
            // 
            this.buttonSnimi.Location = new System.Drawing.Point(139, 341);
            this.buttonSnimi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSnimi.Name = "buttonSnimi";
            this.buttonSnimi.Size = new System.Drawing.Size(100, 28);
            this.buttonSnimi.TabIndex = 3;
            this.buttonSnimi.Text = "Snimi";
            this.buttonSnimi.UseVisualStyleBackColor = true;
            this.buttonSnimi.Click += new System.EventHandler(this.buttonSnimi_Click);
            // 
            // buttonOtkazi
            // 
            this.buttonOtkazi.Location = new System.Drawing.Point(775, 341);
            this.buttonOtkazi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOtkazi.Name = "buttonOtkazi";
            this.buttonOtkazi.Size = new System.Drawing.Size(100, 28);
            this.buttonOtkazi.TabIndex = 4;
            this.buttonOtkazi.Text = "Otkazi";
            this.buttonOtkazi.UseVisualStyleBackColor = true;
            this.buttonOtkazi.Click += new System.EventHandler(this.buttonOtkazi_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Programer",
            "Sistem administrator",
            "Mrežni administrator"});
            this.comboBox1.Location = new System.Drawing.Point(139, 258);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(583, 159);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prezime :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Smjer :";
            // 
            // labelBrojIndeksa
            // 
            this.labelBrojIndeksa.AutoSize = true;
            this.labelBrojIndeksa.Location = new System.Drawing.Point(579, 32);
            this.labelBrojIndeksa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBrojIndeksa.Name = "labelBrojIndeksa";
            this.labelBrojIndeksa.Size = new System.Drawing.Size(90, 17);
            this.labelBrojIndeksa.TabIndex = 10;
            this.labelBrojIndeksa.Text = "Broj indeksa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(579, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Datum rođenja :";
            // 
            // FormUnosNovogStudenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelBrojIndeksa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonOtkazi);
            this.Controls.Add(this.buttonSnimi);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormUnosNovogStudenta";
            this.Text = "FormUnosNovogStudenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonSnimi;
        private System.Windows.Forms.Button buttonOtkazi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelBrojIndeksa;
        private System.Windows.Forms.Label label4;
    }
}