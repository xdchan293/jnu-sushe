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
    public partial class shequ_yegui : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;user id=root;password=123456;database=sushe_system;";
        private bool searching = false;
        private DataTable dataTable;
        public shequ_yegui()
        {
            InitializeComponent();

            int currentYear = DateTime.Now.Year;
            for (int year = currentYear - 3; year <= currentYear; year++)
            {
                comboYear.Items.Add(year.ToString());
                endYear.Items.Add(year.ToString());
            }

            // 填充月份选项
            for (int month = 1; month <= 12; month++)
            {
                comboMonth.Items.Add(month.ToString("00"));
                endMon.Items.Add(month.ToString("00"));
            }
        }

        private void UpdateBeginDayOptions()
        {
            // 清空日期选项
            comboDay.Items.Clear();

            // 获取当前选择的年份和月份
            int selectedYear = int.Parse(comboYear.SelectedItem.ToString());
            int selectedMonth = int.Parse(comboMonth.SelectedItem.ToString());

            // 根据年份和月份计算天数
            int daysInMonth = DateTime.DaysInMonth(selectedYear, selectedMonth);

            // 填充日期选项
            for (int day = 1; day <= daysInMonth; day++)
            {
                comboDay.Items.Add(day.ToString("00"));
            }

            // 设置默认选中的日期
            comboDay.SelectedItem = DateTime.Now.Day.ToString("00");


        }

        private void UpdateEndDayOptions()
        {
            // 清空日期选项
            endDay.Items.Clear();

            // 获取当前选择的年份和月份

            int selectedYear = int.Parse(endYear.SelectedItem.ToString());
            int selectedMonth = int.Parse(endMon.SelectedItem.ToString());

            // 根据年份和月份计算天数
            int daysInMonth = DateTime.DaysInMonth(selectedYear, selectedMonth);

            // 填充日期选项
            for (int day = 1; day <= daysInMonth; day++)
            {
                endDay.Items.Add(day.ToString("00"));
            }

            // 设置默认选中的日期
            endDay.SelectedItem = DateTime.Now.Day.ToString("00");


        }
        private void search_Click(object sender, EventArgs e)
        {
            if(searching == false)
            {
                searching = true;
                search_yegui();
                searching = false;
            }
        }

        private void search_yegui()
        {
            try
            {
                // 建立数据库连接
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    //初始查询语句
                    string sqlQuery = "SELECT * FROM yegui";

                    if (input_id.Text != "学生学号" || input_name.Text != "学生姓名" || input_dormnum.Text != "宿舍号"  || input_dorm.Text != "楼栋" || comboDay.Text != "日" || endDay.Text != "日" || comboYear.Text != "年" || (comboYear.Text == "年" && endYear.Text != "年"))
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
                        if (sqlQuery.Length > len)
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

                   

                    if (input_dorm.Text != "楼栋")
                    {
                        if (sqlQuery.Length > len)
                        {
                            sqlQuery += "AND";
                        }
                        sqlQuery += "  dorm LIKE '=" + input_dorm.Text + "'";
                    }

                    if (comboDay.Text != "日")
                    {
                        if (sqlQuery.Length > len)
                        {
                            sqlQuery += "AND";
                        }
                        string begintime = comboYear.Text + "-" + comboMonth.Text + "-" + comboDay.Text;
                        if(endDay.Text != "日")
                        {
                            string endtime = endYear.Text + "-" + endMon.Text + "-" + endDay.Text;
                            sqlQuery += "yegui_time BETWEEN " + "'" + begintime + "'" + " AND "  + "'" + endtime + "'";
                        }else
                        {
                            sqlQuery += "yegui_time >= " + "'" + begintime + "' " + " AND yegui_time<= NOW()";
                        }
                        
                    }
                    else if (comboYear.Text != "年")
                    {
                        //"%'"
                        if (sqlQuery.Length > len)
                        {
                            sqlQuery += "AND";
                        }
                        sqlQuery += " yegui_time LIKE '%" + comboYear.Text;
                        if (comboMonth.Text != "月")
                        {
                            sqlQuery += "-" + comboMonth.Text;
                        }
                        sqlQuery += "%'";
                    }
                    else if (comboYear.Text == "年" && endYear.Text != "年")
                    {
                        //"%'"
                        if (sqlQuery.Length > len)
                        {
                            sqlQuery += "AND";
                        }
                        sqlQuery += " yegui_time LIKE '%" + endYear.Text;
                        if (endMon.Text != "月")
                        {
                            sqlQuery += "-" + endMon.Text;
                        }
                        sqlQuery += "%'";
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

        private void set_col()
        {
            dataGridView1.Columns["stu_id"].HeaderText = "学号";
            dataGridView1.Columns["stu_name"].HeaderText = "姓名";
            dataGridView1.Columns["dorm_num"].HeaderText = "宿舍号";
            dataGridView1.Columns["dorm"].HeaderText = "楼栋";
            dataGridView1.Columns["reason"].HeaderText = "原因";
            dataGridView1.Columns["yegui_time"].HeaderText = "时间";
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

        private void input_dorm_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(input_dorm.Text))
            {

                input_dorm.Text = "楼栋";
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

        private void shequ_yegui_Load(object sender, EventArgs e)
        {
            dataGridView1.Font = new Font("Times New Roman", 12);
        }

        private void comboYear_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboYear.Text))
            {

                comboYear.Text = "年";
            }
        }

        private void endYear_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(endYear.Text))
            {

                endYear.Text = "年";
            }
        }

        private void comboMonth_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboMonth.Text))
            {

                comboMonth.Text = "月";
            }
        }

        private void endMon_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(endMon.Text))
            {

                endMon.Text = "月";
            }
        }

        private void comboDay_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboDay.Text))
            {

                comboDay.Text = "日";
            }
        }

        private void endDay_Layout(object sender, LayoutEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(endDay.Text))
            {

                endDay.Text = "日";
            }
        }

        private void comboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBeginDayOptions();
        }

        private void endMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEndDayOptions();
        }

        private void shequ_yegui_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void id_Click(object sender, EventArgs e)
        {
            this.Close();
            (new shequ_dorm()).Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            (new shequ_stu()).Show();
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
    }
}
