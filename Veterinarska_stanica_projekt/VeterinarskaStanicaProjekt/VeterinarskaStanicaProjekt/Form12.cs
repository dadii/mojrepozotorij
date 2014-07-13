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
    public partial class FormaStavkiRacuna : Form
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;


        private void Konektiranje()
        {
            sql_con = new SQLiteConnection("Data Source=baza_veterinarska_stanica.sql;Version=3;New=False;Compress=True;");
        }
        public FormaStavkiRacuna(int vri)
        {
            InitializeComponent();
            int varijabla = vri;
            Konektiranje();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = "select usluge.naziv_usluge,usluge.cijena_usluge from usluge left join stavka_racuna on usluge.id_usluge=stavka_racuna.id_usluge left join racuni on stavka_racuna.id_racuna = racuni.id_racuna where racuni.id_racuna = "+vri;
            sql_cmd.ExecuteNonQuery();
            SQLiteDataReader dr = sql_cmd.ExecuteReader();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql_cmd);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridViewStavkeRacuna.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sql_con.Close();
        }
    }
}
