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
    
    public partial class FormaPrijava : Form
    {
        public FormaPrijava()
        {
            InitializeComponent();
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;

        private void Konektiranje()
        {
            sql_con = new SQLiteConnection("Data Source=baza_veterinarska_stanica.sql;Version=3;New=False;Compress=True;");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Konektiranje();
            try
            {
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandText = "select * from korisnici where korisnicko_ime = '" + this.textBox_korime.Text.ToString() + "' and lozinka = '" + this.textBox_lozinka.Text.ToString() + "'";
                sql_cmd.ExecuteNonQuery();

                SQLiteDataReader dr = sql_cmd.ExecuteReader();

                int broj = 0;
                int tk = 0;
                int serBr = 0;

                while (dr.Read())
                {
                    broj++;
                    tk = dr.GetInt32(1);
                    serBr = dr.GetInt32(0);
                }
                if (broj == 1)
                {
                    if (tk == 1)
                    {
                        
                        int serial = Convert.ToInt32(serBr);
                        
                        FormaKorisnik novaFormaKorisnik = new FormaKorisnik(serial);
                        this.Hide();
                        novaFormaKorisnik.Show();
                              
                    }
                    else
                    {
                        FormaAdmin novaFormaAdmin = new FormaAdmin();
                        this.Hide();
                        novaFormaAdmin.Show();
                        
                    }
                }
                else
                {
                    labelPoruka.Text = "Pogrešan Unos";
                    labelPoruka.ForeColor = System.Drawing.Color.Red;
                    labelPoruka.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sql_con.Close();            

        }
    }
}
