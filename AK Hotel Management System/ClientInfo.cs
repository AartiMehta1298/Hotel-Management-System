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

    public partial class ClientInfo : Form
    {
        public void populate()
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=akhotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            con.Open();
            string myquery = "select * from Client_tbl";
            SqlDataAdapter da = new SqlDataAdapter(myquery, con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ClientGridView.DataSource = ds.Tables[0];
            
            con.Close();
        }
        public ClientInfo()
        {
            InitializeComponent();
        }

        private void ClientInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'akhotelDataSet.Client_tbl' table. You can move, or remove it, as needed.
            this.client_tblTableAdapter.Fill(this.akhotelDataSet.Client_tbl);
            lblDate.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            //populate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongTimeString();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=akhotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Client_tbl values('"+ClientIdlbl.Text+"','"+ClientNamelbl.Text+"','"+ClientPhonelbl.Text+"','"+Clienctrylbl.SelectedItem.ToString()+"')",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Added Successfully");
            con.Close();
            populate();

        }

        private void ClientGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClientIdlbl.Text = ClientGridView.SelectedRows[0].Cells[0].Value.ToString();
            ClientNamelbl.Text = ClientGridView.SelectedRows[0].Cells[0].Value.ToString();
            ClientPhonelbl.Text = ClientGridView.SelectedRows[0].Cells[0].Value.ToString();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=akhotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            con.Open();
            string Myquery =  "Update Client_tbl set ClientName='" + ClientNamelbl.Text + "',ClientPhone='" + ClientPhonelbl.Text + "',ClientCountry='" + Clienctrylbl.SelectedItem.ToString() + "' where clientId='"+ClientIdlbl.Text+"';";
            SqlCommand cmd = new SqlCommand(Myquery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client  Successfully Edited");
            con.Close();
            populate();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=akhotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            con.Open();
            string query = "delete from Client_tbl where ClientId ='" + ClientIdlbl.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Deleted Successfully");
            con.Close();
            populate();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=akhotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            con.Open();
            string myquery = "select * from Client_tbl where ClientName ='" + btnsearch.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(myquery, con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ClientGridView.DataSource = ds.Tables[0];

            con.Close();



        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClientNamelbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClientPhonelbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClientIdlbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clintButton2_Click(object sender, EventArgs e)
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
