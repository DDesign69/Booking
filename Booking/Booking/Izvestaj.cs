using Booking.BookingDatabaseDataSetTableAdapters;
using System;
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
    public partial class Izvestaj : Form
    {
        public Izvestaj()
        {
            InitializeComponent();
        }
        int id = 0;
        public void idKorisnika(int id)
        {
            this.id = id;
        }

        private void rezervacijaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rezervacijaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookingDataSet);

        }

        private void Izvestaj_Load(object sender, EventArgs e)
        {
           this.rezervacijaTableAdapter.FillBy(this.bookingDataSet.Rezervacija,id);

        }

        private void pretragaNaziv_OnValueChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(rezervacijaTableAdapter.GetData());
            DV.RowFilter = string.Format("Ime LIKE '%{0}%'", pretragaNaziv.Text);
            rezervacijaDataGridView.DataSource = DV;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
