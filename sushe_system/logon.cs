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
    public partial class logon : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;user id=root;password=123456;database=sushe_system;";
        private bool logoning = false;
        public logon()
        {
            InitializeComponent();
            
        }
      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logon_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //在这里触发注册事件
        private void button1_Click_1(object sender, EventArgs e)
        {
            if(logoning == false)
            {
                logoning = true;
                logon_suguan();
                logoning = false;
            }
        }

        private void logon_suguan()
        {
            string username = input_name.Text;
            string userid = input_id.Text;
            string userphone = input_phone.Text;
            string userpass = input_password.Text;
            string usersex = input_sex.Text;
            string userdorm = input_dorm.Text;
            int usertype = 1;

            /// 检验是否有某个输入框为空
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(userid) || string.IsNullOrEmpty(userphone) ||
                string.IsNullOrEmpty(userpass) || string.IsNullOrEmpty(usersex) || string.IsNullOrEmpty(userdorm))
            { // if
                MessageBox.Show("请将注册信息填写完整！");
                return;
            }

            try
            {
                // 建立数据库连接
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    //查询数据库中是否存在这个用户
                    string sqlQuery = "SELECT * FROM login_tabel WHERE user_id = @id ";
                    MySqlCommand command = new MySqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@id", userid);
                    
                    // 创建 MySqlDataAdapter 对象，用于从数据库中检索数据
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    // 使用 MySqlDataAdapter 填充 DataTable，执行查询操作
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        // 用户验证通过，获取用户信息
                        MessageBox.Show("用户已存在！");
                        
                        //既然用户已存在，这些信息没有必要继续存在，清除等待用户重新输入
                        clear_input();

                        return ;

                    }


                    string logon_insert = "INSERT INTO login_tabel (user_id , user_name , user_type , password) VALUES (@userid ,@username,@usertype,@userpass)";
                    MySqlCommand add_command1 = new MySqlCommand(logon_insert, connection);
                    add_command1.Parameters.AddWithValue("@userid", userid);
                    add_command1.Parameters.AddWithValue("@username", username);
                    add_command1.Parameters.AddWithValue("@usertype", usertype);
                    add_command1.Parameters.AddWithValue("@userpass", userpass);
                    add_command1.ExecuteNonQuery();

                    string suguan_insert = "INSERT INTO suguan_info (user_type , user_name , user_id ,  user_phone , user_sex , manage_dorm ) VALUES (@usertype ,@username , @userid , @userphone , @usersex , @userdorm)";
                    MySqlCommand add_command2 = new MySqlCommand(suguan_insert, connection);
                    add_command2.Parameters.AddWithValue("@userid", userid);
                    add_command2.Parameters.AddWithValue("@username", username);
                    add_command2.Parameters.AddWithValue("@usertype", usertype);
                    add_command2.Parameters.AddWithValue("@userphone", userphone);
                    add_command2.Parameters.AddWithValue("@usersex", usersex);
                    add_command2.Parameters.AddWithValue("@userdorm", userdorm);
                    add_command2.ExecuteNonQuery();
                    
                    //注册成功，清除输入
                    clear_input();
                    MessageBox.Show("用户已成功注册！");

                    //跳转去登录页面
                    goto_login();



                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("注册用户时出现错误：" + ex.Message);
            }

        }

        private void goto_login()
        {
            var Login = new login();
            this.Close();
            Login.Show();
        }
        private void clear_input()
        {
            input_name.Clear();
            input_id.Clear();
            input_password.Clear();
            input_phone.Clear();
            input_sex.SelectedIndex = -1;
            input_dorm.SelectedIndex = -1;
        }
        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
           
            inner.main_obj.Show();


        }

        private void phone_Click(object sender, EventArgs e)
        {

        }

        private void sex_Click(object sender, EventArgs e)
        {

        }

        private void logon_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
