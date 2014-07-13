namespace VeterinarskaStanicaProjekt
{
    partial class Forma_unos_ljubimca
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
            this.buttonUnesiLjubimca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ime_ljubimca = new System.Windows.Forms.TextBox();
            this.textBox_pasmina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_vrsta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_starost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_imeVlasnika = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonUnesiLjubimca
            // 
            this.buttonUnesiLjubimca.Location = new System.Drawing.Point(186, 242);
            this.buttonUnesiLjubimca.Name = "buttonUnesiLjubimca";
            this.buttonUnesiLjubimca.Size = new System.Drawing.Size(75, 23);
            this.buttonUnesiLjubimca.TabIndex = 0;
            this.buttonUnesiLjubimca.Text = "Unesi";
            this.buttonUnesiLjubimca.UseVisualStyleBackColor = true;
            this.buttonUnesiLjubimca.Click += new System.EventHandler(this.buttonUnesiLjubimca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime  :";
            // 
            // textBox_ime_ljubimca
            // 
            this.textBox_ime_ljubimca.Location = new System.Drawing.Point(108, 110);
            this.textBox_ime_ljubimca.Name = "textBox_ime_ljubimca";
            this.textBox_ime_ljubimca.Size = new System.Drawing.Size(153, 20);
            this.textBox_ime_ljubimca.TabIndex = 2;
            // 
            // textBox_pasmina
            // 
            this.textBox_pasmina.Location = new System.Drawing.Point(108, 69);
            this.textBox_pasmina.Name = "textBox_pasmina";
            this.textBox_pasmina.Size = new System.Drawing.Size(153, 20);
            this.textBox_pasmina.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pasmina :";
            // 
            // comboBox_vrsta
            // 
            this.comboBox_vrsta.FormattingEnabled = true;
            this.comboBox_vrsta.Items.AddRange(new object[] {
            "pas",
            "mačka",
            "glodavac",
            "gmaz",
            "riba",
            "ptica",
            "ostalo"});
            this.comboBox_vrsta.Location = new System.Drawing.Point(108, 25);
            this.comboBox_vrsta.Name = "comboBox_vrsta";
            this.comboBox_vrsta.Size = new System.Drawing.Size(121, 21);
            this.comboBox_vrsta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vrsta  :";
            // 
            // textBox_starost
            // 
            this.textBox_starost.Location = new System.Drawing.Point(108, 150);
            this.textBox_starost.Name = "textBox_starost";
            this.textBox_starost.Size = new System.Drawing.Size(33, 20);
            this.textBox_starost.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Starost  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vlasnik  :";
            // 
            // textBox_imeVlasnika
            // 
            this.textBox_imeVlasnika.Location = new System.Drawing.Point(108, 193);
            this.textBox_imeVlasnika.Name = "textBox_imeVlasnika";
            this.textBox_imeVlasnika.Size = new System.Drawing.Size(153, 20);
            this.textBox_imeVlasnika.TabIndex = 10;
            // 
            // Forma_unos_ljubimca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 330);
            this.Controls.Add(this.textBox_imeVlasnika);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_starost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_vrsta);
            this.Controls.Add(this.textBox_pasmina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ime_ljubimca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUnesiLjubimca);
            this.Name = "Forma_unos_ljubimca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos Ljubimca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUnesiLjubimca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ime_ljubimca;
        private System.Windows.Forms.TextBox textBox_pasmina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_vrsta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_starost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_imeVlasnika;
    }
}