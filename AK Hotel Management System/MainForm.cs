using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AK_Hotel_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ClientInfo ci = new ClientInfo();
            ci.Show();
            this.Hide();
        }

        private void staffButton3_Click(object sender, EventArgs e)
        {
            StaffInfo si = new StaffInfo();
            si.Show();
            this.Hide();
        }

        private void roomButton5_Click(object sender, EventArgs e)
        {
            RoomInfo ri = new RoomInfo();
            ri.Show();
            this.Hide();

        }

        private void reservation2Button4_Click(object sender, EventArgs e)
        {
            ReservationInfo ri = new ReservationInfo();
            ri.Show();
            this.Hide();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
