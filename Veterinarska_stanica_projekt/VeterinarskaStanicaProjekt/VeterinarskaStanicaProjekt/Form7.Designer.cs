namespace VeterinarskaStanicaProjekt
{
    partial class FormaIspisLJubimaca
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
            this.dataGridView_ljubimci = new System.Windows.Forms.DataGridView();
            this.buttonPregledPovijestiBolesti = new System.Windows.Forms.Button();
            this.button_obrisiLJubimca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ljubimci)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ljubimci
            // 
            this.dataGridView_ljubimci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ljubimci.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_ljubimci.Name = "dataGridView_ljubimci";
            this.dataGridView_ljubimci.Size = new System.Drawing.Size(791, 552);
            this.dataGridView_ljubimci.TabIndex = 0;
            // 
            // buttonPregledPovijestiBolesti
            // 
            this.buttonPregledPovijestiBolesti.Location = new System.Drawing.Point(12, 585);
            this.buttonPregledPovijestiBolesti.Name = "buttonPregledPovijestiBolesti";
            this.buttonPregledPovijestiBolesti.Size = new System.Drawing.Size(110, 23);
            this.buttonPregledPovijestiBolesti.TabIndex = 1;
            this.buttonPregledPovijestiBolesti.Text = "Povijest bolesti";
            this.buttonPregledPovijestiBolesti.UseVisualStyleBackColor = true;
            this.buttonPregledPovijestiBolesti.Click += new System.EventHandler(this.buttonPregledPovijestiBolesti_Click);
            // 
            // button_obrisiLJubimca
            // 
            this.button_obrisiLJubimca.Location = new System.Drawing.Point(151, 585);
            this.button_obrisiLJubimca.Name = "button_obrisiLJubimca";
            this.button_obrisiLJubimca.Size = new System.Drawing.Size(61, 23);
            this.button_obrisiLJubimca.TabIndex = 2;
            this.button_obrisiLJubimca.Text = "Obriši";
            this.button_obrisiLJubimca.UseVisualStyleBackColor = true;
            this.button_obrisiLJubimca.Click += new System.EventHandler(this.button_obrisiLJubimca_Click);
            // 
            // FormaIspisLJubimaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 620);
            this.Controls.Add(this.button_obrisiLJubimca);
            this.Controls.Add(this.buttonPregledPovijestiBolesti);
            this.Controls.Add(this.dataGridView_ljubimci);
            this.Name = "FormaIspisLJubimaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ljubimci";
            this.Load += new System.EventHandler(this.FormaIspisLJubimaca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ljubimci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ljubimci;
        private System.Windows.Forms.Button buttonPregledPovijestiBolesti;
        private System.Windows.Forms.Button button_obrisiLJubimca;
    }
}