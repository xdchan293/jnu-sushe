
namespace sushe_system
{
    partial class fixcheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fixcheck));
            this.input_dormnum = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.fix_reason = new System.Windows.Forms.ComboBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.comboMonth = new System.Windows.Forms.ComboBox();
            this.comboDay = new System.Windows.Forms.ComboBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.endDay = new System.Windows.Forms.ComboBox();
            this.endMon = new System.Windows.Forms.ComboBox();
            this.endYear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loudong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // input_dormnum
            // 
            this.input_dormnum.Font = new System.Drawing.Font("华文中宋", 15.2F);
            this.input_dormnum.Location = new System.Drawing.Point(244, 172);
            this.input_dormnum.Name = "input_dormnum";
            this.input_dormnum.Size = new System.Drawing.Size(184, 41);
            this.input_dormnum.TabIndex = 51;
            this.input_dormnum.Text = "宿舍号";
            this.input_dormnum.Click += new System.EventHandler(this.input_dormnum_Click);
            this.input_dormnum.Leave += new System.EventHandler(this.input_dormnum_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(197, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1314, 431);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
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
            this.groupBox1.Location = new System.Drawing.Point(1, 143);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(195, 711);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(24, 453);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 55);
            this.button2.TabIndex = 68;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(24, 536);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 55);
            this.button1.TabIndex = 66;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(6, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "报修查看";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "学生查询";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.BackColor = System.Drawing.Color.AliceBlue;
            this.id.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold);
            this.id.ForeColor = System.Drawing.Color.SeaGreen;
            this.id.Location = new System.Drawing.Point(6, 233);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(176, 44);
            this.id.TabIndex = 2;
            this.id.Text = "夜归登记";
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.search.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.search.ForeColor = System.Drawing.Color.Snow;
            this.search.Location = new System.Drawing.Point(1352, 193);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(141, 55);
            this.search.TabIndex = 53;
            this.search.Text = "查询";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // fix_reason
            // 
            this.fix_reason.Font = new System.Drawing.Font("华文中宋", 16.2F);
            this.fix_reason.FormattingEnabled = true;
            this.fix_reason.Items.AddRange(new object[] {
            "空调",
            "天花板",
            "水管水龙头",
            "床",
            "书桌",
            "衣柜"});
            this.fix_reason.Location = new System.Drawing.Point(473, 174);
            this.fix_reason.Name = "fix_reason";
            this.fix_reason.Size = new System.Drawing.Size(158, 39);
            this.fix_reason.TabIndex = 54;
            this.fix_reason.Text = "报修理由";
            this.fix_reason.Leave += new System.EventHandler(this.fix_reason_Leave);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // comboYear
            // 
            this.comboYear.Font = new System.Drawing.Font("华文中宋", 16.2F);
            this.comboYear.FormattingEnabled = true;
            this.comboYear.Location = new System.Drawing.Point(242, 231);
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(97, 39);
            this.comboYear.TabIndex = 55;
            this.comboYear.Text = "年";
            this.comboYear.SelectedIndexChanged += new System.EventHandler(this.comboYear_SelectedIndexChanged);
            this.comboYear.Leave += new System.EventHandler(this.comboYear_Leave);
            // 
            // comboMonth
            // 
            this.comboMonth.Font = new System.Drawing.Font("华文中宋", 16.2F);
            this.comboMonth.FormattingEnabled = true;
            this.comboMonth.Location = new System.Drawing.Point(380, 231);
            this.comboMonth.Name = "comboMonth";
            this.comboMonth.Size = new System.Drawing.Size(97, 39);
            this.comboMonth.TabIndex = 56;
            this.comboMonth.Text = "月";
            this.comboMonth.SelectedIndexChanged += new System.EventHandler(this.comboMonth_SelectedIndexChanged);
            this.comboMonth.Leave += new System.EventHandler(this.comboMonth_Leave);
            // 
            // comboDay
            // 
            this.comboDay.Font = new System.Drawing.Font("华文中宋", 16.2F);
            this.comboDay.FormattingEnabled = true;
            this.comboDay.Location = new System.Drawing.Point(516, 231);
            this.comboDay.Name = "comboDay";
            this.comboDay.Size = new System.Drawing.Size(97, 39);
            this.comboDay.TabIndex = 57;
            this.comboDay.Text = "日";
            this.comboDay.Leave += new System.EventHandler(this.comboDay_Leave);
            // 
            // comboStatus
            // 
            this.comboStatus.Font = new System.Drawing.Font("华文中宋", 16.2F);
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "已处理",
            "未处理"});
            this.comboStatus.Location = new System.Drawing.Point(705, 174);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(115, 39);
            this.comboStatus.TabIndex = 58;
            this.comboStatus.Text = "情况";
            this.comboStatus.Leave += new System.EventHandler(this.comboStatus_Leave);
            // 
            // endDay
            // 
            this.endDay.Font = new System.Drawing.Font("华文中宋", 16.2F);
            this.endDay.FormattingEnabled = true;
            this.endDay.Location = new System.Drawing.Point(997, 231);
            this.endDay.Name = "endDay";
            this.endDay.Size = new System.Drawing.Size(97, 39);
            this.endDay.TabIndex = 84;
            this.endDay.Text = "日";
            this.endDay.SelectedIndexChanged += new System.EventHandler(this.endDay_SelectedIndexChanged);
            this.endDay.Leave += new System.EventHandler(this.endDay_Leave);
            // 
            // endMon
            // 
            this.endMon.Font = new System.Drawing.Font("华文中宋", 16.2F);
            this.endMon.FormattingEnabled = true;
            this.endMon.Location = new System.Drawing.Point(861, 231);
            this.endMon.Name = "endMon";
            this.endMon.Size = new System.Drawing.Size(97, 39);
            this.endMon.TabIndex = 83;
            this.endMon.Text = "月";
            this.endMon.SelectedIndexChanged += new System.EventHandler(this.endMon_SelectedIndexChanged);
            this.endMon.Leave += new System.EventHandler(this.endMon_Leave);
            // 
            // endYear
            // 
            this.endYear.Font = new System.Drawing.Font("华文中宋", 16.2F);
            this.endYear.FormattingEnabled = true;
            this.endYear.Location = new System.Drawing.Point(716, 231);
            this.endYear.Name = "endYear";
            this.endYear.Size = new System.Drawing.Size(104, 39);
            this.endYear.TabIndex = 82;
            this.endYear.Text = "年";
            this.endYear.Leave += new System.EventHandler(this.endYear_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(637, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 81;
            this.label3.Text = "——";
            // 
            // loudong
            // 
            this.loudong.AutoSize = true;
            this.loudong.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loudong.ForeColor = System.Drawing.Color.SeaGreen;
            this.loudong.Location = new System.Drawing.Point(1042, 52);
            this.loudong.Name = "loudong";
            this.loudong.Size = new System.Drawing.Size(95, 38);
            this.loudong.TabIndex = 85;
            this.loudong.Text = "退出";
            // 
            // fixcheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.loudong);
            this.Controls.Add(this.endDay);
            this.Controls.Add(this.endMon);
            this.Controls.Add(this.endYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.comboDay);
            this.Controls.Add(this.comboMonth);
            this.Controls.Add(this.comboYear);
            this.Controls.Add(this.fix_reason);
            this.Controls.Add(this.search);
            this.Controls.Add(this.input_dormnum);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "fixcheck";
            this.Text = "fixcheck";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fixcheck_FormClosed);
            this.Load += new System.EventHandler(this.fixcheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_dormnum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox fix_reason;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.ComboBox comboYear;
        private System.Windows.Forms.ComboBox comboMonth;
        private System.Windows.Forms.ComboBox comboDay;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.ComboBox endDay;
        private System.Windows.Forms.ComboBox endMon;
        private System.Windows.Forms.ComboBox endYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label loudong;
        private System.Windows.Forms.Button button2;
    }
}