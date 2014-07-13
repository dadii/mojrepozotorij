namespace VeterinarskaStanicaProjekt
{
    partial class FormaPrijava
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_korime = new System.Windows.Forms.TextBox();
            this.textBox_lozinka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPoruka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko ime :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Prijava";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_korime
            // 
            this.textBox_korime.Location = new System.Drawing.Point(144, 37);
            this.textBox_korime.Name = "textBox_korime";
            this.textBox_korime.Size = new System.Drawing.Size(141, 20);
            this.textBox_korime.TabIndex = 2;
            // 
            // textBox_lozinka
            // 
            this.textBox_lozinka.Location = new System.Drawing.Point(144, 77);
            this.textBox_lozinka.Name = "textBox_lozinka";
            this.textBox_lozinka.Size = new System.Drawing.Size(141, 20);
            this.textBox_lozinka.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lozinka :";
            // 
            // labelPoruka
            // 
            this.labelPoruka.AutoSize = true;
            this.labelPoruka.Location = new System.Drawing.Point(141, 163);
            this.labelPoruka.Name = "labelPoruka";
            this.labelPoruka.Size = new System.Drawing.Size(62, 13);
            this.labelPoruka.TabIndex = 5;
            this.labelPoruka.Text = "** poruka **";
            this.labelPoruka.Visible = false;
            // 
            // FormaPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 205);
            this.Controls.Add(this.labelPoruka);
            this.Controls.Add(this.textBox_lozinka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_korime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FormaPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_korime;
        private System.Windows.Forms.TextBox textBox_lozinka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPoruka;
    }
}

