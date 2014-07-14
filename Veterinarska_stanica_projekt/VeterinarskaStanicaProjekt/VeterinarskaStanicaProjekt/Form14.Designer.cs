namespace VeterinarskaStanicaProjekt
{
    partial class FormazaPregledUsluga
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
            this.dataGridViewPregledUsluga = new System.Windows.Forms.DataGridView();
            this.buttonBrisanjeUsluge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPregledUsluga)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPregledUsluga
            // 
            this.dataGridViewPregledUsluga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPregledUsluga.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewPregledUsluga.Name = "dataGridViewPregledUsluga";
            this.dataGridViewPregledUsluga.Size = new System.Drawing.Size(498, 433);
            this.dataGridViewPregledUsluga.TabIndex = 0;
            // 
            // buttonBrisanjeUsluge
            // 
            this.buttonBrisanjeUsluge.Location = new System.Drawing.Point(13, 464);
            this.buttonBrisanjeUsluge.Name = "buttonBrisanjeUsluge";
            this.buttonBrisanjeUsluge.Size = new System.Drawing.Size(75, 23);
            this.buttonBrisanjeUsluge.TabIndex = 1;
            this.buttonBrisanjeUsluge.Text = "Brisanje";
            this.buttonBrisanjeUsluge.UseVisualStyleBackColor = true;
            this.buttonBrisanjeUsluge.Click += new System.EventHandler(this.buttonBrisanjeUsluge_Click);
            // 
            // FormazaPregledUsluga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 506);
            this.Controls.Add(this.buttonBrisanjeUsluge);
            this.Controls.Add(this.dataGridViewPregledUsluga);
            this.Name = "FormazaPregledUsluga";
            this.Text = "Usluge";
            this.Load += new System.EventHandler(this.FormazaPregledUsluga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPregledUsluga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPregledUsluga;
        private System.Windows.Forms.Button buttonBrisanjeUsluge;
    }
}