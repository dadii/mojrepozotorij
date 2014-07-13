using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;

namespace VeterinarskaStanicaProjekt
{
    public partial class FormaUnosKorisnika : Form
    {
        public FormaUnosKorisnika()
        {
            InitializeComponent();
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteCommand sql_cmd1;

        private void Konektiranje()
        {
            sql_con = new SQLiteConnection("Data Source=baza_veterinarska_stanica.sql;Version=3;New=False;Compress=True;");
        }

        private void buttonUnos_Click(object sender, EventArgs e)
        {
            int admn = 1;
            if (checkBox_Admin.Checked)
            {
                admn = 2;
            }
            Konektiranje();
            sql_con.Open();

            sql_cmd1 = sql_con.CreateCommand();
            sql_cmd1.CommandText = "select * from korisnici where korisnicko_ime = '" + textBox_Korime.Text.ToString() + "' or email = '" + textBox_Email.Text.ToString()+"'";
            sql_cmd1.ExecuteNonQuery();
            SQLiteDataReader dr = sql_cmd1.ExecuteReader();   

            if (dr.Read())
            {
                MessageBox.Show("Pogrešan unos");
                sql_con.Close();
            }
            else
            {   
                sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandText = "insert into korisnici('tip_korisnika','ime','prezime','email','korisnicko_ime','lozinka') values (" + admn + ",'" + textBox_Ime.Text.ToString() + "','" + textBox_Prezime.Text.ToString() + "','" + textBox_Email.Text.ToString() + "','" + textBox_Korime.Text.ToString() + "','" + textBox_Lozinka.Text.ToString() + "')";
                sql_cmd.ExecuteNonQuery();
                this.Close();
                MessageBox.Show("Uspješno ste dodali korisnika");
                sql_con.Close();
            }
        }

    }
}
