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
   
    public partial class detaills : Form
    {
        Register reg = new Register();
      
        public detaills()
        {
         
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            reg.detailslist();
    
          
        }
        public void detailslist()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ROHAN\SQLEXPRESS;Initial Catalog=RegistrationDetails;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from detail", con);
            DataTable table = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            table.Load(sdr);
            con.Close();
            dataGridView1.DataSource = table;
        }

        private void detaills_Load(object sender, EventArgs e)
        {
            detailslist();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
        
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
