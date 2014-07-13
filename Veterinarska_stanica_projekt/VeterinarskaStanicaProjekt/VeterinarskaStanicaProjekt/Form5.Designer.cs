namespace VeterinarskaStanicaProjekt
{
    partial class FormaIspisKorisnika
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
            this.dataGridView_korisnici = new System.Windows.Forms.DataGridView();
            this.button_obrisiKorisnika = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_korisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_korisnici
            // 
            this.dataGridView_korisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_korisnici.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_korisnici.Name = "dataGridView_korisnici";
            this.dataGridView_korisnici.Size = new System.Drawing.Size(743, 429);
            this.dataGridView_korisnici.TabIndex = 0;
            // 
            // button_obrisiKorisnika
            // 
            this.button_obrisiKorisnika.Location = new System.Drawing.Point(13, 460);
            this.button_obrisiKorisnika.Name = "button_obrisiKorisnika";
            this.button_obrisiKorisnika.Size = new System.Drawing.Size(75, 23);
            this.button_obrisiKorisnika.TabIndex = 1;
            this.button_obrisiKorisnika.Text = "Obriši";
            this.button_obrisiKorisnika.UseVisualStyleBackColor = true;
            this.button_obrisiKorisnika.Click += new System.EventHandler(this.button_obrisiKorisnika_Click);
            // 
            // FormaIspisKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 498);
            this.Controls.Add(this.button_obrisiKorisnika);
            this.Controls.Add(this.dataGridView_korisnici);
            this.Name = "FormaIspisKorisnika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Korisnici";
            this.Load += new System.EventHandler(this.FormaIspisKorisnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_korisnici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_korisnici;
        private System.Windows.Forms.Button button_obrisiKorisnika;
    }
}