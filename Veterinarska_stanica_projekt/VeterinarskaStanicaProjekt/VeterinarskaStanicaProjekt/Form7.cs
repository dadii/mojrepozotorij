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
    public partial class FormaIspisLJubimaca : Form
    {
        public FormaIspisLJubimaca()
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
        private void FormaIspisLJubimaca_Load(object sender, EventArgs e)
        {
            Konektiranje();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = "select ljubimci.id_ljubimca as ID,tipovi_ljubimaca.naziv_tipa as tip,ljubimci.pasmina as pasmina,ljubimci.starost as starost,ljubimci.naziv as ime,korisnici.korisnicko_ime as vlasnik from ljubimci left join korisnici on korisnici.id_korisnika=ljubimci.vlasnik left join tipovi_ljubimaca on ljubimci.tip_ljubimca=tipovi_ljubimaca.id_tipa_ljubimca";
            sql_cmd.ExecuteNonQuery();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql_cmd);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView_ljubimci.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sql_con.Close();
        }

        private void buttonPregledPovijestiBolesti_Click(object sender, EventArgs e)
        {
            string vrijednost = dataGridView_ljubimci.CurrentRow.Cells[0].Value.ToString();
            int vr = Convert.ToInt32(vrijednost);
            FormPovijestBolesti povBolesti = new FormPovijestBolesti(vr);
            povBolesti.Show();
        }

        private void button_obrisiLJubimca_Click(object sender, EventArgs e)
        {
            string vrijednost = dataGridView_ljubimci.CurrentRow.Cells[0].Value.ToString();
            int vr = Convert.ToInt32(vrijednost);
            Konektiranje();
            sql_con.Open();
            sql_cmd1 = sql_con.CreateCommand();

            sql_cmd1.CommandText = "DELETE FROM ljubimci WHERE id_ljubimca = " + vr;

            sql_cmd1.ExecuteNonQuery();
            MessageBox.Show("Obrisali ste ljubimca");
            sql_con.Close();
        }
    }
}
