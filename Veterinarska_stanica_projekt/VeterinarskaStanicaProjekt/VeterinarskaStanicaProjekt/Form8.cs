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
using System.Net;
using System.Net.Mail;

namespace VeterinarskaStanicaProjekt
{
    public partial class FormUnosPregleda : Form
    {
        public FormUnosPregleda()
        {
            InitializeComponent();
        }
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteCommand sql_cmd1;
        private SQLiteCommand sql_cmd2;

        private void Konektiranje()
        {
            sql_con = new SQLiteConnection("Data Source=baza_veterinarska_stanica.sql;Version=3;New=False;Compress=True;");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Konektiranje();
            sql_con.Open();
            sql_cmd1 = sql_con.CreateCommand();
            sql_cmd1.CommandText = "select * from ljubimci where naziv='" + textBox_ljubimac.Text.ToString() + "'";
            sql_cmd1.ExecuteNonQuery();
            SQLiteDataReader dr = sql_cmd1.ExecuteReader();
            
            int ljubimac1;
            string email;

            if (dr.Read())
            {
                string datum1 = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
                ljubimac1 = dr.GetInt32(0);
                sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandText = "insert into pregledi('vrijeme','ljubimac','datum','napomena') values ('"+textBox_vrijeme.Text.ToString()+"',"+ljubimac1+",'"+datum1+"','"+textBox_napomena.Text.ToString()+"')";
                sql_cmd.ExecuteNonQuery();

                sql_cmd2 = sql_con.CreateCommand();
                sql_cmd2.CommandText = "select korisnici.email from korisnici left join ljubimci on korisnici.id_korisnika = ljubimci.vlasnik where ljubimci.id_ljubimca ="+ljubimac1;
                sql_cmd2.ExecuteNonQuery();
                SQLiteDataReader dr2 = sql_cmd2.ExecuteReader();
                if (dr2.Read())
                {
                    email = dr2.GetString(0);

                    //System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
                    //message.To.Add(email.ToString());
                    //message.Subject = "Veterinarski pregled";
                    //message.From = new System.Net.Mail.MailAddress("Veterinarska.stanica@gmail.com");
                    //message.Body = "Poštovani" + System.Environment.NewLine + "Obavještavamo Vas da imate zakazan termin za veterinarski pregled na dan " + datum1 + " u " + textBox_vrijeme.Text.ToString() + System.Environment.NewLine + "Hvala.";
                    //System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com");
                    //smtp.UseDefaultCredentials = false;
                    //smtp.Send(message);

                    MailMessage msg = new MailMessage();

                    msg.From = new MailAddress("veterinarska.stanica5@gmail.com");
                    msg.To.Add(email.ToString());
                    msg.Subject = "Veterinarski pregled";
                    msg.Body = "Poštovani" + System.Environment.NewLine + "Obavještavamo Vas da imate zakazan termin za veterinarski pregled na dan " + datum1 + " u " + textBox_vrijeme.Text.ToString() + System.Environment.NewLine + "Hvala.";
                    //msg.Priority = MailPriority.High;

                    using (SmtpClient client = new SmtpClient()) 
                    {
                        client.EnableSsl = true;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential("veterinarska.stanica5@gmail.com", "115599825");
                        client.Host = "smtp.gmail.com";
                        client.Port = 587;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;

                        client.Send(msg);
                    }
                }
                this.Close();
                MessageBox.Show("Uspješno ste dodali pregled"+System.Environment.NewLine+"Korisniku je poslan e-mail");
                sql_con.Close();
            }
            else
            {
                MessageBox.Show("Ne postoji ljubimac");
            }
        }
    }
}

