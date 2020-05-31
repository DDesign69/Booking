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
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            m1.BackColor = Color.FromArgb(44, 152, 224);
            label1.ForeColor = Color.White;

            m2.BackColor = Color.FromArgb(60, 58, 69);
            label2.ForeColor = Color.FromArgb(110, 110, 110);
            m3.BackColor = Color.FromArgb(60, 58, 69);
            label3.ForeColor = Color.FromArgb(110, 110, 110);
            m5.BackColor = Color.FromArgb(60, 58, 69);
            label6.ForeColor = Color.FromArgb(110, 110, 110);

            Form2 frm = new Form2(this);
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            panel2.Controls.Add(frm);
            frm.idKorisnika(id);
            frm.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            m5.BackColor = Color.FromArgb(170, 92, 204);
            label6.ForeColor = Color.White;

            m2.BackColor = Color.FromArgb(60, 58, 69);
            label2.ForeColor = Color.FromArgb(110, 110, 110);
            m3.BackColor = Color.FromArgb(60, 58, 69);
            label3.ForeColor = Color.FromArgb(110, 110, 110);
            m1.BackColor = Color.FromArgb(60, 58, 69);
            label1.ForeColor = Color.FromArgb(110, 110, 110);

            Form3 frm = new Form3(this);
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            panel2.Controls.Add(frm);
            
            frm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            m2.BackColor = Color.FromArgb(254, 208, 114);
            label2.ForeColor = Color.White;

            m1.BackColor = Color.FromArgb(60, 58, 69);
            label1.ForeColor = Color.FromArgb(110, 110, 110);
            m3.BackColor = Color.FromArgb(60, 58, 69);
            label3.ForeColor = Color.FromArgb(110, 110, 110);
            m5.BackColor = Color.FromArgb(60, 58, 69);
            label6.ForeColor = Color.FromArgb(110, 110, 110);

            Form4 frm = new Form4(this);
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            panel2.Controls.Add(frm);
            frm.idKorisnika(id);
            frm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            m3.BackColor = Color.FromArgb(235, 124, 107);
            label3.ForeColor = Color.White;

            m1.BackColor = Color.FromArgb(60, 58, 69);
            label1.ForeColor = Color.FromArgb(110, 110, 110);
            m2.BackColor = Color.FromArgb(60, 58, 69);
            label2.ForeColor = Color.FromArgb(110, 110, 110);
            m5.BackColor = Color.FromArgb(60, 58, 69);
            label6.ForeColor = Color.FromArgb(110, 110, 110);

            Form5 frm = new Form5(this);
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            panel2.Controls.Add(frm);
            frm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu lg = new MainMenu();
            lg.Show();
        }
        int id = 0;
        public void idKorisnika(int id) {
            this.id = id;
        }
        public void gasi()
        {
            this.Close();
        }
    }
}
