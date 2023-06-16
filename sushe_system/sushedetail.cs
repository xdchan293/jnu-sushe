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
    public partial class sushedetail : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;user id=root;password=123456;database=sushe_system;";
        private string dorm;
        private string dorm_num;
        private DataTable dataTable;
        public sushedetail(string out_dorm,string out_dorm_num)
        {
            InitializeComponent();
            dorm = out_dorm;
            dorm_num = out_dorm_num;

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
        private void sushedetail_Load(object sender, EventArgs e)
        {
            dataGridView1.Font = new Font("Times New Roman", 12);

            dormlabel.Text = "楼栋："+dorm;
            dormnum.Text = "楼栋：" + dorm_num;

            try
            {
                // 建立数据库连接
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    //初始查询语句
                    string sqlQuery = "SELECT * FROM student WHERE dorm = " + "'" + dorm + "'"+ "AND dorm_num = '" + dorm_num + "'" ;



                    

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
    }
}
