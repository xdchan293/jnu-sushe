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
    public partial class apply_fix : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;user id=root;password=123456;database=sushe_system;";
        private bool submiting = false;
        public apply_fix()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();

            inner.main_obj.Show();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            
            //节流阀
            if (submiting == false)
            {
                submiting = true;
                sub_fix();
                submiting = false;
            }
        }

        //添加报修事项
        private void sub_fix()
        {
            
            string type = fix_reason.Text;
            string dorm = input_dorm.Text;
            string dorm_num = input_dorm_num.Text;
            string detail = input_detail.Text;
            string status = "未处理";
            string time = DateTime.Now.ToString("yyyy-MM-dd");

            if(string.IsNullOrEmpty(type) || string.IsNullOrEmpty(dorm) || string.IsNullOrEmpty(dorm_num))
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
                    string sqlQuery = "SELECT * FROM baoxiu WHERE dorm = @dorm AND dorm_num = @dorm_num";
                    MySqlCommand query_command = new MySqlCommand(sqlQuery, connection);
                    query_command.Parameters.AddWithValue("@dorm", dorm);
                    query_command.Parameters.AddWithValue("@dorm_num", dorm_num);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query_command);
                    DataTable dataTable = new DataTable();

                    // 使用 MySqlDataAdapter 填充 DataTable，执行查询操作
                    adapter.Fill(dataTable);
                    string event_id = dorm + dorm_num + (dataTable.Rows.Count+1);

                    //
                    string insert_event = "INSERT INTO baoxiu (dorm , dorm_num , event_type , event_detail, event_status , event_time,event_id) VALUES (@dorm ,@dorm_num,@type,@detail , @status , @time,@event_id)";
                    MySqlCommand add_command = new MySqlCommand(insert_event, connection);
                    add_command.Parameters.AddWithValue("@dorm", dorm);
                    add_command.Parameters.AddWithValue("@dorm_num", dorm_num);
                    add_command.Parameters.AddWithValue("@type", type);
                    add_command.Parameters.AddWithValue("@detail", detail);
                    add_command.Parameters.AddWithValue("@status", status);
                    add_command.Parameters.AddWithValue("@time", time);
                    add_command.Parameters.AddWithValue("@event_id", event_id);
                    add_command.ExecuteNonQuery();

                    MessageBox.Show("提交成功！");

                    clear_input();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("提交时出现错误：" + ex.Message);
            }

        }

        private void clear_input()
        {
            fix_reason.SelectedIndex = -1;
            input_dorm.SelectedIndex = -1;
            input_dorm_num.Clear();
            input_detail.Clear();

        }

        private void apply_fix_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void apply_fix_Load(object sender, EventArgs e)
        {

        }
    }
    
}
