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
    public partial class submit_yegui : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;user id=root;password=123456;database=sushe_system;";
        private bool submiting = false;
        public submit_yegui()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var main = new suguan_Main();
            this.Close();
            main.Show();
        }

        private void sub_yegui()
        {
            string name = input_name.Text;
            string id = input_id.Text;
            string dorm_num = input_dorm_num.Text;
            string reason = input_detail.Text;
            string dorm = UserInfo.manage_dorm;
            string time = DateTime.Now.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(reason) || string.IsNullOrEmpty(dorm_num))
            {
                MessageBox.Show("请将信息填写完整！");
                return;
            }

            try
            {
                // 建立数据库连接
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    //
                    string insert_event = "INSERT INTO yegui (stu_name , stu_id , dorm , dorm_num , yegui_time , reason) VALUES (@name ,@id,@dorm,@dorm_num , @time , @reason)";
                    MySqlCommand add_command = new MySqlCommand(insert_event, connection);
                    add_command.Parameters.AddWithValue("@name", name);
                    add_command.Parameters.AddWithValue("@id", id);
                    add_command.Parameters.AddWithValue("@dorm", dorm);
                    add_command.Parameters.AddWithValue("@dorm_num", dorm_num);
                    add_command.Parameters.AddWithValue("@time", time);
                    add_command.Parameters.AddWithValue("@reason", reason);
                    add_command.ExecuteNonQuery();

                    MessageBox.Show("提交成功！");

                    clear_input();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("提交出现错误：" + ex.Message);
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (submiting == false)
            {
                submiting = true;
                sub_yegui();
                submiting = false;
            }
        }

        private void clear_input()
        {
            input_name.Clear();
            input_id.Clear();
            input_dorm_num.Clear();
            input_detail.Clear();
        }
    }
}
