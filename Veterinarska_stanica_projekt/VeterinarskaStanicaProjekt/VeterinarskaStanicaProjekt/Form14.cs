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
    public partial class FormazaPregledUsluga : Form
    {
        public FormazaPregledUsluga()
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
        private void FormazaPregledUsluga_Load(object sender, EventArgs e)
        {
            Konektiranje();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = "select * from usluge";

            sql_cmd.ExecuteNonQuery();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql_cmd);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridViewPregledUsluga.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sql_con.Close();
        }

        private void buttonBrisanjeUsluge_Click(object sender, EventArgs e)
        {
            string vrijednost = dataGridViewPregledUsluga.CurrentRow.Cells[0].Value.ToString();
            int vr = Convert.ToInt32(vrijednost);
            Konektiranje();
            sql_con.Open();
            sql_cmd1 = sql_con.CreateCommand();

            sql_cmd1.CommandText = "DELETE FROM usluge WHERE id_usluge = " + vr;

            sql_cmd1.ExecuteNonQuery();
            MessageBox.Show("Obrisali ste uslugu");
            sql_con.Close();
        }
    }
}
