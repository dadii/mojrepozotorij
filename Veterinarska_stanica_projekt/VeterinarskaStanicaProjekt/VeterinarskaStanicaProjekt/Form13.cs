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
    public partial class formDodajUslugu : Form
    {
        public formDodajUslugu()
        {
            InitializeComponent();
        }
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;

        private void Konektiranje()
        {
            sql_con = new SQLiteConnection("Data Source=baza_veterinarska_stanica.sql;Version=3;New=False;Compress=True;");
        }

        private void buttonDodajUslugu_Click(object sender, EventArgs e)
        {
            Konektiranje();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();

            sql_cmd.CommandText = "insert into usluge (naziv_usluge,cijena_usluge) values ('" + textBoxNazivUsluge.Text.ToString()+"',"+textBoxCijenaUsluge.Text+")";

            sql_cmd.ExecuteNonQuery();
            this.Close();
            MessageBox.Show("Uspješno ste dodali novu uslugu");
            sql_con.Close();
        }
    }
}
