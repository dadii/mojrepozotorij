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
    public partial class FormaIspisRacuna : Form
    {
        public FormaIspisRacuna()
        {
            InitializeComponent();
        }
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        

        private void Konektiranje()
        {
            sql_con = new SQLiteConnection("Data Source=baza_veterinarska_stanica.sql;Version=3;New=False;Compress=True;");
        }

        private void FormaIspisRacuna_Load(object sender, EventArgs e)
        {
            Konektiranje();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = "select racuni.id_racuna,racuni.datum,racuni.vrijeme,korisnici.korisnicko_ime,racuni.ukupna_cijena from racuni left join korisnici on korisnici.id_korisnika = racuni.korisnik";
            sql_cmd.ExecuteNonQuery();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql_cmd);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView_IspisRacuna.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sql_con.Close();
        }

        private void buttonStavke_Click(object sender, EventArgs e)
        {
            string vrijednost = dataGridView_IspisRacuna.CurrentRow.Cells[0].Value.ToString();
            int vr = Convert.ToInt32(vrijednost);

            FormaStavkiRacuna noveStavkeRacuna = new FormaStavkiRacuna(vr);
            noveStavkeRacuna.Show();
        }

    }
}
