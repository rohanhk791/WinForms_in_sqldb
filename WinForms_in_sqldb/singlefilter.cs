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
            pan_name.Visible = false;
            pan_age.Visible = false;
            pan_gender.Visible = false;
            pan_city.Visible = false;
            pan_state.Visible = false;
            pan_country.Visible = false;
            pan_address.Visible = false;
            pan_phone_no.Visible = false;
            pan_qualification.Visible = false;
            try
            {
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

                if (com_select.Text == string.Empty)
                {                  
                    hidePannel();
                }                           
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
        public void hidePannel()
        {
            //pan_griddata.Visible = true;         
            pan_name.Visible = false;
            //pan_gender.Visible = false;
            pan_age.Visible = false;
            //pan_city.Visible = false;
            //pan_country.Visible = false;
            //pan_state.Visible = false;
            //pan_address.Visible = false;
            //pan_phone_no.Visible = false;
            //pan_qualification.Visible = false;
        }
        public void detailslist()
        {
            if (com_select.Text == "name")
            {            
                pan_name.Show();
                pan_name.BringToFront();
                SqlCommand cmd = new SqlCommand("SELECT * FROM detail WHERE name ='" + txt_name.Text + "'", con);
                DataTable table = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                table.Load(sdr);
                con.Close();
                dataGridView2.DataSource = table;
                dataGridView2.Show();
            }
            if (com_select.Text == "age")
            {
                pan_age.Show();
                pan_age.BringToFront();
                SqlCommand cmd = new SqlCommand("SELECT * FROM detail WHERE age ='" + num_age.Text + "'", con);
                DataTable table = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                table.Load(sdr);
                con.Close();
                dataGridView2.DataSource = table;
                dataGridView2.Show();
            }
            if (com_select.Text == "gender")
            {
                pan_gender.Show();
                pan_gender.BringToFront();
                SqlCommand cmd = new SqlCommand("SELECT * FROM detail WHERE gender ='" + rad_male + "'", con);
                DataTable table = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                table.Load(sdr);
                con.Close();
                dataGridView2.DataSource = table;
            }
            if (com_select.Text == "city")
            {
                pan_city.Show();
                pan_city.BringToFront();

                SqlCommand cmd = new SqlCommand("SELECT * FROM detail WHERE city ='" + com_city.Text + "'", con);
                DataTable table = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                table.Load(sdr);
                con.Close();
                dataGridView2.DataSource = table;
            }
            if (com_select.Text == "state")
            {
                pan_state.Show();
                pan_state.BringToFront();
                SqlCommand cmd = new SqlCommand("SELECT * FROM detail WHERE state ='" + com_state.Text + "'", con);
                DataTable table = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                table.Load(sdr);
                con.Close();
                dataGridView2.DataSource = table;
            }
            if (com_select.Text == "country")
            {
                pan_country.Show();
                pan_country.BringToFront();
                SqlCommand cmd = new SqlCommand("SELECT * FROM detail WHERE country ='" + com_country.Text + "'", con);
                DataTable table = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                table.Load(sdr);
                con.Close();
                dataGridView2.DataSource = table;
            }
            if (com_select.Text == "address")
            {
                pan_address.Show();
                pan_address.BringToFront();
                SqlCommand cmd = new SqlCommand("SELECT * FROM detail WHERE address ='" + txt_address.Text + "'", con);
                DataTable table = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                table.Load(sdr);
                con.Close();
                dataGridView2.DataSource = table;
            }
            if (com_select.Text == "phone_no")
            {
                pan_phone_no.Show();
                pan_phone_no.BringToFront();
                SqlCommand cmd = new SqlCommand("SELECT * FROM detail WHERE phone_no ='" + txt_phone_no.Text + "'", con);
                DataTable table = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                table.Load(sdr);
                con.Close();
                dataGridView2.DataSource = table;
            }
            if (com_select.Text == "qualification")
            {
                pan_qualification.Show();
                pan_qualification.BringToFront();
                SqlCommand cmd = new SqlCommand("SELECT * FROM detail WHERE qualification ='" + com_qualification.Text + "'", con);
                DataTable table = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                table.Load(sdr);
                con.Close();
                dataGridView2.DataSource = table;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            detailslist();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void com_select_Validating(object sender, CancelEventArgs e)
        {

        }

        private void com_select_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            detailslist();
        }

        private void com_select_Click(object sender, EventArgs e)
        {

            detailslist();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rad_female_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
