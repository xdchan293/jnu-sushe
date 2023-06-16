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
    public partial class suguan_Main : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;user id=root;password=123456;database=sushe_system;";
        private bool searching = false;

        private DataTable dataTable;
        private int currentPage = 1; // 当前页数
        private int pageSize = 10; // 每页显示的记录数
        public suguan_Main()
        {
            InitializeComponent();
        }
        private void suguan_Main_Load(object sender, EventArgs e)
        {
            loudong.Text = "当前管理楼栋：" + UserInfo.manage_dorm;
            dataGridView1.Font = new Font("Times New Roman", 12);
             
            
        }
        private void search_Click(object sender, EventArgs e)
        {
            if (searching == false)
            {
                searching = true;
                searchinfo();
                searching = false;
            }
        }

        private void set_col()
        {
            dataGridView1.Columns["stu_id"].HeaderText = "学号";
            dataGridView1.Columns["stu_name"].HeaderText = "姓名";
            dataGridView1.Columns["stu_sex"].HeaderText = "性别";
            dataGridView1.Columns["stu_phone"].HeaderText = "手机号码";
            dataGridView1.Columns["major"].HeaderText = "专业";
            dataGridView1.Columns["dorm_num"].HeaderText = "宿舍号";
            dataGridView1.Columns["college"].HeaderText = "学院";
            dataGridView1.Columns["dorm"].HeaderText = "楼栋";
        }

        // 把请求
        private void searchinfo()
        {
            try
            {
                // 建立数据库连接
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    //初始查询语句
                    string sqlQuery = "SELECT * FROM student WHERE dorm = " + "'"+UserInfo.manage_dorm + "'";

                    if(input_id.Text != "学生学号")
                    {
                        sqlQuery += " AND stu_id LIKE '%" + input_id.Text + "%'";
                    }

                    if (input_name.Text != "学生姓名")
                    {
                        sqlQuery += " AND stu_name LIKE '%" + input_name.Text + "%'";
                    }

                    if (input_dormnum.Text != "宿舍号")
                    {
                        sqlQuery += " AND dorm_num LIKE '%" + input_dormnum.Text + "%'";
                    }

                    MySqlCommand command = new MySqlCommand(sqlQuery, connection);
                    //command.Parameters.AddWithValue("@dorm", UserInfo.manage_dorm);


                    // 创建 MySqlDataAdapter 对象，用于从数据库中检索数据
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    dataTable = new DataTable();

                    // 使用 MySqlDataAdapter 填充 DataTable，执行查询操作
                    adapter.Fill(dataTable);
                    
                    dataGridView1.DataSource = dataTable;
                    set_col();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message);
            }
        }
        private void yegui_form_Click(object sender, EventArgs e)
        {
            var yegui = new submit_yegui();
            this.Close();
            yegui.Show();
        }

       
        private void input_id_Click(object sender, EventArgs e)
        {
            string temp = input_id.Text;
            if (temp == "学生学号")
            {
                input_id.Clear();
            }
        }
        private void input_id_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(input_id.Text))
            {
                input_id.Text = "学生学号";
            }
        }

        private void input_name_Click(object sender, EventArgs e)
        {
            if (input_name.Text == "学生姓名")
            {
                input_name.Clear();
            }
        }

        private void input_name_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(input_name.Text))
            {
                input_name.Text = "学生姓名";
            }
        }

        private void input_dormnum_Click(object sender, EventArgs e)
        {
            if (input_dormnum.Text == "宿舍号")
            {
                input_dormnum.Clear();
            }
        }

        private void input_dormnum_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(input_dormnum.Text))
            {
                input_dormnum.Text = "宿舍号";
            }
        }




        //加载logo



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void id_Click(object sender, EventArgs e)
        {
            this.Close();
            (new yegui()).Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            (new fixcheck()).Show();
        }

        private void suguan_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            (new inner()).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
