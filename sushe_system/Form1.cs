using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sushe_system
{
    public partial class inner : Form
    {
        public static inner main_obj;
        public inner()
        {
            InitializeComponent();
            main_obj = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            var Login = new login();
            this.Hide();
            Login.Show();
        }

        private void suguan_logon_Click(object sender, EventArgs e)
        {
            var Logon = new logon();
            this.Hide();
            Logon.Show();
        }

        private void logon_shequ_Click(object sender, EventArgs e)
        {
            var Logon = new logon_shequ();
            this.Hide();
            Logon.Show();
        }

        private void fix_Click(object sender, EventArgs e)
        {
            var apply = new apply_fix();
            this.Hide();
            apply.Show();   
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
