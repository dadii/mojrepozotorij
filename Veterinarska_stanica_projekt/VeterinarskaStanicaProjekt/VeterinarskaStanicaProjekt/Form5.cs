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
    public partial class FormaIspisKorisnika : Form
    {
        public FormaIspisKorisnika()
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

        private void FormaIspisKorisnika_Load(object sender, EventArgs e)
        {
            Konektiranje();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = "select korisnici.id_korisnika as ID,tip_korisnika.nazivTipKorisnika as tip_korisnika,korisnici.ime as ime,korisnici.prezime as prezime,korisnici.email as email,korisnici.korisnicko_ime as korisnicko_ime,korisnici.lozinka as lozinka from korisnici left join tip_korisnika on korisnici.tip_korisnika=tip_korisnika.id_tipaKorisnika";
           
            sql_cmd.ExecuteNonQuery();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql_cmd);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView_korisnici.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sql_con.Close();
        }

        private void button_obrisiKorisnika_Click(object sender, EventArgs e)
        {
            string vrijednost = dataGridView_korisnici.CurrentRow.Cells[0].Value.ToString();
            int vr = Convert.ToInt32(vrijednost);
            Konektiranje();
            sql_con.Open();
            sql_cmd1 = sql_con.CreateCommand();

            sql_cmd1.CommandText = "DELETE FROM korisnici WHERE id_korisnika = " + vr;

            sql_cmd1.ExecuteNonQuery();
            MessageBox.Show("Obrisali ste korisnika");
            sql_con.Close();
        }
    }
}
