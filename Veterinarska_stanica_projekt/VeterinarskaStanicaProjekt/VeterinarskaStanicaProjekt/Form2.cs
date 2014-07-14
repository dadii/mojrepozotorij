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
    public partial class FormaAdmin : Form
    {
        public FormaAdmin()
        {
            InitializeComponent();
        }

        private void unosKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaUnosKorisnika noviUnosKorisnika = new FormaUnosKorisnika();
            noviUnosKorisnika.Show();
        }

        private void ispisKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaIspisKorisnika noviIspisKorisnika = new FormaIspisKorisnika();
            noviIspisKorisnika.Show();
        }

        private void unosLjubimcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forma_unos_ljubimca noviUnosLJubimca = new Forma_unos_ljubimca();
            noviUnosLJubimca.Show();
        }

        private void ispisLjubimacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaIspisLJubimaca noviIspisLJubimaca = new FormaIspisLJubimaca();
            noviIspisLJubimaca.Show();
        }
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteCommand sql_cmd1;

        private void Konektiranje()
        {
            sql_con = new SQLiteConnection("Data Source=baza_veterinarska_stanica.sql;Version=3;New=False;Compress=True;");
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string datum = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");

            Konektiranje();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();

            sql_cmd.CommandText = "select pregledi.id_pregleda as ID,strftime('%H:%M', pregledi.vrijeme) as vrijeme,ljubimci.naziv as ljubimac,pregledi.datum as datum,pregledi.napomena as napomena from pregledi left join ljubimci on ljubimci.id_ljubimca=pregledi.ljubimac where datum = '" + datum + "' order by vrijeme asc";

            sql_cmd.ExecuteNonQuery();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql_cmd);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView_pregledi.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sql_con.Close();
        }

        private void unosPregledaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUnosPregleda noviUnosPregleda = new FormUnosPregleda();
            noviUnosPregleda.Show();
        }

        private void buttonPregled_Click(object sender, EventArgs e)
        {
            if (dataGridView_pregledi.SelectedRows.Count != 0)
            {
                string vrijednost = dataGridView_pregledi.CurrentRow.Cells[0].Value.ToString();
                int vr = Convert.ToInt32(vrijednost);

                FormaPregled noviPregled = new FormaPregled(vr);
                noviPregled.Show();
            }
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            string vrijednost = dataGridView_pregledi.CurrentRow.Cells[0].Value.ToString();
            int vr = Convert.ToInt32(vrijednost);
            Konektiranje();
            sql_con.Open();
            sql_cmd1 = sql_con.CreateCommand();

            sql_cmd1.CommandText = "DELETE FROM pregledi WHERE id_pregleda = " + vr;

            sql_cmd1.ExecuteNonQuery();
            MessageBox.Show("Obrisali ste pregled");
            sql_con.Close();
        }

        private void f1FAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("veterinarskaStanicaFAQ.html");            
        }

        private void ispisRačunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaIspisRacuna noviIspisRacuna = new FormaIspisRacuna();
            noviIspisRacuna.Show();
        }

        private void dodajUsluguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDodajUslugu novaUsluga = new formDodajUslugu();
            novaUsluga.Show();
        }

        private void pregledUslugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormazaPregledUsluga pregledUsluga = new FormazaPregledUsluga();
            pregledUsluga.Show();
        }
     
    }
}
