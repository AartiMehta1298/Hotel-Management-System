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
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            splashbar.Value = startpoint;
            if(splashbar.Value == 100)
            {
                splashbar.Value = 0;
                timer1.Stop();
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FirstPage_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
    }
}
