using System;
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
    public partial class Form4 : Form
    {
        public Form4(Form p)
        {
            f = p;
            InitializeComponent();
        }
        Form f;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            f.Hide();
            MainMenu lg = new MainMenu();
            lg.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            Image image;
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files (*.jpg)|*.jpg";
            op.Multiselect = false;
            DialogResult re = op.ShowDialog();
            if (re == DialogResult.OK)
            {
                image = Image.FromFile(op.FileName);
                MemoryStream ms = new MemoryStream();
                image.Save(ms, image.RawFormat);
                slika1.Image = image;
            }
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            unosNaziv.Text = "";
            unosLokacija.Text = "";
            unosBRSoba.Text = "";
            slika1.Image = null;
        }
        int id = 0;
        public void idKorisnika(int id)
        {
            this.id = id;
        }
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (unosNaziv.Equals("") || unosBRSoba.Equals("") || unosLokacija.Equals("") || slika1.Image==null)
            {
                MessageBox.Show("Morate popuniti sva polja!");
                return;
            }

            MemoryStream ms = new MemoryStream();
            slika1.Image.Save(ms, slika1.Image.RawFormat);
            byte[] duzinaSlike = ms.GetBuffer();
            ms.Close();
            Konekcija k = new Konekcija();
            SqlConnection sql = new SqlConnection(k.konekcija());
            SqlCommand cmd = new SqlCommand("insert into Hotel(Naziv,Lokacija,BrojSoba,KorisnikID,Slika) values('"+unosNaziv.Text+"','"+unosLokacija.Text+"',"+unosBRSoba.Text+",'"+id+"',@slika)",sql);
            try
            {
                sql.Open();
                cmd.Parameters.AddWithValue("@slika", duzinaSlike);
                cmd.ExecuteNonQuery();
                sql.Close();
                SqlCommand idHotela = new SqlCommand("select MAX(Id) from Hotel",sql);
                SqlDataReader read;
                try
                {
                    sql.Open();
                    read = idHotela.ExecuteReader();
                    int poslednjiID=0;
                    if (read.Read()) {
                        poslednjiID = int.Parse(read[0].ToString());
                    }
                    sql.Close();
                    for (int i = 1; i <=int.Parse(unosBRSoba.Text); i++)
                    {
                        SqlCommand upisSobe = new SqlCommand("insert into Sobe(BrojSobe,HotelID) values("+i+","+poslednjiID+")", sql);
                    try
                    {
                        sql.Open();
                        upisSobe.ExecuteNonQuery();
                        sql.Close();
                            if (i == int.Parse(unosBRSoba.Text))
                            {
                                MessageBox.Show("Uspesan unos!");
                                unosNaziv.Text = "";
                                unosLokacija.Text = "";
                                unosBRSoba.Text = "";
                                slika1.Image = null;
                                sql.Close();
                                sql.Dispose();
                            }
                        }
                    catch (Exception er) {
                        MessageBox.Show(er.Message);
                        sql.Close();
                        sql.Dispose();
                    }
                    }
                }
                catch (Exception er) {
                    MessageBox.Show(er.Message);
                    sql.Close();
                    sql.Dispose();
                }
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
                sql.Close();
                sql.Dispose();
            }
        }
    }
}
