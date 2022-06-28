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
        SqlConnection con = new SqlConnection(@"Data Source=ROHAN\SQLEXPRESS;Initial Catalog=RegistrationDetails;Integrated Security=True");
        Register reg = new Register();
        private string txt_name;
        private string num_age;

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
            List<string> selectedItem = new List<string>();
            DataGridViewRow datalist = new DataGridViewRow();
            for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
            {
                datalist = dataGridView2.Rows[i];
                if (Convert.ToBoolean(datalist.Cells[0].Value) == true) //checking if  checked or not.  if check is true den it enter if loop 
                {
                    string id = datalist.Cells[1].Value.ToString();
                    selectedItem.Add(id); //if checked adding it to the slist  
                }
            }
            con.Open();
            foreach (string slist in selectedItem) //using foreach loop to delete the records stored in slist.  
            {
                SqlCommand cmd = new SqlCommand("delete from detail where id = '" + slist + "'", con);
                cmd.ExecuteNonQuery();
            }

            con.Close();
            detailslist();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from detail", con);
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
