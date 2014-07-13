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
    public partial class Forma_unos_ljubimca : Form
    {
        public Forma_unos_ljubimca()
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

        private void buttonUnesiLjubimca_Click(object sender, EventArgs e)
        {
            int vrsta_ljubimca;
            if (comboBox_vrsta.SelectedIndex == 0)
            {
                vrsta_ljubimca = 1;
            }
            else if (comboBox_vrsta.SelectedIndex == 1)
            {
                vrsta_ljubimca = 2;
            }
            else if (comboBox_vrsta.SelectedIndex == 2)
            {
                vrsta_ljubimca = 3;
            }
            else if (comboBox_vrsta.SelectedIndex == 3)
            {
                vrsta_ljubimca = 4;
            }
            else if (comboBox_vrsta.SelectedIndex == 4)
            {
                vrsta_ljubimca = 5;
            }
            else if (comboBox_vrsta.SelectedIndex == 5)
            {
                vrsta_ljubimca = 6;
            }
            else 
            {
                vrsta_ljubimca = 7;
            }

        
            Konektiranje();
            sql_con.Open();
            sql_cmd1 = sql_con.CreateCommand();
            sql_cmd1.CommandText = "select * from korisnici where korisnicko_ime='" + textBox_imeVlasnika.Text.ToString() + "'";
            sql_cmd1.ExecuteNonQuery();
            SQLiteDataReader dr = sql_cmd1.ExecuteReader();
            int vlasnik1;

            if (dr.Read())
            {
                vlasnik1 = dr.GetInt32(0);
                sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandText = "insert into ljubimci('tip_ljubimca','pasmina','starost','naziv','vlasnik','karton') values (" + vrsta_ljubimca + ",'" + textBox_pasmina.Text.ToString() + "','" + textBox_starost.Text.ToString() + "','" + textBox_ime_ljubimca.Text.ToString() + "'," + vlasnik1 + ",(SELECT MAX(id_ljubimca) + 1 FROM ljubimci))";
                sql_cmd.ExecuteNonQuery();
                this.Close();
                MessageBox.Show("Uspješno ste dodali ljubimca");
                sql_con.Close();
            }
            else
            {
                MessageBox.Show("Ne postoji vlasnik");
            }
        
        }
    }
}
