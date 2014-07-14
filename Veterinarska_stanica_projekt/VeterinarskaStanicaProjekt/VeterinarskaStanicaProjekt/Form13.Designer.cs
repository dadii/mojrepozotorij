namespace VeterinarskaStanicaProjekt
{
    partial class formDodajUslugu
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
            this.buttonDodajUslugu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNazivUsluge = new System.Windows.Forms.TextBox();
            this.textBoxCijenaUsluge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDodajUslugu
            // 
            this.buttonDodajUslugu.Location = new System.Drawing.Point(137, 141);
            this.buttonDodajUslugu.Name = "buttonDodajUslugu";
            this.buttonDodajUslugu.Size = new System.Drawing.Size(75, 23);
            this.buttonDodajUslugu.TabIndex = 0;
            this.buttonDodajUslugu.Text = "Dodaj";
            this.buttonDodajUslugu.UseVisualStyleBackColor = true;
            this.buttonDodajUslugu.Click += new System.EventHandler(this.buttonDodajUslugu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv usluge : ";
            // 
            // textBoxNazivUsluge
            // 
            this.textBoxNazivUsluge.Location = new System.Drawing.Point(137, 39);
            this.textBoxNazivUsluge.Name = "textBoxNazivUsluge";
            this.textBoxNazivUsluge.Size = new System.Drawing.Size(185, 20);
            this.textBoxNazivUsluge.TabIndex = 2;
            // 
            // textBoxCijenaUsluge
            // 
            this.textBoxCijenaUsluge.Location = new System.Drawing.Point(137, 92);
            this.textBoxCijenaUsluge.Name = "textBoxCijenaUsluge";
            this.textBoxCijenaUsluge.Size = new System.Drawing.Size(75, 20);
            this.textBoxCijenaUsluge.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cijena usluge : ";
            // 
            // formDodajUslugu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 210);
            this.Controls.Add(this.textBoxCijenaUsluge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNazivUsluge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDodajUslugu);
            this.Name = "formDodajUslugu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje usluga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDodajUslugu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNazivUsluge;
        private System.Windows.Forms.TextBox textBoxCijenaUsluge;
        private System.Windows.Forms.Label label2;
    }
}