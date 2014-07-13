namespace VeterinarskaStanicaProjekt
{
    partial class FormaUnosKorisnika
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
            this.buttonUnos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Ime = new System.Windows.Forms.TextBox();
            this.textBox_Prezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Korime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Lozinka = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_Admin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonUnos
            // 
            this.buttonUnos.Location = new System.Drawing.Point(118, 312);
            this.buttonUnos.Name = "buttonUnos";
            this.buttonUnos.Size = new System.Drawing.Size(75, 23);
            this.buttonUnos.TabIndex = 0;
            this.buttonUnos.Text = "Unos";
            this.buttonUnos.UseVisualStyleBackColor = true;
            this.buttonUnos.Click += new System.EventHandler(this.buttonUnos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime :";
            // 
            // textBox_Ime
            // 
            this.textBox_Ime.Location = new System.Drawing.Point(118, 43);
            this.textBox_Ime.Name = "textBox_Ime";
            this.textBox_Ime.Size = new System.Drawing.Size(168, 20);
            this.textBox_Ime.TabIndex = 2;
            // 
            // textBox_Prezime
            // 
            this.textBox_Prezime.Location = new System.Drawing.Point(118, 89);
            this.textBox_Prezime.Name = "textBox_Prezime";
            this.textBox_Prezime.Size = new System.Drawing.Size(168, 20);
            this.textBox_Prezime.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezime :";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(118, 132);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(168, 20);
            this.textBox_Email.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-mail :";
            // 
            // textBox_Korime
            // 
            this.textBox_Korime.Location = new System.Drawing.Point(118, 176);
            this.textBox_Korime.Name = "textBox_Korime";
            this.textBox_Korime.Size = new System.Drawing.Size(168, 20);
            this.textBox_Korime.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Korisnicko ime :";
            // 
            // textBox_Lozinka
            // 
            this.textBox_Lozinka.Location = new System.Drawing.Point(118, 220);
            this.textBox_Lozinka.Name = "textBox_Lozinka";
            this.textBox_Lozinka.Size = new System.Drawing.Size(168, 20);
            this.textBox_Lozinka.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lozinka :";
            // 
            // checkBox_Admin
            // 
            this.checkBox_Admin.AutoSize = true;
            this.checkBox_Admin.Location = new System.Drawing.Point(118, 266);
            this.checkBox_Admin.Name = "checkBox_Admin";
            this.checkBox_Admin.Size = new System.Drawing.Size(55, 17);
            this.checkBox_Admin.TabIndex = 12;
            this.checkBox_Admin.Text = "Admin";
            this.checkBox_Admin.UseVisualStyleBackColor = true;
            // 
            // FormaUnosKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 384);
            this.Controls.Add(this.checkBox_Admin);
            this.Controls.Add(this.textBox_Lozinka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Korime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Prezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Ime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUnos);
            this.Name = "FormaUnosKorisnika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos korisnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Ime;
        private System.Windows.Forms.TextBox textBox_Prezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Korime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Lozinka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_Admin;
    }
}