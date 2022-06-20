using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WinForms_in_sqldb
{
    public class sqlRegistrationDetail
    {
        public int id;
        public int age;
        public long phone_no;

        public string name;
        public string gender;
        public string city;
        public string state;

        public string country;
        public string address;
        public string qualification;

    }

    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        sqlRegistrationDetail sqldet = new sqlRegistrationDetail();
      SqlConnection con = new SqlConnection(@"Data Source=ROHAN\SQLEXPRESS;Initial Catalog=RegistrationDetails;Integrated Security=True");
        public int id;
        private void Register_Load(object sender, EventArgs e)
        {
            detailslist();
        }
        public void detailslist()
        {

            SqlCommand cmd = new SqlCommand("select * from detail", con);
            DataTable table = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            table.Load(sdr);
            con.Close();

            dataGridView1.DataSource = table;

        }
        public bool validate()
        {
            try
            {
                if (string.IsNullOrEmpty(txt_name.Text)) { string message = "Enter valid name"; string title = "Warning"; MessageBox.Show(message, title); return false; }
                if (string.IsNullOrEmpty(rad_male.Text)) { string message = "Enter valid gender"; string title = "Warning"; MessageBox.Show(message, title); }
                if (string.IsNullOrEmpty(txt_qualification.Text)) { string message = "Enter valid qualification"; string title = "Warning"; MessageBox.Show(message, title); return false; }
                if (string.IsNullOrEmpty(com_city.Text)) { string message = "Enter valid city"; string title = "Warning"; MessageBox.Show(message, title); return false; }
                if (string.IsNullOrEmpty(com_state.Text)) { string message = "Enter valid state"; string title = "Warning"; MessageBox.Show(message, title); return false; }
                if (string.IsNullOrEmpty(com_country.Text)) { string message = "Enter valid country"; string title = "Warning"; MessageBox.Show(message, title); return false; }
                if (string.IsNullOrEmpty(txt_address.Text)) { string message = "Enter valid address"; string title = "Warning"; MessageBox.Show(message, title); return false; }

                if (!validmobilenumber()) return false;
                return true;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return false;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                foreach (var clear in this.Controls)
                {
                    if (clear is TextBox)
                    {
                        ((TextBox)clear).Text = String.Empty;
                    }
                    if (clear is ComboBox)
                    {
                        ((ComboBox)clear).Text = String.Empty;
                    }
                    if (clear is NumericUpDown)
                    {
                        ((NumericUpDown)clear).Text = String.Empty;
                    }
                }
            }
        }
        public bool validmobilenumber()
        {
            try
            {
                Regex re = new Regex(@" ^[0 - 9]{ 10 }$");
                if (re.IsMatch(txt_phone_no.Text) || txt_phone_no.Text.Length > 11 || txt_phone_no.Text.Length < 9)
                {
                    string message = "Invalid  Mobile Number !! Enter valid number!!";
                    string title = "Warning";
                    MessageBox.Show(message, title);
                    txt_phone_no.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return false;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                SqlCommand cmd = new SqlCommand("insert into detail values(@name,@age,@gender,@city,@state,@country,@phone_no,@address,@qualification)", con);
                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.AddWithValue("@id", numericUpDown1.Text);
                cmd.Parameters.AddWithValue("@name", txt_name.Text);
                cmd.Parameters.AddWithValue("@age", num_age.Text);
                cmd.Parameters.AddWithValue("@gender", rad_male.Text);
                cmd.Parameters.AddWithValue("@city", com_city.Text);
                cmd.Parameters.AddWithValue("@state", com_state.Text);
                cmd.Parameters.AddWithValue("@country", com_country.Text);
                cmd.Parameters.AddWithValue("@phone_no", txt_phone_no.Text);
                cmd.Parameters.AddWithValue("@address", txt_address.Text);
                cmd.Parameters.AddWithValue("@qualification", txt_qualification.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                string message = "Data Successfully saved in database";
                string title = "Warning";
                MessageBox.Show(message, title);
            }
            else
            {
                string message = "Data unSuccessfully";
                string title = "Warning";
                MessageBox.Show(message, title);
            }
            detailslist();
            }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
            id =Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value);
            txt_name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            num_age.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            rad_male.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            com_city.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            com_state.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            com_country.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txt_phone_no.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txt_address.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txt_qualification.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
        }
    }
   
    }
