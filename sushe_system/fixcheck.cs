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
    public partial class fixcheck : Form
    {

        private MySqlConnection connection;
        private string connectionString = "server=localhost;user id=root;password=123456;database=sushe_system;";
        private bool searching = false;
        private bool hasbtn = false;

        private DataTable dataTable;
        public fixcheck()
        {
            InitializeComponent();

            //设置下拉框的默认文本
            //
            // // 填充年份选项
            int currentYear = DateTime.Now.Year;
            for (int year = currentYear - 3; year <= currentYear ; year++)
            {
                comboYear.Items.Add(year.ToString());
                endYear.Items.Add(year.ToString());
            }

            // 填充月份选项
            for (int month = 1; month <= 12; month++)
            {
                comboMonth.Items.Add(month.ToString("00"));
                endMon.Items.Add(month.ToString());
            }

            // 设置默认选中的日期
            //comboYear.SelectedItem = currentYear.ToString();
            //comboMonth.SelectedItem = DateTime.Now.Month.ToString("00");

        }

        private void UpdateDayOptions()
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
            
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            (new suguan_Main()).Show();
        }

        private void id_Click(object sender, EventArgs e)
        {
            this.Close();
            (new yegui()).Show();
        }

        private void fixcheck_Load(object sender, EventArgs e)
        {
            loudong.Text = "当前管理楼栋：" + UserInfo.manage_dorm;
            dataGridView1.Font = new Font("Times New Roman", 12);
        }

        private void comboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //UpdateDayOptions();
        }

        private void comboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDayOptions();
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

        private void search_Click(object sender, EventArgs e)
        {
            if (searching == false)
            {
                searching = true;
                searchinfo();
                searching = false;
            }
        }

        private void searchinfo()
        {
            try
            {
                // 建立数据库连接
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    //初始查询语句
                    string sqlQuery = "SELECT * FROM baoxiu WHERE dorm = " + "'" + UserInfo.manage_dorm + "'";

                    

                    if (input_dormnum.Text != "宿舍号")
                    {
                        sqlQuery += " AND dorm_num LIKE '%" + input_dormnum.Text + "%'";
                    }



                    if (comboDay.Text != "日")
                    {
                        
                        string begintime = comboYear.Text + "-" + comboMonth.Text + "-" + comboDay.Text;
                        if (endDay.Text != "日")
                        {
                            string endtime = endYear.Text + "-" + endMon.Text + "-" + endDay.Text;
                            sqlQuery += " AND event_time BETWEEN " + "'" + begintime + "'" + " AND " + "'" + endtime + "'";
                        }
                        else
                        {
                            sqlQuery += " AND event_time >= " + "'" + begintime + "' " + " AND yegui_time<= NOW()";
                        }

                    }
                    else if (comboYear.Text != "年")
                    {
                        //"%'"
                        
                        sqlQuery += "AND event_time LIKE '%" + comboYear.Text;
                        if (comboMonth.Text != "月")
                        {
                            sqlQuery += "-" + comboMonth.Text;
                        }
                        sqlQuery += "%'";
                    }
                    else if (comboYear.Text == "年" && endYear.Text != "年")
                    {
                        //"%'"
                        
                        sqlQuery += "AND event_time LIKE '%" + endYear.Text;
                        if (endMon.Text != "月")
                        {
                            sqlQuery += "-" + endMon.Text;
                        }
                        sqlQuery += "%'";
                    }

                    if (fix_reason.Text != "报修理由")   
                    {
                        sqlQuery += " AND event_type = " + "'" + fix_reason.Text + "'";
                    }


                    if (comboStatus.Text != "情况")
                    {
                        sqlQuery += " AND event_status = " + "'" + comboStatus.Text + "'";
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
            dataGridView1.Columns["dorm_num"].HeaderText = "宿舍号";
            dataGridView1.Columns["dorm"].HeaderText = "楼栋";
            dataGridView1.Columns["event_type"].HeaderText = "报修类型";
            dataGridView1.Columns["event_detail"].HeaderText = "报修备注";
            dataGridView1.Columns["event_status"].HeaderText = "受理情况";
            dataGridView1.Columns["event_time"].HeaderText = "报修时间";
            dataGridView1.Columns["event_id"].HeaderText = "事件id";

            // 创建按钮列
            if(hasbtn == false)
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = "操作";
                buttonColumn.Text = "处理";
                buttonColumn.UseColumnTextForButtonValue = true;

                // 将按钮列添加到 DataGridView
                dataGridView1.Columns.Add(buttonColumn);

                hasbtn = true;
            }
        }

        private void comboYear_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(comboYear.Text))
            {
                comboYear.Text = "年";
            }
        }

        private void comboMonth_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboMonth.Text))
            {
                comboMonth.Text = "月";
            }
        }

        private void comboDay_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboDay.Text))
            {
                comboDay.Text = "日";
            }
        }

        private void comboStatus_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboStatus.Text))
            {
                comboStatus.Text = "情况";
            }
        }

        private void fix_reason_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fix_reason.Text))
            {
                fix_reason.Text = "报修理由";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // 检查点击的单元格是否属于按钮列
                if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    // 处理按钮点击事件

                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    /*
                      dataGridView1.Columns["dorm_num"].HeaderText = "宿舍号";
            dataGridView1.Columns["dorm"].HeaderText = "楼栋";
            dataGridView1.Columns["event_type"].HeaderText = "报修类型";
            dataGridView1.Columns["event_detail"].HeaderText = "报修备注";
            dataGridView1.Columns["event_status"].HeaderText = "受理情况";
            dataGridView1.Columns["event_time"].HeaderText = "报修时间";
                     */
                    string event_id = row.Cells["event_id"].Value.ToString();
                    

                    // 这

                    try
                    {
                        // 建立数据库连接
                        using (connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();

                            //
                            string insert_event = "UPDATE  baoxiu SET event_status = @event_status  where event_id = @event_id";
                            MySqlCommand add_command = new MySqlCommand(insert_event, connection);
                            add_command.Parameters.AddWithValue("@event_status", "已处理");
                            add_command.Parameters.AddWithValue("@event_id", event_id);
                            
                            add_command.ExecuteNonQuery();

                            MessageBox.Show("修改成功！");

                            searchinfo();
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("提交时出现错误：" + ex.Message);
                    }
                }
            }
        }

        private void endYear_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(endYear.Text))
            {

                endYear.Text = "年";
            }
        }

        private void endMon_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(endMon.Text))
            {

                endMon.Text = "月";
            }
        }

        private void endDay_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(endDay.Text))
            {

                endDay.Text = "日";
            }
        }

        private void fixcheck_FormClosed(object sender, FormClosedEventArgs e)
        {
           
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

        private void endDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void endMon_SelectedIndexChanged(object sender, EventArgs e)
        {
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
    }
}
