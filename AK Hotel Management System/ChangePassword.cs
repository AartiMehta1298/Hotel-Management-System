using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace AK_Hotel_Management_System
{
    public partial class ChangePassword : Form
    {
        string username = sendcode.to;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(txtnewpass.Text == txtconpass.Text)
            {
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=akhotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd = new SqlCommand("UPDATE tblForgetPass set Password='" + txtconpass.Text + "' where userEmail='"+username+"'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password Reset Successfully...");
            }
            else
            {
                MessageBox.Show("The new Password do not Match  ...");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
