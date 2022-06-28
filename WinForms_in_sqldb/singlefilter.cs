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



namespace WinForms_in_sqldb
{
    public partial class singlefilter : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ROHAN\SQLEXPRESS;Initial Catalog=RegistrationDetails;Integrated Security=True");
        detaills det = new detaills();
        public singlefilter()
        {
            InitializeComponent();
        }

        private void singlefilter_Load(object sender, EventArgs e)
        {
            try
            {
                detailslist();
                dataGridView2.Columns[1].Name = "id";
                dataGridView2.Columns[2].Name = "name";
                dataGridView2.Columns[3].Name = "age";
                dataGridView2.Columns[4].Name = "gender";
                dataGridView2.Columns[5].Name = "city";
                dataGridView2.Columns[6].Name = "state";
                dataGridView2.Columns[7].Name = "country";
                dataGridView2.Columns[8].Name = "phone_no";
                dataGridView2.Columns[9].Name = "address";
                dataGridView2.Columns[10].Name = "qualification";
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
        public void detailslist()
        {
            if (com_select.Text == "name")
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM detail WHERE name ='" + txt_name.Text + "'", con);
                DataTable table = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                table.Load(sdr);
                con.Close();
                dataGridView2.DataSource = table;
            }
            if (com_select.Text == "age")
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM detail WHERE age ='" + txt_name.Text + "'", con);
                DataTable table = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                table.Load(sdr);
                con.Close();
                dataGridView2.DataSource = table;
            }
            if (com_select.Text == "gender")
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM detail WHERE gender ='" + txt_name.Text + "'", con);
                DataTable table = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                table.Load(sdr);
                con.Close();
                dataGridView2.DataSource = table;
            }
            if (com_select.Text == "city")
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM detail WHERE city ='" + txt_name.Text + "'", con);
                DataTable table = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                table.Load(sdr);
                con.Close();
                dataGridView2.DataSource = table;
            }
            if (com_select.Text == "state")
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM detail WHERE state ='" + txt_name.Text + "'", con);
                DataTable table = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                table.Load(sdr);
                con.Close();
                dataGridView2.DataSource = table;
            }
            if (com_select.Text == "country")
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM detail WHERE country ='" + txt_name.Text + "'", con);
                DataTable table = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                table.Load(sdr);
                con.Close();
                dataGridView2.DataSource = table;
            }
            if (com_select.Text == "address")
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM detail WHERE address ='" + txt_name.Text + "'", con);
                DataTable table = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                table.Load(sdr);
                con.Close();
                dataGridView2.DataSource = table;
            }
            if (com_select.Text == "phone_no")
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM detail WHERE phone_no ='" + txt_name.Text + "'", con);
                DataTable table = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                table.Load(sdr);
                con.Close();
                dataGridView2.DataSource = table;
            }
            if (com_select.Text == "qualification")
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM detail WHERE qualification ='" + txt_name.Text + "'", con);
                DataTable table = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                table.Load(sdr);
                con.Close();
                dataGridView2.DataSource = table;
            }
            //SqlCommand cmd = new SqlCommand("SELECT * FROM detail WHERE name ='" + txt_name.Text + "'", con);
            //DataTable table = new DataTable();
            //con.Open();
            //SqlDataReader sdr = cmd.ExecuteReader();
            //table.Load(sdr);
            //con.Close();
            //dataGridView2.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            detailslist();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
