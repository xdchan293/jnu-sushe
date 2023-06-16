using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sushe_system
{
    public partial class add_yegui : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;user id=root;password=123456;database=sushe_system;";
        private bool submiting = false;
        public add_yegui()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var main = new suguan_Main();
            this.Close();
            main.Show();
        }
    }
}
