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
    public partial class FormPovijestBolesti : Form
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;

        private void Konektiranje()
        {
            sql_con = new SQLiteConnection("Data Source=baza_veterinarska_stanica.sql;Version=3;New=False;Compress=True;");
        }
        public FormPovijestBolesti(int vri)
        {
            InitializeComponent();
            int varijabla = vri;
            Konektiranje();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = "select datum,unos from povijest_bolesti where ljubimac = "+varijabla;
            sql_cmd.ExecuteNonQuery();
            SQLiteDataReader dr = sql_cmd.ExecuteReader();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql_cmd);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridViewPovijestBolesti.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sql_con.Close();
        }
    }
}
