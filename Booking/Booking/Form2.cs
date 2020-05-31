using System;
using Booking.BookingDatabaseDataSetTableAdapters;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking
{
    public partial class Form2 : Form
    {
        public Form2(Form p)
        {
            forma = p;
            InitializeComponent();
        }
        Form forma;

        private void label3_Click(object sender, EventArgs e)
        {
            forma.Hide();
            MainMenu lg = new MainMenu();
            lg.Show();
        }

        private void hotelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hotelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookingDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.hotelTableAdapter.FillBy(this.bookingDataSet.Hotel,id);
        }

        private void unosNaziv_OnValueChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(hotelTableAdapter.GetData());
            DV.RowFilter = string.Format("Naziv LIKE '%{0}%'", unosNaziv.Text);
            hotelDataGridView.DataSource = DV;
        }
        int id = 0;
        public void idKorisnika(int id)
        {
            this.id = id;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Izvestaj rz = new Izvestaj();
            rz.idKorisnika(id);
            rz.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
