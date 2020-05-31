using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Booking
{
    public partial class Form5 : Form
    {
        public Form5(Form d)
        {
            f1 = d;
            InitializeComponent();
        }
        Form f1;
        public System.Net.Mail.MailAddress Sender { get; set; }
        private void label3_Click(object sender, EventArgs e)
        {
            f1.Hide();
            MainMenu lg = new MainMenu();
            lg.Show();
        }

        private void btnKPosalji_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("softinz2020@gmail.com");
                msg.To.Add(txtKEmail.Text);
                msg.Subject = txtkNaslov.Text;
                //msg.Body = txtPomocPrezime.Text;
                //msg.Body = txtPomocNas.Text;
                msg.Body = txtKPoruka.Text;


                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "softinz2020@gmail.com";
                ntcd.Password = "rudare-123";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);

                MessageBox.Show("Poruka poslata!", "Kontakt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Greska!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
