
namespace sushe_system
{
    partial class shequ_stu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shequ_stu));
            this.input_dormnum = new System.Windows.Forms.TextBox();
            this.input_name = new System.Windows.Forms.TextBox();
            this.input_id = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.input_dorm = new System.Windows.Forms.ComboBox();
            this.input_college = new System.Windows.Forms.TextBox();
            this.input_major = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // input_dormnum
            // 
            this.input_dormnum.Font = new System.Drawing.Font("华文中宋", 16.2F);
            this.input_dormnum.Location = new System.Drawing.Point(879, 147);
            this.input_dormnum.Name = "input_dormnum";
            this.input_dormnum.Size = new System.Drawing.Size(151, 43);
            this.input_dormnum.TabIndex = 51;
            this.input_dormnum.Text = "宿舍号";
            this.input_dormnum.Click += new System.EventHandler(this.input_dormnum_Click);
            this.input_dormnum.Leave += new System.EventHandler(this.input_dormnum_Leave);
            // 
            // input_name
            // 
            this.input_name.Font = new System.Drawing.Font("华文中宋", 16.2F);
            this.input_name.Location = new System.Drawing.Point(461, 143);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(170, 43);
            this.input_name.TabIndex = 50;
            this.input_name.Text = "学生姓名";
            this.input_name.Click += new System.EventHandler(this.input_name_Click);
            this.input_name.Leave += new System.EventHandler(this.input_name_Leave);
            // 
            // input_id
            // 
            this.input_id.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input_id.Location = new System.Drawing.Point(226, 143);
            this.input_id.Name = "input_id";
            this.input_id.Size = new System.Drawing.Size(190, 43);
            this.input_id.TabIndex = 49;
            this.input_id.Text = "学生学号";
            this.input_id.Click += new System.EventHandler(this.input_id_Click);
            this.input_id.Leave += new System.EventHandler(this.input_id_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(198, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1372, 431);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 181);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Location = new System.Drawing.Point(2, 143);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(195, 711);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(4, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "学生查询";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(4, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "宿舍查询";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.BackColor = System.Drawing.Color.AliceBlue;
            this.id.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold);
            this.id.ForeColor = System.Drawing.Color.SeaGreen;
            this.id.Location = new System.Drawing.Point(5, 228);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(176, 44);
            this.id.TabIndex = 2;
            this.id.Text = "夜归查询";
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.search.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.search.ForeColor = System.Drawing.Color.Snow;
            this.search.Location = new System.Drawing.Point(1381, 182);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(141, 55);
            this.search.TabIndex = 52;
            this.search.Text = "查询";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // input_dorm
            // 
            this.input_dorm.Font = new System.Drawing.Font("华文中宋", 16.2F);
            this.input_dorm.FormattingEnabled = true;
            this.input_dorm.Items.AddRange(new object[] {
            "T1",
            "T2",
            "T3",
            "T4",
            "T5",
            "T10",
            "T11",
            "T12"});
            this.input_dorm.Location = new System.Drawing.Point(675, 147);
            this.input_dorm.Name = "input_dorm";
            this.input_dorm.Size = new System.Drawing.Size(134, 39);
            this.input_dorm.TabIndex = 53;
            this.input_dorm.Text = "楼栋";
            this.input_dorm.Leave += new System.EventHandler(this.input_dorm_Leave);
            // 
            // input_college
            // 
            this.input_college.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input_college.Location = new System.Drawing.Point(226, 215);
            this.input_college.Name = "input_college";
            this.input_college.Size = new System.Drawing.Size(209, 43);
            this.input_college.TabIndex = 54;
            this.input_college.Text = "学院";
            this.input_college.Click += new System.EventHandler(this.input_college_Click);
            this.input_college.Leave += new System.EventHandler(this.input_college_Leave);
            // 
            // input_major
            // 
            this.input_major.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input_major.Location = new System.Drawing.Point(499, 215);
            this.input_major.Name = "input_major";
            this.input_major.Size = new System.Drawing.Size(190, 43);
            this.input_major.TabIndex = 55;
            this.input_major.Text = "专业";
            this.input_major.Click += new System.EventHandler(this.input_major_Click);
            this.input_major.Leave += new System.EventHandler(this.input_major_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(13, 618);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 55);
            this.button1.TabIndex = 66;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(13, 538);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 55);
            this.button2.TabIndex = 67;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // shequ_stu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.input_major);
            this.Controls.Add(this.input_college);
            this.Controls.Add(this.input_dorm);
            this.Controls.Add(this.search);
            this.Controls.Add(this.input_dormnum);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.input_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "shequ_stu";
            this.Text = "shequ_stu";
            this.Load += new System.EventHandler(this.shequ_stu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_dormnum;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.TextBox input_id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox input_dorm;
        private System.Windows.Forms.TextBox input_college;
        private System.Windows.Forms.TextBox input_major;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}