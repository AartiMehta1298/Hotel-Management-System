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

namespace AK_Hotel_Management_System
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=akhotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();

            SqlDataAdapter adpt = new SqlDataAdapter("select COUNT(*) from Staff_tbl WHERE StaffName='" + Usernametxt.Text + "' and   StaffPassword='" + Passwordtxt.Text + "'", con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            if(dt.Rows[0][0].ToString() == "1")
            {
                MainForm mf = new MainForm();
                mf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }
            con.Close();

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Usernametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            sendcode sc = new sendcode();
            sc.Show();
            this.Hide();

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
