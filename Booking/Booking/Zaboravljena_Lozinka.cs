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
    public partial class Zaboravljena_Lozinka : Form
    {
        public Zaboravljena_Lozinka()
        {
            InitializeComponent();
            label4.Visible = false;
            txtNovaSifra.Visible = false;
            btnSave.Visible = false;

        }
        Konekcija k = new Konekcija();

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(k.konekcija());
            SqlCommand command = new SqlCommand("Update Korisnici set Lozinka=@password Where KorisnickoIme=@username", sql);
            try
            {
                sql.Open();
                command.Parameters.AddWithValue("@password", txtNovaSifra.Text);
                command.Parameters.AddWithValue("@username", txtUsername.Text);

                command.ExecuteNonQuery();

                MessageBox.Show("Sifra je uspesno promenjena!",
                    "Ispravan unos!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None,
                    MessageBoxDefaultButton.Button1);

                Login lg = new Login();
                lg.Show();
                this.Hide();
                sql.Close();
                sql.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sql.Close();
                sql.Dispose();
            }

        }

        private void txtSigPitanje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtSigPitanje.Text == "" || txtUsername.Text == "")
                {
                    MessageBox.Show("Unesite podatke u prazno polje!",
                        "Neispravan unos!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);
                    return;
                }
                SqlConnection sql = new SqlConnection(k.konekcija());
                SqlCommand command = new SqlCommand("Select Pitanje from Korisnici where KorisnickoIme=@username", sql);
                try
                {
                    sql.Open();
                    command.Parameters.AddWithValue("@username", txtUsername.Text);
                    SqlDataReader read;
                    read = command.ExecuteReader();
                    if (read.Read())
                    {
                        if (txtSigPitanje.Text.Equals(prazniProstori(read[0].ToString())))
                        {
                            label4.Visible = true;
                            btnSave.Visible = true;
                            txtNovaSifra.Visible = true;
                        }
                    }
                    sql.Close();
                    sql.Dispose();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    sql.Close();
                    sql.Dispose();
                }

            }
        }
        string prazniProstori(String s)
        {
            char[] k = new char[s.Length];
            k = s.ToArray();
            string novaRec = null;
            int m = 0;
            for(int i = k.Length - 1; i >= 0; i--)
            {
                if (m != 0)
                {
                    break;
                }
                if (k[i].ToString().Equals(" "))
                {
                    continue;
                }
                else
                {
                    for(int j = 0; j <= i; j++)
                    {
                        novaRec += k[j];
                    }
                    m = 1;
                }

            }
            
            return novaRec;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
