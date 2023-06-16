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
    public partial class login : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;user id=root;password=123456;database=sushe_system;";
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        // 登录
        private void button3_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string password = textBox2.Text;
            if (ValidateUser(id, password, out DataRow userInfo))
            {
                // 用户验证成功
                MessageBox.Show("登录成功！");

                string user_id = userInfo["user_id"].ToString();
                string user_type = userInfo["user_type"].ToString();
                // 其他需要的信息
                DataTable userAdditionalInfo = GetUserAdditionalInfo(user_id,user_type);

                DataRow user_info = userAdditionalInfo.Rows[0];

                
                //将信息同步到全局静态类，方便后续访问
                if(user_type == "1")
                {
                    UserInfo.SetSuguanInfo(user_info);
                    suguan_Main suguan = new suguan_Main();
                    this.Hide();
                    suguan.Show();
                }else if(user_type == "2")
                {
                    UserInfo.SetShequInfo(user_info);

                    //todo 显示社区的页面
                    this.Hide();
                    (new shequ_stu()).Show();
                }
                // 进行登录后的操作

            }
            else
            {
                // 用户验证失败
                MessageBox.Show("学工号或密码错误！");
            }
        }

        // 登录函数
        private bool ValidateUser(string id, string password, out DataRow userInfo)
        {
            userInfo = null;

            try
            {
                // 建立数据库连接
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM login_tabel WHERE user_id = @id AND password = @password";
                    MySqlCommand command = new MySqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@password", password);

                    // 创建 MySqlDataAdapter 对象，用于从数据库中检索数据
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    // 使用 MySqlDataAdapter 填充 DataTable，执行查询操作
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        // 用户验证通过，获取用户信息
                        userInfo = dataTable.Rows[0];
                        

                        return true;

                    }
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message);
            }

            return false;
        }

        private DataTable GetUserAdditionalInfo(string id,string user_type)
        {
            DataTable userAdditionalInfo = new DataTable();

            try
            {
                // 创建并执行查询用户在另一个表中的所有信息的SQL语句
                string tosearch = user_type == "1" ? "suguan_info" : "shequ_info";
                string sqlQuery = "SELECT * FROM "+ tosearch + "  WHERE user_id = @id ";
                using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(userAdditionalInfo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message);
            }

            return userAdditionalInfo;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            logon Logon = new logon();
            this.Close();
            Logon.Show();
           
        }

        private void login_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);

            //connection.Open();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            (new inner()).Show();
        }
    }
}
