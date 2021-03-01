namespace buricmarioVjezba
{
    partial class but
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
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonObrisiStudenta = new System.Windows.Forms.Button();
            this.buttonObrisisve = new System.Windows.Forms.Button();
            this.listBoxStudenti = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(115, 44);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(217, 28);
            this.buttonDodaj.TabIndex = 0;
            this.buttonDodaj.Text = "Dodaj novog studenta";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonObrisiStudenta
            // 
            this.buttonObrisiStudenta.Location = new System.Drawing.Point(687, 199);
            this.buttonObrisiStudenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonObrisiStudenta.Name = "buttonObrisiStudenta";
            this.buttonObrisiStudenta.Size = new System.Drawing.Size(217, 28);
            this.buttonObrisiStudenta.TabIndex = 1;
            this.buttonObrisiStudenta.Text = "Obrisi studenta";
            this.buttonObrisiStudenta.UseVisualStyleBackColor = true;
            this.buttonObrisiStudenta.Click += new System.EventHandler(this.Button2_Click);
            // 
            // buttonObrisisve
            // 
            this.buttonObrisisve.Location = new System.Drawing.Point(115, 382);
            this.buttonObrisisve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonObrisisve.Name = "buttonObrisisve";
            this.buttonObrisisve.Size = new System.Drawing.Size(217, 28);
            this.buttonObrisisve.TabIndex = 2;
            this.buttonObrisisve.Text = "Obrisi sve studente";
            this.buttonObrisisve.UseVisualStyleBackColor = true;
            // 
            // listBoxStudenti
            // 
            this.listBoxStudenti.FormattingEnabled = true;
            this.listBoxStudenti.ItemHeight = 16;
            this.listBoxStudenti.Location = new System.Drawing.Point(115, 107);
            this.listBoxStudenti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxStudenti.Name = "listBoxStudenti";
            this.listBoxStudenti.Size = new System.Drawing.Size(504, 228);
            this.listBoxStudenti.TabIndex = 3;
            // 
            // but
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.listBoxStudenti);
            this.Controls.Add(this.buttonObrisisve);
            this.Controls.Add(this.buttonObrisiStudenta);
            this.Controls.Add(this.buttonDodaj);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "but";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonObrisiStudenta;
        private System.Windows.Forms.Button buttonObrisisve;
        private System.Windows.Forms.ListBox listBoxStudenti;
    }
}

