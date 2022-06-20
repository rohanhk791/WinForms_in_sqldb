using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void detaills_Load(object sender, EventArgs e)
        {
            //reg.detailslist();
        }
    }
}
