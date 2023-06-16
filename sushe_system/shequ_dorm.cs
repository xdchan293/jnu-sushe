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
    
    public partial class shequ_dorm : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;user id=root;password=123456;database=sushe_system;";
        private bool searching = false;
        private DataTable dataTable;
        private bool hasbtn = false;
        public shequ_dorm()
        {
            InitializeComponent();
        }
        private void search_Click(object sender, EventArgs e)
        {
            if(searching == false)
            {
                searching = true;
                search_dorm();
                searching = false;

            }
        }

        private void search_dorm()
        {
            try
            {
                // 建立数据库连接
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    //初始查询语句
                    string sqlQuery = "SELECT * FROM dorm_detail ";

                    if (  numof_in.Text != "是否满人" || input_dormnum.Text != "宿舍号"  || input_dorm.Text != "楼栋")
                    {
                        sqlQuery += "WHERE";

                    }

                    int len = sqlQuery.Length;

                    if (input_dormnum.Text != "宿舍号")
                    {
                        if (sqlQuery.Length > len)
                        {
                            sqlQuery += "AND";
                        }

                        sqlQuery += "  dorm_num LIKE '%" + input_dormnum.Text + "%'";
                    }

                    if (numof_in.Text != "是否满人")
                    {
                        if (sqlQuery.Length > len)
                        {
                            sqlQuery += "AND";
                        }
                        if (numof_in.Text == "是")
                        {
                           
                            sqlQuery += "  person_num = '" + 5 + "'";
                        }else
                        {
                            sqlQuery += "  person_num < '" + 5 + "'";
                        }
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

        private void set_col()
        {
            dataGridView1.Columns["dorm_num"].HeaderText = "宿舍号";
            dataGridView1.Columns["dorm"].HeaderText = "楼栋";
            dataGridView1.Columns["person_num"].HeaderText = "人数";
            dataGridView1.Columns["dorm_id"].HeaderText = "宿舍id";
            if (hasbtn == false)
            {
                // 创建第一个按钮列
                DataGridViewButtonColumn buttonColumn1 = new DataGridViewButtonColumn();
                buttonColumn1.Name = "tiaosu";
                buttonColumn1.HeaderText = "操作1";
                buttonColumn1.Text = "查询";
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
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // 检查点击的单元格是否属于按钮列
                if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    // 获取点击行的数据
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    string dorm_num = row.Cells["dorm_num"].Value.ToString(); // 根据列名获取值
                    string dorm = row.Cells["dorm"].Value.ToString();
                    //打开详情窗体
                    (new sushedetail(dorm, dorm_num)).Show();

                }
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

        private void numof_in_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numof_in.Text))
            {

                numof_in.Text = "是否满人";
            }
        }

        private void shequ_dorm_Load(object sender, EventArgs e)
        {
            dataGridView1.Font = new Font("Times New Roman", 12);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            (new shequ_stu()).Show();
        }

        private void id_Click(object sender, EventArgs e)
        {
            this.Close();
            (new shequ_yegui()).Show();
        }

        private void shequ_dorm_FormClosed(object sender, FormClosedEventArgs e)
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
    }
}
