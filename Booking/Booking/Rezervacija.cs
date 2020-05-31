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

namespace Booking
{
    public partial class Rezervacija : Form
    {
        public Rezervacija()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        int id = 0;
        public void hotelID(int id)
        {
            this.id = id;
            sobe();
        }

        int idKor= 0;
        public void idKorisnika(int id)
        {
            this.idKor = id;
        }
        public void sobe()
        {
            SqlConnection sql = new SqlConnection(k.konekcija());
            SqlCommand cmd = new SqlCommand("select BrojSobe from Sobe where HotelID=" + id, sql);
            SqlDataReader read;
            try
            {
                sql.Open();
                read = cmd.ExecuteReader();
                while (read.Read())
                {
                    cbSoba.Items.Add(read[0]);
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
        Konekcija k = new Konekcija();
        private void Rezervacija_Load(object sender, EventArgs e)
        {
             
        }

        private void btnRezPosalji_Click(object sender, EventArgs e)
        {
            if(rezIme.Equals("") | rezPrezime.Equals("") | rezTelefon.Equals("") | cbSoba.Text.Equals("Izaberi Sobu"))
            {
                MessageBox.Show("Morate popuniti sva polja!");
                return;
            }
            if (dtVremeOd.Value > dtVremeDo.Value)
            {
                MessageBox.Show("Niste lepo uneli vreme!");
                return;
            }
            string datumOd = dtVremeOd.Value.ToString("dd-MMM-yy");
            string datumDo = dtVremeDo.Value.ToString("dd-MMM-yy");
            SqlConnection sql = new SqlConnection(k.konekcija());
            SqlCommand cmd = new SqlCommand("insert into Rezervacija(Ime,Prezime,Telefon,ZakaziOd,ZakaziDo,BrojRezSobe,HotelID) values('"+rezIme.Text+"','"+rezPrezime.Text+"','"+rezTelefon.Text+"','"+datumOd+"','"+datumDo+"','"+cbSoba.Text+"',"+id+")", sql);
            try
            {
                sql.Open();
                cmd.ExecuteNonQuery();
                sql.Close();
                List<string> obrok = new List<string>(); 
                if (cbDorucak.Checked == true) {
                    obrok.Add(lblDorucak.Text);
                }
                if (cbRucak.Checked == true)
                {
                    obrok.Add(lblRucak.Text);
                }
                if (cbVecera.Checked == true)
                {
                    obrok.Add(lblVecera.Text);
                }
                if (obrok.Count != 0)
                {
                    
                    SqlCommand idRez = new SqlCommand("select MAX(Id) from Rezervacija", sql);
                    SqlDataReader read;
                    int idRezervacije = 0;
                    try
                    {
                        sql.Open();
                        read = idRez.ExecuteReader();
                        if (read.Read())
                        {
                            idRezervacije = int.Parse(read[0].ToString());
                        }
                        sql.Close();
                    }
                    catch(Exception er)
                    {
                        MessageBox.Show(er.ToString());
                        sql.Close();
                        sql.Dispose();
                    }
                   
                    sql.Open();

                    for (int i = 0; i < obrok.Count; i++) {
                        SqlCommand hrana = new SqlCommand("insert into Hrana(Period,RezervacijaID) values('"+obrok[i]+"',"+idRezervacije+")",sql);
                        try
                        {                           
                            hrana.ExecuteNonQuery();
                            if (i == obrok.Count - 1)
                            {
                                MessageBox.Show("Uspesna prijava!");
                                sql.Close();
                                sql.Dispose();
                                this.Hide();
                            }
                        }
                        catch(Exception er)
                        {
                            MessageBox.Show(er.ToString());
                            sql.Close();
                            sql.Dispose();
                        }
                    }
                }
                else {
                    MessageBox.Show("Uspesna prijava!");
                    sql.Close();
                    sql.Dispose();
                    this.Hide();
                }
            }
            catch(Exception er)
            {
                MessageBox.Show(er.ToString());
                sql.Close();
                sql.Dispose();
            }
        }

        private void dtVremeOd_ValueChanged(object sender, EventArgs e)
        {
            string datumOd = dtVremeOd.Value.ToString("dd-MMM-yy");
            string datumDo = dtVremeDo.Value.ToString("dd-MMM-yy");
            cbSoba.Items.Clear();
            sobe();
            SqlConnection sql = new SqlConnection(k.konekcija());
            SqlCommand cmd = new SqlCommand("select BrojRezSobe from Rezervacija where '"+datumOd+ "' between ZakaziOd and ZakaziDo or '" + datumDo + "' between ZakaziOd and ZakaziDo ", sql);
            SqlDataReader read;
            SqlDataReader readZaDatum;
            try
            {
                sql.Open();
                read = cmd.ExecuteReader();
                    while(read.Read())
                    {
                        cbSoba.Items.Remove(read[0]);
                    }
                    sql.Close();
                SqlCommand cmdDatum = new SqlCommand("select BrojRezSobe from Rezervacija where ZakaziOd between '" + datumOd + "' and '" + datumDo + "' or ZakaziDo between '" + datumOd + "' and '" + datumDo + "'", sql);
                try
                {
                    sql.Open();
                    readZaDatum = cmdDatum.ExecuteReader();
                    while (readZaDatum.Read())
                    {
                        cbSoba.Items.Remove(readZaDatum[0]);
                    }
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
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
                sql.Close();
                sql.Dispose();
            }
        }

        private void dtVremeDo_ValueChanged(object sender, EventArgs e)
        {
            string datumOd = dtVremeOd.Value.ToString("dd-MMM-yy");
            string datumDo = dtVremeDo.Value.ToString("dd-MMM-yy");
            cbSoba.Items.Clear();
            sobe();
            SqlConnection sql = new SqlConnection(k.konekcija());
            SqlCommand cmd = new SqlCommand("select BrojRezSobe from Rezervacija where '" + datumDo + "' between ZakaziOd and ZakaziDo or '" + datumOd + "' between ZakaziOd and ZakaziDo ", sql);
            SqlDataReader read;
            SqlDataReader readZaDatum;
            try
            {
                sql.Open();
                read = cmd.ExecuteReader();
                while (read.Read())
                {
                    cbSoba.Items.Remove(read[0]);
                }
                sql.Close();
                SqlCommand cmdDatum = new SqlCommand("select BrojRezSobe from Rezervacija where ZakaziOd between '" + datumOd + "' and '" + datumDo + "' or ZakaziDo between '" + datumOd + "' and '" + datumDo + "'", sql);
                try
                {
                    sql.Open();
                    readZaDatum = cmdDatum.ExecuteReader();
                    while (readZaDatum.Read())
                    {
                        cbSoba.Items.Remove(readZaDatum[0]);
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
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
                sql.Close();
                sql.Dispose();
            }
        }
    }
}
