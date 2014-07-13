namespace VeterinarskaStanicaProjekt
{
    partial class FormaPregled
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
            this.buttonUnosPovijest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxImeLjubimca = new System.Windows.Forms.TextBox();
            this.textBox_datumPregleda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_UnosPovijestBolesti = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_pomoc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonNaplati = new System.Windows.Forms.Button();
            this.dataGridViewPopisUsluga = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPopisUsluga)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUnosPovijest
            // 
            this.buttonUnosPovijest.Location = new System.Drawing.Point(111, 526);
            this.buttonUnosPovijest.Name = "buttonUnosPovijest";
            this.buttonUnosPovijest.Size = new System.Drawing.Size(75, 23);
            this.buttonUnosPovijest.TabIndex = 1;
            this.buttonUnosPovijest.Text = "Unos";
            this.buttonUnosPovijest.UseVisualStyleBackColor = true;
            this.buttonUnosPovijest.Click += new System.EventHandler(this.buttonUnosPovijest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ljubimac :";
            // 
            // textBoxImeLjubimca
            // 
            this.textBoxImeLjubimca.Location = new System.Drawing.Point(111, 43);
            this.textBoxImeLjubimca.Name = "textBoxImeLjubimca";
            this.textBoxImeLjubimca.ReadOnly = true;
            this.textBoxImeLjubimca.Size = new System.Drawing.Size(140, 20);
            this.textBoxImeLjubimca.TabIndex = 3;
            // 
            // textBox_datumPregleda
            // 
            this.textBox_datumPregleda.Location = new System.Drawing.Point(111, 91);
            this.textBox_datumPregleda.Name = "textBox_datumPregleda";
            this.textBox_datumPregleda.ReadOnly = true;
            this.textBox_datumPregleda.Size = new System.Drawing.Size(140, 20);
            this.textBox_datumPregleda.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datum :";
            // 
            // textBox_UnosPovijestBolesti
            // 
            this.textBox_UnosPovijestBolesti.Location = new System.Drawing.Point(111, 140);
            this.textBox_UnosPovijestBolesti.Multiline = true;
            this.textBox_UnosPovijestBolesti.Name = "textBox_UnosPovijestBolesti";
            this.textBox_UnosPovijestBolesti.Size = new System.Drawing.Size(256, 108);
            this.textBox_UnosPovijestBolesti.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Unos :";
            // 
            // label_pomoc
            // 
            this.label_pomoc.AutoSize = true;
            this.label_pomoc.Location = new System.Drawing.Point(407, 536);
            this.label_pomoc.Name = "label_pomoc";
            this.label_pomoc.Size = new System.Drawing.Size(35, 13);
            this.label_pomoc.TabIndex = 10;
            this.label_pomoc.Text = "label3";
            this.label_pomoc.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Usluge :";
            // 
            // buttonNaplati
            // 
            this.buttonNaplati.Location = new System.Drawing.Point(208, 526);
            this.buttonNaplati.Name = "buttonNaplati";
            this.buttonNaplati.Size = new System.Drawing.Size(75, 23);
            this.buttonNaplati.TabIndex = 13;
            this.buttonNaplati.Text = "Naplati";
            this.buttonNaplati.UseVisualStyleBackColor = true;
            this.buttonNaplati.Click += new System.EventHandler(this.buttonNaplati_Click);
            // 
            // dataGridViewPopisUsluga
            // 
            this.dataGridViewPopisUsluga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPopisUsluga.Location = new System.Drawing.Point(111, 274);
            this.dataGridViewPopisUsluga.Name = "dataGridViewPopisUsluga";
            this.dataGridViewPopisUsluga.Size = new System.Drawing.Size(331, 229);
            this.dataGridViewPopisUsluga.TabIndex = 14;
            // 
            // FormaPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 593);
            this.Controls.Add(this.dataGridViewPopisUsluga);
            this.Controls.Add(this.buttonNaplati);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_pomoc);
            this.Controls.Add(this.textBox_UnosPovijestBolesti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_datumPregleda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxImeLjubimca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUnosPovijest);
            this.Name = "FormaPregled";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPopisUsluga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUnosPovijest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxImeLjubimca;
        private System.Windows.Forms.TextBox textBox_datumPregleda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_UnosPovijestBolesti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_pomoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonNaplati;
        private System.Windows.Forms.DataGridView dataGridViewPopisUsluga;
    }
}