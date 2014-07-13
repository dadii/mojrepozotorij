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
    public partial class FormaPregled : Form
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteCommand sql_cmd1;
        private SQLiteCommand sql_cmd2;
        private SQLiteCommand sql_cmd3;
        private SQLiteCommand sql_cmd4;
        private SQLiteCommand sql_cmd5;
        private SQLiteCommand sql_cmd6;
        private SQLiteCommand sql_cmd7;
        private SQLiteCommand sql_cmd8;

        int[] polje;

        private void Konektiranje()
        {
            sql_con = new SQLiteConnection("Data Source=baza_veterinarska_stanica.sql;Version=3;New=False;Compress=True;");
        }
       
        public FormaPregled(int vri)
        {
            InitializeComponent();
            int varijabla = vri;
            Konektiranje();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = "select pregledi.datum,ljubimci.naziv,pregledi.ljubimac from pregledi left join ljubimci on pregledi.ljubimac = ljubimci.id_ljubimca where pregledi.id_pregleda = "+varijabla;
            sql_cmd.ExecuteNonQuery();
            SQLiteDataReader dr = sql_cmd.ExecuteReader();
            string ljubimac = "";
            string datum = "";
            int sifraljubimca = 0;
            while (dr.Read())
            {
                ljubimac = dr.GetString(1);
                datum = dr.GetString(0);
                sifraljubimca = dr.GetInt32(2);
            }
            textBox_datumPregleda.Text = datum;
            textBoxImeLjubimca.Text = ljubimac;
            label_pomoc.Text = sifraljubimca.ToString();
            
            sql_cmd2 = sql_con.CreateCommand();
            sql_cmd2.CommandText = "select id_usluge,naziv_usluge,cijena_usluge from usluge";
            sql_cmd2.ExecuteNonQuery();
            SQLiteDataAdapter da2 = new SQLiteDataAdapter(sql_cmd2);
            DataSet ds2 = new DataSet();
            try
            {
                da2.Fill(ds2);
                DataTable dt2 = ds2.Tables[0];
                dataGridViewPopisUsluga.DataSource = dt2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sql_con.Close();
        }
        
        private void buttonUnosPovijest_Click(object sender, EventArgs e)
        {
            Konektiranje();
            sql_con.Open();
            int sfrlju = Convert.ToInt32(label_pomoc.Text);        
            sql_cmd1 = sql_con.CreateCommand();
            sql_cmd1.CommandText = "insert into povijest_bolesti ('ljubimac','datum','unos') values ("+sfrlju+",'"+textBox_datumPregleda.Text.ToString()+"','"+textBox_UnosPovijestBolesti.Text.ToString()+"')";
            sql_cmd1.ExecuteNonQuery();
            this.Close();
            MessageBox.Show("Uspješno ste dodali zapis u povijest bolesti");
            sql_con.Close();
        }

        private void buttonNaplati_Click(object sender, EventArgs e)
        {

            Konektiranje();
            sql_con.Open();

            sql_cmd4 = sql_con.CreateCommand();
            sql_cmd4.CommandText = "select vlasnik from ljubimci where naziv = '"+textBoxImeLjubimca.Text.ToString()+"'";
            sql_cmd4.ExecuteNonQuery();
            SQLiteDataReader dr4 = sql_cmd4.ExecuteReader();
            int identifikator = 0;
            while (dr4.Read())
            {
                identifikator = dr4.GetInt32(0);
            }

            sql_cmd3 = sql_con.CreateCommand();
            sql_cmd3.CommandText = "insert into racuni ('datum','vrijeme','korisnik') values (date('now'),time('now'),"+identifikator+")";
            sql_cmd3.ExecuteNonQuery();

            polje = new int[dataGridViewPopisUsluga.GetCellCount(System.Windows.Forms.DataGridViewElementStates.Selected) / 3];
            

            for (int i = 0; i < dataGridViewPopisUsluga.GetCellCount(System.Windows.Forms.DataGridViewElementStates.Selected); i++)
            {
                if (i % 3 == 0 || i == 0)
                {
                    string val = dataGridViewPopisUsluga.SelectedCells[i].Value.ToString();
                    int valu = Convert.ToInt32(val);
                    polje[i / 3] = valu;
                }              
            }

            sql_cmd5 = sql_con.CreateCommand();
            sql_cmd5.CommandText = "select * from racuni where id_racuna = (select max(id_racuna) from racuni)";
            sql_cmd5.ExecuteNonQuery();
            SQLiteDataReader dr5 = sql_cmd5.ExecuteReader();
            int racunBroj = 0;
            while (dr5.Read())
            {
                racunBroj = dr5.GetInt32(0);
            }

            float suma = 0;
            for (int i = 0; i < dataGridViewPopisUsluga.GetCellCount(System.Windows.Forms.DataGridViewElementStates.Selected) / 3; i++)
            {
                sql_cmd7 = sql_con.CreateCommand();
                sql_cmd7.CommandText = "select cijena_usluge from usluge where id_usluge =" +polje[i];
                sql_cmd7.ExecuteNonQuery();
                SQLiteDataReader dr7 = sql_cmd7.ExecuteReader();
                int cijena = 0;
                while (dr7.Read())
                {
                    cijena = dr7.GetInt32(0);
                }
                suma = suma + cijena;
                sql_cmd6 = sql_con.CreateCommand();
                sql_cmd6.CommandText = "insert into stavka_racuna values ("+racunBroj+","+polje[i]+")";
                sql_cmd6.ExecuteNonQuery();
            }
                //string toDisplay = string.Join(Environment.NewLine, polje);
                //MessageBox.Show(toDisplay);
            
            sql_cmd8 = sql_con.CreateCommand();
            sql_cmd8.CommandText = "update racuni set ukupna_cijena = "+suma+" where id_racuna = " + racunBroj;
            sql_cmd8.ExecuteNonQuery();

            MessageBox.Show("Naplačena je usluga u iznosu od "+suma +"kn");

                sql_con.Close();
        }

     
    }
}
