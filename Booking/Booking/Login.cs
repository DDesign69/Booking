using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Booking
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mn = new MainMenu();
            mn.Show();
        }
        Konekcija k = new Konekcija();

        int idKorisnika = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Unesite podatke u prazna polja!",
                    "Neispravan unos!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                return;
            }
            try
            {
                SqlConnection sql = new SqlConnection(k.konekcija());
                SqlCommand command = new SqlCommand("Select * from Korisnici where KorisnickoIme=@username and Lozinka=@password", sql);
                command.Parameters.AddWithValue("@username", txtUsername.Text);
                command.Parameters.AddWithValue("@password", txtPassword.Text);
                sql.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                sql.Close();

                idKorisnika =int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());



                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    MessageBox.Show("Uspesna prijava!",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button1);
                    


                    SqlCommand command1 = new SqlCommand("Select count(*) as cnt from Trial where username=@username", sql);
                    command1.Parameters.AddWithValue("@username", txtUsername.Text);
                    sql.Open();
                    if (command1.ExecuteScalar().ToString() == "1") {
                        Trail tr = new Trail();
                        tr.idKorisnika(idKorisnika, txtUsername.Text);
                        tr.Show();
                        this.Hide();
                        sql.Close();
                        sql.Dispose();
                    }
                    else
                    {
                        Form1 f1 = new Form1();
                        f1.idKorisnika(idKorisnika);
                        f1.Show();
                        this.Hide();
                        sql.Close();
                        sql.Dispose();

                    }



                }
                else
                {
                    MessageBox.Show("Prijava nije uspela!",
                    "Neispravan unos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop,
                    MessageBoxDefaultButton.Button1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Zaboravljena_Lozinka zb = new Zaboravljena_Lozinka();
            zb.Show();
             
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
        }
    }
}
