using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;



namespace Booking
{
    public partial class Trail : Form
    {
        public Trail()
        {
            
            InitializeComponent();
            
        }
        Konekcija k = new Konekcija();
        DateTime vreme;

        private void label8_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnRezPosalji_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(k.konekcija());

            if (!label1.Text.Equals(bunifuMetroTextbox1.Text))
            {
                SqlCommand cmd = new SqlCommand("Select count(*) as cnt from Trial where Kljuc='" + bunifuMetroTextbox1.Text + "'", sql);
                try
                {
                    sql.Open();
                    if (cmd.ExecuteScalar().ToString() == "1")
                    {
                        SqlCommand brisanje = new SqlCommand("delete from Trial where Kljuc='" + bunifuMetroTextbox1.Text + "'", sql);
                        brisanje.ExecuteNonQuery();
                        Form1 f1 = new Form1();
                        f1.idKorisnika(id);
                        f1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Kod je neispravan!");
                    }
                    sql.Close();
                    sql.Dispose();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                    sql.Close();
                    sql.Dispose();
                }
            }
            else
            {

                SqlCommand brisanje = new SqlCommand("delete from Trial where username='" + username + "'", sql);
                sql.Open();
                try
                {

                    brisanje.ExecuteNonQuery();
                    Form1 f1 = new Form1();
                    f1.idKorisnika(id);
                    f1.Show();
                    sql.Close();
                    sql.Dispose();
                }
                catch(Exception er)
                {
                    MessageBox.Show(er.ToString());
                    sql.Close();
                    sql.Dispose();

                }
            }

        }

        

        int id = 0;
        string username = "";
        public void idKorisnika(int id,string username)
        {
            this.id = id;
            this.username = username;

        }
        DateTime novoVreme;
        string kod = "";
        private void Trail_Load(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(k.konekcija());
            SqlCommand cmd = new SqlCommand("Select datumReg,Kljuc from Trial where username='" + username + "'", sql);
            SqlDataReader read;
            try
            {
                sql.Open();
                read = cmd.ExecuteReader();
                if (read.Read())
                {
                    kod = read[1].ToString();
                    vreme = DateTime.Parse(read[0].ToString());
                }
                sql.Close();
                sql.Dispose();
                novoVreme=vreme.AddDays(15);
                
                int vremePotrebno = 0;
                if (novoVreme > DateTime.Now)
                {
                    if (novoVreme.Day < DateTime.Now.Day)
                    {
                        vremePotrebno = (novoVreme - DateTime.Now).Days;
                    }
                    label10.Text = "Preostalo vreme: "+(vremePotrebno) +" dana";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                sql.Close();
                sql.Dispose();
            }
            if(novoVreme<DateTime.Now)
                preskoci.Visible = false;
        }

        private void preskoci_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.idKorisnika(id);
            f1.Show();
        }




        private void posalji_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("softinz2020@gmail.com");
                msg.To.Add(rezIme.Text);
                msg.Subject = "Aktivacioni kod";
                msg.Body = kod;


                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "softinz2020@gmail.com";
                ntcd.Password = "rudare-123";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);
                bunifuMetroTextbox1.Visible = true;

                MessageBox.Show("Poruka poslata!", "Kontakt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Unesi validan Email!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bunifuMetroTextbox1.Visible = false;
            }
        }

        private void bunifuMetroTextbox1_OnValueChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(bunifuMetroTextbox1.Text))
            {
                btnRezPosalji.Visible = true;
            }
            else
            {
                btnRezPosalji.Visible = false;
            }
        }

        private void rezIme_OnValueChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rezIme.Text))
            {
                posalji.Visible = true;
            }
            else
            {
                posalji.Visible = false;
            }
        }
    }
}
