namespace VeterinarskaStanicaProjekt
{
    partial class FormaStavkiRacuna
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
            this.dataGridViewStavkeRacuna = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStavkeRacuna)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStavkeRacuna
            // 
            this.dataGridViewStavkeRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStavkeRacuna.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewStavkeRacuna.Name = "dataGridViewStavkeRacuna";
            this.dataGridViewStavkeRacuna.Size = new System.Drawing.Size(425, 511);
            this.dataGridViewStavkeRacuna.TabIndex = 0;
            // 
            // FormaStavkiRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 536);
            this.Controls.Add(this.dataGridViewStavkeRacuna);
            this.Name = "FormaStavkiRacuna";
            this.Text = "Stavke računa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStavkeRacuna)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStavkeRacuna;
    }
}