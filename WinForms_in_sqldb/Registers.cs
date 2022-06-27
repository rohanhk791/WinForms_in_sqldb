﻿using System;
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
    public partial class Register : Form
    {
        public class sqlRegistrationDetail
        {
            public int id, age;
            public long phone_no;
            public string name, gender, city, state, country, address, qualification;
        }
        public Register()
        {
            InitializeComponent();
        }

        sqlRegistrationDetail sqldet = new sqlRegistrationDetail();
        int _index;
        
        SqlConnection con = new SqlConnection(@"Data Source=ROHAN\SQLEXPRESS;Initial Catalog=RegistrationDetails;Integrated Security=True");                                                                                                                                                                                public int id;

        private void Register_Load(object sender, EventArgs e)
        {
            detailslist();
            dataGridView1.Columns[0].Name = "id";
            dataGridView1.Columns[1].Name = "name";
            dataGridView1.Columns[2].Name = "age";
            dataGridView1.Columns[3].Name = "gender";
            dataGridView1.Columns[4].Name = "city";
            dataGridView1.Columns[5].Name = "state";
            dataGridView1.Columns[6].Name = "country";
            dataGridView1.Columns[7].Name = "phone_no";
            dataGridView1.Columns[8].Name = "address";
            dataGridView1.Columns[9].Name = "qualification";
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
                if (string.IsNullOrEmpty(genderChk()) ) { string message = "Enter valid gender"; string title = "Warning"; MessageBox.Show(message, title); }
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
            clear();          
        }

        public void clear()
        {
         try
            {   
                
                txt_name.Text = string.Empty;
                txt_address.Text = string.Empty;
                txt_phone_no.Text = string.Empty;
                txt_qualification.Text = string.Empty;
                rad_male.Text = string.Empty;
                com_city.Text = string.Empty;
                com_state.Text = string.Empty;
                com_country.Text = string.Empty;
                num_age.Text = string.Empty;

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);                
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
            try
            {
                if (validate())
                {
                    SqlCommand cmd = new SqlCommand("insert into detail values(@name,@age,@gender,@city,@state,@country,@phone_no,@address,@qualification)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@name", txt_name.Text);
                    cmd.Parameters.AddWithValue("@age", num_age.Text);
                    cmd.Parameters.AddWithValue("@gender", genderChk());
                    cmd.Parameters.AddWithValue("@city", com_city.Text);
                    cmd.Parameters.AddWithValue("@state", com_state.Text);
                    cmd.Parameters.AddWithValue("@country", com_country.Text);
                    cmd.Parameters.AddWithValue("@phone_no", txt_phone_no.Text);
                    cmd.Parameters.AddWithValue("@address", txt_address.Text);
                    cmd.Parameters.AddWithValue("@qualification", txt_qualification.Text);
                  
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    string message = "Data saved";
                    string title = "Warning";
                    MessageBox.Show(message, title);
                }
                else
                {
                    //string message = "Data unSuccessfully";
                    //string title = "Warning";
                    //MessageBox.Show(message, title);
                }
                detailslist();
            }

            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        public string genderChk()
        {
            sqlRegistrationDetail sq = new sqlRegistrationDetail();
            if (rad_male.Checked)
                {
                sq.gender = "Male";
                }
            else
            {
                sq.gender = "Female";
            }
            return sq.gender;
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {        
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                    SqlCommand cmd = new SqlCommand("update detail set name = @name,age = @age,gender = @gender,city = @city, state = @state, country = @country, qualification = @qualification where id =@id", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@name", txt_name.Text);
                    cmd.Parameters.AddWithValue("@age", num_age.Text);
                    cmd.Parameters.AddWithValue("@gender", rad_male.Text);
                    cmd.Parameters.AddWithValue("@city", com_city.Text);
                    cmd.Parameters.AddWithValue("@state", com_state.Text);
                    cmd.Parameters.AddWithValue("@country", com_country.Text);
                    cmd.Parameters.AddWithValue("@phone_no", txt_phone_no.Text);
                    cmd.Parameters.AddWithValue("@address", txt_address.Text);
                    cmd.Parameters.AddWithValue("@qualification", txt_qualification.Text);
                    cmd.Parameters.AddWithValue("@id", this.id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    _index = dataGridView1.CurrentCell.RowIndex;

                    dataGridView1.Rows[_index].Cells[1].Value = txt_name.Text;
                    dataGridView1.Rows[_index].Cells[2].Value = num_age.Text;
                    dataGridView1.Rows[_index].Cells[3].Value = rad_male.Text;
                    dataGridView1.Rows[_index].Cells[4].Value = com_city.Text;
                    dataGridView1.Rows[_index].Cells[5].Value = com_state.Text;
                    dataGridView1.Rows[_index].Cells[6].Value = com_country.Text;
                    dataGridView1.Rows[_index].Cells[7].Value = txt_phone_no.Text;
                    dataGridView1.Rows[_index].Cells[8].Value = txt_address.Text;
                    dataGridView1.Rows[_index].Cells[9].Value = txt_qualification.Text;

                    string message = "Data updated";
                    string title = "Warning";
                    MessageBox.Show(message, title);
               
                detailslist();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);

            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            detaills list = new detaills();
            list.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (id > 0)
                {
                    SqlCommand cmd = new SqlCommand("delete from detail where id = @id", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", this.id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    _index = dataGridView1.CurrentCell.RowIndex;
                    dataGridView1.Rows.RemoveAt(_index);

                    string message = "Data deleted";
                    string title = "Warning";
                    MessageBox.Show(message, title);
                    clear();
                }
                else
                {
                    string message = "Data not deleted";
                    string title = "Warning";
                    MessageBox.Show(message, title);
                }
                
            }
            catch(Exception E)
            {
             MessageBox.Show(E.Message);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                     DataGridViewRow edit = dataGridView1.Rows[e.RowIndex];
                     id = Convert.ToInt32(dataGridView1.Rows[_index].Cells["id"].Value);
                     txt_name.Text = edit.Cells["name"].Value.ToString();
                     num_age.Value = Convert.ToInt32(edit.Cells["age"].Value);
                   //genderChk.(edit.Cells["Gender"].Value.ToString());
                   txt_qualification.Text = edit.Cells["qualification"].Value.ToString();
                   com_state.Text = edit.Cells["state"].Value.ToString();
                   com_city.Text = edit.Cells["city"].Value.ToString();
                   com_country.Text = edit.Cells["country"].Value.ToString();
                    txt_phone_no.Text = edit.Cells["phone_no"].Value.ToString();
                   txt_address.Text = edit.Cells["address"].Value.ToString();
                    Show();
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}