
namespace sushe_system
{
    partial class logon
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
            this.id = new System.Windows.Forms.Label();
            this.input_id = new System.Windows.Forms.TextBox();
            this.input_name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.input_phone = new System.Windows.Forms.TextBox();
            this.input_password = new System.Windows.Forms.TextBox();
            this.input_dorm = new System.Windows.Forms.ComboBox();
            this.dorm = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.logon_btn = new System.Windows.Forms.Button();
            this.sex = new System.Windows.Forms.Label();
            this.input_sex = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold);
            this.id.ForeColor = System.Drawing.Color.SeaGreen;
            this.id.Location = new System.Drawing.Point(184, 125);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(98, 44);
            this.id.TabIndex = 0;
            this.id.Text = "工号";
            this.id.Click += new System.EventHandler(this.label1_Click);
            // 
            // input_id
            // 
            this.input_id.Font = new System.Drawing.Font("华文中宋", 16.2F);
            this.input_id.Location = new System.Drawing.Point(459, 124);
            this.input_id.Name = "input_id";
            this.input_id.Size = new System.Drawing.Size(262, 43);
            this.input_id.TabIndex = 1;
            // 
            // input_name
            // 
            this.input_name.Font = new System.Drawing.Font("华文中宋", 16.2F);
            this.input_name.Location = new System.Drawing.Point(459, 211);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(262, 43);
            this.input_name.TabIndex = 2;
            this.input_name.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.ForeColor = System.Drawing.Color.SeaGreen;
            this.password.Location = new System.Drawing.Point(184, 372);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(98, 44);
            this.password.TabIndex = 3;
            this.password.Text = "密码";
            this.password.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.password.Click += new System.EventHandler(this.label2_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.ForeColor = System.Drawing.Color.SeaGreen;
            this.name.Location = new System.Drawing.Point(184, 212);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(98, 44);
            this.name.TabIndex = 4;
            this.name.Text = "姓名";
            this.name.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.name.Click += new System.EventHandler(this.label3_Click);
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phone.ForeColor = System.Drawing.Color.SeaGreen;
            this.phone.Location = new System.Drawing.Point(184, 290);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(98, 44);
            this.phone.TabIndex = 5;
            this.phone.Text = "电话";
            this.phone.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.phone.Click += new System.EventHandler(this.phone_Click);
            // 
            // input_phone
            // 
            this.input_phone.Font = new System.Drawing.Font("华文中宋", 16.2F);
            this.input_phone.Location = new System.Drawing.Point(459, 289);
            this.input_phone.Name = "input_phone";
            this.input_phone.Size = new System.Drawing.Size(262, 43);
            this.input_phone.TabIndex = 6;
            // 
            // input_password
            // 
            this.input_password.Font = new System.Drawing.Font("华文中宋", 16.2F);
            this.input_password.Location = new System.Drawing.Point(459, 378);
            this.input_password.Name = "input_password";
            this.input_password.Size = new System.Drawing.Size(262, 43);
            this.input_password.TabIndex = 7;
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
            this.input_dorm.Location = new System.Drawing.Point(457, 534);
            this.input_dorm.Name = "input_dorm";
            this.input_dorm.Size = new System.Drawing.Size(179, 39);
            this.input_dorm.TabIndex = 8;
            // 
            // dorm
            // 
            this.dorm.AutoSize = true;
            this.dorm.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dorm.ForeColor = System.Drawing.Color.SeaGreen;
            this.dorm.Location = new System.Drawing.Point(106, 528);
            this.dorm.Name = "dorm";
            this.dorm.Size = new System.Drawing.Size(176, 44);
            this.dorm.TabIndex = 9;
            this.dorm.Text = "负责宿舍";
            this.dorm.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.dorm.Click += new System.EventHandler(this.label5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button3.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Location = new System.Drawing.Point(41, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 49);
            this.button3.TabIndex = 11;
            this.button3.Text = "返回";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // logon_btn
            // 
            this.logon_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.logon_btn.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logon_btn.ForeColor = System.Drawing.Color.Snow;
            this.logon_btn.Location = new System.Drawing.Point(810, 588);
            this.logon_btn.Name = "logon_btn";
            this.logon_btn.Size = new System.Drawing.Size(142, 55);
            this.logon_btn.TabIndex = 12;
            this.logon_btn.Text = "注册";
            this.logon_btn.UseVisualStyleBackColor = false;
            this.logon_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sex.ForeColor = System.Drawing.Color.SeaGreen;
            this.sex.Location = new System.Drawing.Point(184, 453);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(98, 44);
            this.sex.TabIndex = 13;
            this.sex.Text = "性别";
            this.sex.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.sex.Click += new System.EventHandler(this.sex_Click);
            // 
            // input_sex
            // 
            this.input_sex.Font = new System.Drawing.Font("华文中宋", 16.2F);
            this.input_sex.FormattingEnabled = true;
            this.input_sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.input_sex.Location = new System.Drawing.Point(457, 453);
            this.input_sex.Name = "input_sex";
            this.input_sex.Size = new System.Drawing.Size(179, 39);
            this.input_sex.TabIndex = 14;
            // 
            // logon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 676);
            this.Controls.Add(this.input_sex);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.logon_btn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dorm);
            this.Controls.Add(this.input_dorm);
            this.Controls.Add(this.input_password);
            this.Controls.Add(this.input_phone);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.name);
            this.Controls.Add(this.password);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.input_id);
            this.Controls.Add(this.id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "logon";
            this.Text = "宿管注册";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.logon_FormClosed);
            this.Load += new System.EventHandler(this.logon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox input_id;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox input_phone;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.ComboBox input_dorm;
        private System.Windows.Forms.Label dorm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button logon_btn;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.ComboBox input_sex;
    }
}