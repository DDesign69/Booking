using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mn = new MainMenu();
            mn.Show();
        }
        bool pr_korisnickoIme()
        {
            if (string.IsNullOrEmpty(txtEmailReg.Text))
            {
                label10.Visible = true;
                return false;
            }
            else if (txtUserReg.Text.Length > 15)
            {
                MessageBox.Show("Duzina korisnickog imena je 15 karaktera!");
                return false;
            }
            else
            {
                label10.Visible = false;
                return true;
            }
        }
        bool pr_Lozinka()
        {
            if (string.IsNullOrEmpty(txtPassReg.Text))
            {
                label4.Visible = true;
                return false;
            }
            else
            {
                label4.Visible = false;
                return true;
            }

        }
        bool pr_Email()
        {
            if (string.IsNullOrEmpty(txtEmailReg.Text))
            {
                label5.Visible = true;
                return false;
            }
            else
            {
                label5.Visible = false;
                return true;
            }
        }
        bool pr_StaNajviseVolite()
        {
            if (string.IsNullOrEmpty(txtPitanjeReg.Text))
            {
                label6.Visible = true;
                return false;
            }
            else
            {
                label6.Visible = false;
                return true;
            }
        }

        private void btnRegSave_Click(object sender, EventArgs e)
        {
            if (!pr_korisnickoIme() | !pr_Lozinka() | !pr_Email() | !pr_StaNajviseVolite())
            {
                return;
            }
            else
            {
                Konekcija konekcija = new Konekcija();
                SqlConnection connection = new SqlConnection(konekcija.konekcija());

                SqlCommand sql = new SqlCommand("select count(*) as cnt from Korisnici where KorisnickoIme='" + txtUserReg.Text + "'", connection);
                connection.Open();
                try
                {
                    if (sql.ExecuteScalar().ToString() == "1")
                    {
                        MessageBox.Show("Izaberite drugo Korisnicko ime!");
                        connection.Close();
                        connection.Dispose();
                    }
                    else
                    {
                        SqlCommand upis = new SqlCommand("insert into Korisnici(KorisnickoIme,Lozinka,Email,Pitanje) values('" + txtUserReg.Text + "', '" + txtPassReg.Text + "','" + txtEmailReg.Text + "','" + txtPitanjeReg.Text + "')", connection);
                        upis.ExecuteNonQuery();

                        DateTime sada = DateTime.Now;
                        string vreme = sada.ToString("dd-MMM-yyyy");
                        Random r = new Random();

                        SqlCommand upiss = new SqlCommand("insert into Trial(Kljuc,username,datumReg) values('" + r.Next().ToString() + "', '" + txtUserReg.Text + "','" +vreme+ "')", connection);
                        upiss.ExecuteNonQuery();
                        connection.Close();
                        connection.Dispose();
                        MessageBox.Show("Uspesno  ste kreirali nalog");

                        Login l = new Login();
                        l.Show();
                        Hide();
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                    connection.Close();
                    connection.Dispose();
                }
            }
        }

        private void txtPassReg_OnValueChanged(object sender, EventArgs e)
        {
            txtPassReg.isPassword = true;
            label4.Visible = false;
        }

        private void txtUserReg_OnValueChanged(object sender, EventArgs e)
        {
            label10.Visible = false;
        }

        private void txtEmailReg_OnValueChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void txtPitanjeReg_OnValueChanged(object sender, EventArgs e)
        {
            label6.Visible = false;
        }
    }
}

