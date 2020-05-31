using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking
{
    public partial class Form3 : Form
    {
        public Form3(Form p)
        {
            s = p;
            InitializeComponent();
        }
        Form s;
        private void label6_Click(object sender, EventArgs e)
        {
            s.Hide();
            MainMenu lg = new MainMenu();
            lg.Show();
        }

        private void btnRez_Click(object sender, EventArgs e)
        {
            Rezervacija rz = new Rezervacija();
            rz.Show();
        }

        private void btnIzvestaj_Click(object sender, EventArgs e)
        {
            Izvestaj iz = new Izvestaj();
            iz.Show();
        }
        
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (naziv.Count != 0)
            {
                if (i == naziv.Count - 1)
                {
                    i = -1;
                }
                i++;
                label4.Text = naziv[i];
                ms = new MemoryStream(slike[i]);
                pictureBox3.Image = Image.FromStream(ms);
            }

        }
        MemoryStream ms;
        List<byte[]> slike = new List<byte[]>();
        List<String> naziv = new List<string>();
        List<int> id = new List<int>();
        private void Form3_Load(object sender, EventArgs e)
        {
            Konekcija k = new Konekcija();
            SqlConnection sql = new SqlConnection(k.konekcija());
            SqlCommand cmd = new SqlCommand("select Naziv, Slika,Id from Hotel", sql);
            SqlDataReader read;
            try {
                sql.Open();
                read = cmd.ExecuteReader();
                while (read.Read())
                {
                    slike.Add((byte[])read[1]);
                    naziv.Add(read[0].ToString());
                    id.Add(int.Parse(read[2].ToString()));
                }
                if (naziv.Count!=0)
                {
                    label4.Text = naziv[0];
                    ms = new MemoryStream(slike[0]);
                    pictureBox3.Image =Image.FromStream(ms);
                }
                sql.Close();
                sql.Dispose();
            }
            catch (Exception er) {
                MessageBox.Show(er.ToString());
                sql.Close();
                sql.Dispose();
            }
        }
        int i = 0;
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (naziv.Count != 0)
            {
                if (i == 0)
                {
                    i = naziv.Count;
                }
                i--;
                label4.Text = naziv[i];
                ms = new MemoryStream(slike[i]);
                pictureBox3.Image = Image.FromStream(ms);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (naziv.Count != 0)
            {
                Rezervacija rez = new Rezervacija();
                rez.hotelID(id[i]);
                rez.Show();
                
            }
        }

        private void uLokacija_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) {
                Konekcija k = new Konekcija();
                SqlConnection sql = new SqlConnection(k.konekcija());
                SqlCommand cmd = new SqlCommand("select Naziv, Slika,Id from Hotel where Lokacija='" + uLokacija.Text + "'", sql);
                SqlDataReader read;
                try
                {
                    slike.Clear();
                    naziv.Clear();
                    id.Clear();
                    i = 0;
                    sql.Open();
                    read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        slike.Add((byte[])read[1]);
                        naziv.Add(read[0].ToString());
                        id.Add(int.Parse(read[2].ToString()));
                    }
                    if (naziv.Count > 0)
                    {
                        label4.Text = naziv[0];
                        ms = new MemoryStream(slike[0]);
                        pictureBox3.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        label4.Text = "";
                        pictureBox3.Image = null;
                        MessageBox.Show("Nemamo hotele ovog grada");
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
        }


        private void uLokacija_OnValueChanged(object sender, EventArgs e)
        {
            if (uLokacija.Text == "")
            {
                Konekcija k = new Konekcija();
                SqlConnection sql = new SqlConnection(k.konekcija());
                SqlCommand cmd = new SqlCommand("select Naziv, Slika,Id from Hotel", sql);
                SqlDataReader read;
                try
                {
                    i =0;
                    slike.Clear();
                    naziv.Clear();
                    id.Clear();
                    sql.Open();
                    read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        slike.Add((byte[])read[1]);
                        naziv.Add(read[0].ToString());
                        id.Add(int.Parse(read[2].ToString()));
                    }
                    label4.Text = naziv[0];
                    ms = new MemoryStream(slike[0]);
                    pictureBox3.Image = Image.FromStream(ms);
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
        }
    }
}
