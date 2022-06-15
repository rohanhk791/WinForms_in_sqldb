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
   
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
        private void RegisterDetails()
        {
            Sqlconnection sql = new Sqlconnection("");
        }
    }
    public class RegistrationDetails
    {
        public int id { get; set; }
        public int age { get; set; }
        public long phone_no { get; set; }

        public string name { get; set; }
        public string gender { get; set; }
        public string city { get; set; }
        public string state { get; set; }

        public string country { get; set; }
        public string address { get; set; }
        public string qualification { get; set; }

    }
}
