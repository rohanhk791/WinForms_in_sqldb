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
    public partial class filter : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ROHAN\SQLEXPRESS;Initial Catalog=RegistrationDetails;Integrated Security=True");
        detaills det = new detaills();
        public filter()
        {
            InitializeComponent();
        }
        private void filter_Load(object sender, EventArgs e)
        {
            try
            {
                getqualification();
                getcity();
                getstate();
                getcountry();
                if (com_qualification.Items.Count > 0 && com_city.Items.Count > 0 && com_state.Items.Count > 0 && com_country.Items.Count > 0)
                {
                    com_qualification.SelectedIndex = -1;
                    com_city.SelectedIndex = -1;
                    com_state.SelectedIndex = -1;
                    com_country.SelectedIndex = -1;                  
                }
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
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM detail WHERE name ='" + txt_name.Text + "' and age ='" + num_age.Text + "' and city ='" + com_city.Text + "' and state ='" + com_state.Text + "' and country ='" + com_country.Text + "' and phone_no ='" + txt_phone_no.Text + "' and qualification ='" + com_qualification.Text + "' and address ='" + txt_address.Text + "'", con);
                DataTable table = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                table.Load(sdr);
                con.Close();
                dataGridView2.DataSource = table;
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }         
        }
        private void filters_Click(object sender, EventArgs e)
        {
            validate();    
        }

        public void getqualification()
        {   
            try
            {
                string query = "select distinct qualification from detail";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                con.Open();
                DataSet dt = new DataSet();
                dataAdapter.Fill(dt, "qualification");
                com_qualification.DisplayMember = "qualification";
                com_qualification.ValueMember = "qualification";
                com_qualification.DataSource = dt.Tables["qualification"];
                con.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
        //public void getage()
        //{

        //    string query = "select distinct age from detail";
        //    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
        //    con.Open();
        //    DataSet dt = new DataSet();
        //    dataAdapter.Fill(dt, "age");
        //    num_age.DisplayMember = "age";
        //    num_age.ValueMember = "age";
        //    num_age.DataSource = dt.Tables["age"];

        //    con.Close();
        //}
        public void getcity()
        {
            try
            {
                string query = "select distinct city from detail";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                con.Open();
                DataSet dt = new DataSet();
                dataAdapter.Fill(dt, "city");
                com_city.DisplayMember = "city";
                com_city.ValueMember = "city";
                com_city.DataSource = dt.Tables["city"];
                con.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }          
        }
        public void getstate()
        {
            try
            {
                string query = "select distinct state from detail";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                con.Open();
                DataSet dt = new DataSet();
                dataAdapter.Fill(dt, "state");
                com_state.DisplayMember = "state";
                com_state.ValueMember = "state";
                com_state.DataSource = dt.Tables["state"];
                con.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }         
        }
        public void getcountry()
        {
            try
            {
                string query = "select distinct country from detail";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                con.Open();
                DataSet dt = new DataSet();
                dataAdapter.Fill(dt, "country");
                com_country.DisplayMember = "country";
                com_country.ValueMember = "country";
                com_country.DataSource = dt.Tables["country"];
                con.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
        private void filters_Validating(object sender, CancelEventArgs e)
        {               
        }
        public void validate()
        {   
            try
            {
                if (txt_name.Text == string.Empty)
                {
                    filters.Enabled = false;
                    MessageBox.Show("Enter valid Name");
                }
                else
                {
                    filters.Enabled = true;
                    det.Show();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            filters.Enabled = true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
                
        }

        private void filters_Click_1(object sender, EventArgs e)
        {
            detailslist();
        }
    }
}