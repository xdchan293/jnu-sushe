
namespace sushe_system
{
    partial class logon_shequ
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
            this.input_sex = new System.Windows.Forms.ComboBox();
            this.sex = new System.Windows.Forms.Label();
            this.logon = new System.Windows.Forms.Button();
            this.input_password = new System.Windows.Forms.TextBox();
            this.input_phone = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.input_name = new System.Windows.Forms.TextBox();
            this.input_id = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_sex
            // 
            this.input_sex.Font = new System.Drawing.Font("华文中宋", 16.2F);
            this.input_sex.FormattingEnabled = true;
            this.input_sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.input_sex.Location = new System.Drawing.Point(488, 435);
            this.input_sex.Name = "input_sex";
            this.input_sex.Size = new System.Drawing.Size(179, 39);
            this.input_sex.TabIndex = 27;
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sex.ForeColor = System.Drawing.Color.SeaGreen;
            this.sex.Location = new System.Drawing.Point(213, 430);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(98, 44);
            this.sex.TabIndex = 26;
            this.sex.Text = "性别";
            this.sex.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // logon
            // 
            this.logon.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.logon.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logon.ForeColor = System.Drawing.Color.Snow;
            this.logon.Location = new System.Drawing.Point(805, 495);
            this.logon.Name = "logon";
            this.logon.Size = new System.Drawing.Size(142, 55);
            this.logon.TabIndex = 25;
            this.logon.Text = "注册";
            this.logon.UseVisualStyleBackColor = false;
            this.logon.Click += new System.EventHandler(this.logon_Click);
            // 
            // input_password
            // 
            this.input_password.Font = new System.Drawing.Font("华文中宋", 16.2F);
            this.input_password.Location = new System.Drawing.Point(488, 355);
            this.input_password.Name = "input_password";
            this.input_password.Size = new System.Drawing.Size(262, 43);
            this.input_password.TabIndex = 22;
            // 
            // input_phone
            // 
            this.input_phone.Font = new System.Drawing.Font("华文中宋", 16.2F);
            this.input_phone.Location = new System.Drawing.Point(488, 266);
            this.input_phone.Name = "input_phone";
            this.input_phone.Size = new System.Drawing.Size(262, 43);
            this.input_phone.TabIndex = 21;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phone.ForeColor = System.Drawing.Color.SeaGreen;
            this.phone.Location = new System.Drawing.Point(213, 267);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(98, 44);
            this.phone.TabIndex = 20;
            this.phone.Text = "电话";
            this.phone.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.ForeColor = System.Drawing.Color.SeaGreen;
            this.name.Location = new System.Drawing.Point(213, 189);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(98, 44);
            this.name.TabIndex = 19;
            this.name.Text = "姓名";
            this.name.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.ForeColor = System.Drawing.Color.SeaGreen;
            this.password.Location = new System.Drawing.Point(213, 349);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(98, 44);
            this.password.TabIndex = 18;
            this.password.Text = "密码";
            this.password.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // input_name
            // 
            this.input_name.Font = new System.Drawing.Font("华文中宋", 16.2F);
            this.input_name.Location = new System.Drawing.Point(488, 188);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(262, 43);
            this.input_name.TabIndex = 17;
            // 
            // input_id
            // 
            this.input_id.Font = new System.Drawing.Font("华文中宋", 16.2F);
            this.input_id.Location = new System.Drawing.Point(488, 101);
            this.input_id.Name = "input_id";
            this.input_id.Size = new System.Drawing.Size(262, 43);
            this.input_id.TabIndex = 16;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold);
            this.id.ForeColor = System.Drawing.Color.SeaGreen;
            this.id.Location = new System.Drawing.Point(213, 102);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(98, 44);
            this.id.TabIndex = 15;
            this.id.Text = "工号";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button3.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Location = new System.Drawing.Point(41, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 49);
            this.button3.TabIndex = 28;
            this.button3.Text = "返回";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // logon_shequ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 607);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.input_sex);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.logon);
            this.Controls.Add(this.input_password);
            this.Controls.Add(this.input_phone);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.name);
            this.Controls.Add(this.password);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.input_id);
            this.Controls.Add(this.id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "logon_shequ";
            this.Text = "logon_shequ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.logon_shequ_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox input_sex;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.Button logon;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.TextBox input_phone;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.TextBox input_id;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Button button3;
    }
}