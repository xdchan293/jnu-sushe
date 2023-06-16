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
    public partial class changedorm : Form
    {
        private DataGridViewRow currentRow;
        private MySqlConnection connection;
        private string connectionString = "server=localhost;user id=root;password=123456;database=sushe_system;";
        private bool searching = false;
        public changedorm(DataGridViewRow Row)
        {
            InitializeComponent();
            currentRow = Row;
        }

        private void changedorm_Load(object sender, EventArgs e)
        {
            input_dorm.Text = currentRow.Cells["dorm"].Value.ToString();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sure_Click(object sender, EventArgs e)
        {
            if(input_dormnum.Text == currentRow.Cells["dorm_num"].Value.ToString() && input_dorm.Text == currentRow.Cells["dorm"].Value.ToString())
            {
                MessageBox.Show("该学生的宿舍未改动!");
                return;
            }
            if(input_dormnum.Text == "宿舍号"|| string.IsNullOrWhiteSpace(input_dorm.Text))
            {
                MessageBox.Show("存在未填项!");
                return;
            }
            try
            {
                // 建立数据库连接
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    //初始查询语句
                    string sqlQuery = "SELECT * FROM dorm_detail WHERE ";
                    sqlQuery += " dorm = '" + input_dorm.Text + "'";
                    sqlQuery += " AND dorm_num = '" + input_dormnum.Text + "'";
                    

                   

                    MySqlCommand command = new MySqlCommand(sqlQuery, connection);
                    //command.Parameters.AddWithValue("@dorm", UserInfo.manage_dorm);


                    // 创建 MySqlDataAdapter 对象，用于从数据库中检索数据
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    // 使用 MySqlDataAdapter 填充 DataTable，执行查询操作
                    adapter.Fill(dataTable);
                    int num_person;
                    if(dataTable.Rows.Count < 1)
                    {
                        MessageBox.Show("信息有误！");
                        return;
                    }
                    int.TryParse(dataTable.Rows[0]["person_num"].ToString(), out num_person);
                    
                    if(num_person == 5)
                    {
                        MessageBox.Show("该宿舍已满！");
                        return;
                    }

                    //调宿舍 主体
                    //修改学生信息
                    string changet_stu = "UPDATE  student SET dorm = '"+ input_dorm.Text+"' , dorm_num = '"+ input_dormnum.Text + "' where stu_id = '"+ currentRow.Cells["stu_id"].Value.ToString() +"'";
                    MySqlCommand c1_command = new MySqlCommand(changet_stu, connection);
                    c1_command.ExecuteNonQuery();
                    //修改原宿舍信息
                    string changet_yuansushe = "UPDATE  dorm_detail SET person_num = person_num-1 where dorm_id = '" + currentRow.Cells["dorm"].Value.ToString() + "-" + currentRow.Cells["dorm_num"].Value.ToString() +"'";
                    MySqlCommand c2_command = new MySqlCommand(changet_yuansushe, connection);
                    c2_command.ExecuteNonQuery();
                    //修改现宿舍信息
                    string changet_xiansushe = "UPDATE  dorm_detail SET person_num = person_num+1 where dorm_id = '" + input_dorm.Text + "-" + input_dormnum.Text + "'";
                    MySqlCommand c3_command = new MySqlCommand(changet_xiansushe, connection);
                    c3_command.ExecuteNonQuery();

                    MessageBox.Show("修改成功！");
                    this.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message);
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
    }
}
