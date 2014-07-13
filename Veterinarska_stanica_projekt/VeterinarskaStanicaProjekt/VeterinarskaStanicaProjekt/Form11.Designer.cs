namespace VeterinarskaStanicaProjekt
{
    partial class FormaIspisRacuna
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
            this.dataGridView_IspisRacuna = new System.Windows.Forms.DataGridView();
            this.buttonStavke = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_IspisRacuna)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_IspisRacuna
            // 
            this.dataGridView_IspisRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_IspisRacuna.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_IspisRacuna.Name = "dataGridView_IspisRacuna";
            this.dataGridView_IspisRacuna.Size = new System.Drawing.Size(501, 426);
            this.dataGridView_IspisRacuna.TabIndex = 0;
            // 
            // buttonStavke
            // 
            this.buttonStavke.Location = new System.Drawing.Point(12, 449);
            this.buttonStavke.Name = "buttonStavke";
            this.buttonStavke.Size = new System.Drawing.Size(75, 23);
            this.buttonStavke.TabIndex = 1;
            this.buttonStavke.Text = "Pogledaj";
            this.buttonStavke.UseVisualStyleBackColor = true;
            this.buttonStavke.Click += new System.EventHandler(this.buttonStavke_Click);
            // 
            // FormaIspisRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 484);
            this.Controls.Add(this.buttonStavke);
            this.Controls.Add(this.dataGridView_IspisRacuna);
            this.Name = "FormaIspisRacuna";
            this.Text = "Računi";
            this.Load += new System.EventHandler(this.FormaIspisRacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_IspisRacuna)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_IspisRacuna;
        private System.Windows.Forms.Button buttonStavke;
    }
}