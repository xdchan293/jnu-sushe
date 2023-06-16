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
    public partial class shequ_stu : Form
    {

        private MySqlConnection connection;
        private string connectionString = "server=localhost;user id=root;password=123456;database=sushe_system;";
        private bool searching = false;
        private bool hasbtn = false;

        private DataTable dataTable;
        public shequ_stu()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
             if(searching == false)
            {
                searching = true;
                search_stu();
                searching = false;

            }
        }

        private void search_stu()
        {
            try
            {
                // 建立数据库连接
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    //初始查询语句
                    string sqlQuery = "SELECT * FROM student" ;

                    if(input_id.Text != "学生学号" || input_name.Text != "学生姓名" || input_dormnum.Text != "宿舍号" || input_college.Text != "学院" || input_major.Text != "专业" || input_dorm.Text != "楼栋")
                    {
                        sqlQuery += " WHERE ";
                        
                    }
                    int len = sqlQuery.Length;

                    if (input_id.Text != "学生学号")
                    {
                        sqlQuery += " stu_id LIKE '%" + input_id.Text + "%'";
                    }

                    if (input_name.Text != "学生姓名")
                    {
                        if(sqlQuery.Length > len)
                        {
                            sqlQuery += "AND";
                        }
                        sqlQuery += " stu_name LIKE '%" + input_name.Text + "%'";
                    }

                    if (input_dormnum.Text != "宿舍号")
                    {

                        if (sqlQuery.Length > len)
                        {
                            sqlQuery += "AND";
                        }
                        sqlQuery += " dorm_num LIKE '%" + input_dormnum.Text + "%'";
                    }

                    if (input_college.Text != "学院")
                    {
                        if (sqlQuery.Length > len)
                        {
                            sqlQuery += "AND";
                        }
                        sqlQuery += "  college LIKE '%" + input_college.Text + "%'";
                    }

                    if (input_major.Text != "专业")
                    {
                        if (sqlQuery.Length > len)
                        {
                            sqlQuery += "AND";
                        }
                        sqlQuery += "  major LIKE '%" + input_major.Text + "%'";
                    }

                    if (input_dorm.Text != "楼栋")
                    {
                        if (sqlQuery.Length > len)
                        {
                            sqlQuery += "AND";
                        }
                        sqlQuery += "  dorm  ='" + input_dorm.Text + "'";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hadel_tiaosu(DataGridViewRow currentRow)
        {
            (new changedorm(currentRow)).Show();
        }
        private void input_id_Click(object sender, EventArgs e)
        {
            
            if (input_id.Text == "学生学号")
            {
                input_id.Clear();
            }
        }

        private void input_id_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(input_id.Text))
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

        private void input_college_Click(object sender, EventArgs e)
        {
            if (input_college.Text == "学院")
            {
                input_college.Clear();
            }
        }

        private void input_college_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(input_college.Text))
            {

                input_college.Text = "学院";
            }
        }

        private void input_major_Click(object sender, EventArgs e)
        {
            if (input_major.Text == "专业")
            {
                input_major.Clear();
            }
        }

        private void input_major_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(input_major.Text))
            {

                input_major.Text = "专业";
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

            if(hasbtn == false)
            {
                // 创建第一个按钮列
                DataGridViewButtonColumn buttonColumn1 = new DataGridViewButtonColumn();
                buttonColumn1.Name = "tiaosu";
                buttonColumn1.HeaderText = "操作1";
                buttonColumn1.Text = "调宿";
                buttonColumn1.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(buttonColumn1);

                // 创建第二个按钮列
               /*
                DataGridViewButtonColumn buttonColumn2 = new DataGridViewButtonColumn();
                buttonColumn2.Name = "tuisu";
                buttonColumn2.HeaderText = "操作2";
                buttonColumn2.Text = "退宿";
                buttonColumn2.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(buttonColumn2);
               */
                hasbtn = true;
            }
        }

        private void input_dorm_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(input_dorm.Text))
            {

                input_dorm.Text = "楼栋";
            }
        }

        private void shequ_stu_Load(object sender, EventArgs e)
        {
            dataGridView1.Font = new Font("Times New Roman", 12);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            (new shequ_dorm()).Show();
        }

        private void id_Click(object sender, EventArgs e)
        {
            this.Close();
            (new shequ_yegui()).Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // 检查点击的单元格是否属于按钮列
                if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    // 处理按钮点击事件



                    /*
                      dataGridView1.Columns["dorm_num"].HeaderText = "宿舍号";
            dataGridView1.Columns["dorm"].HeaderText = "楼栋";
            dataGridView1.Columns["event_type"].HeaderText = "报修类型";
            dataGridView1.Columns["event_detail"].HeaderText = "报修备注";
            dataGridView1.Columns["event_status"].HeaderText = "受理情况";
            dataGridView1.Columns["event_time"].HeaderText = "报修时间";
                     */


                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    // 这
                    hadel_tiaosu(row);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            (new inner()).Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
