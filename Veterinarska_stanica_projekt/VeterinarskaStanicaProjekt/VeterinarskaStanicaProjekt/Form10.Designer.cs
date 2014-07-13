namespace VeterinarskaStanicaProjekt
{
    partial class FormPovijestBolesti
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
            this.dataGridViewPovijestBolesti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPovijestBolesti)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPovijestBolesti
            // 
            this.dataGridViewPovijestBolesti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPovijestBolesti.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPovijestBolesti.Name = "dataGridViewPovijestBolesti";
            this.dataGridViewPovijestBolesti.Size = new System.Drawing.Size(651, 492);
            this.dataGridViewPovijestBolesti.TabIndex = 0;
            // 
            // FormPovijestBolesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 516);
            this.Controls.Add(this.dataGridViewPovijestBolesti);
            this.Name = "FormPovijestBolesti";
            this.Text = "Povijest bolesti";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPovijestBolesti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPovijestBolesti;
    }
}