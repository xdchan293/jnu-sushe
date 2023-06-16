
namespace sushe_system
{
    partial class inner
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
            this.welcome = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.fix = new System.Windows.Forms.Label();
            this.suguan_logon = new System.Windows.Forms.Label();
            this.logon_shequ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.welcome.ForeColor = System.Drawing.Color.SeaGreen;
            this.welcome.Location = new System.Drawing.Point(125, 58);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(719, 38);
            this.welcome.TabIndex = 5;
            this.welcome.Text = "欢迎来到宿舍系统，点击下列选项以继续";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login.ForeColor = System.Drawing.Color.SeaGreen;
            this.login.Location = new System.Drawing.Point(167, 217);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(310, 38);
            this.login.TabIndex = 6;
            this.login.Text = "宿管/管理员登录";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // fix
            // 
            this.fix.AutoSize = true;
            this.fix.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fix.ForeColor = System.Drawing.Color.SeaGreen;
            this.fix.Location = new System.Drawing.Point(167, 321);
            this.fix.Name = "fix";
            this.fix.Size = new System.Drawing.Size(173, 38);
            this.fix.TabIndex = 7;
            this.fix.Text = "学生报修";
            this.fix.Click += new System.EventHandler(this.fix_Click);
            // 
            // suguan_logon
            // 
            this.suguan_logon.AutoSize = true;
            this.suguan_logon.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.suguan_logon.ForeColor = System.Drawing.Color.SeaGreen;
            this.suguan_logon.Location = new System.Drawing.Point(546, 217);
            this.suguan_logon.Name = "suguan_logon";
            this.suguan_logon.Size = new System.Drawing.Size(173, 38);
            this.suguan_logon.TabIndex = 8;
            this.suguan_logon.Text = "宿管注册";
            this.suguan_logon.Click += new System.EventHandler(this.suguan_logon_Click);
            // 
            // logon_shequ
            // 
            this.logon_shequ.AutoSize = true;
            this.logon_shequ.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logon_shequ.ForeColor = System.Drawing.Color.SeaGreen;
            this.logon_shequ.Location = new System.Drawing.Point(546, 321);
            this.logon_shequ.Name = "logon_shequ";
            this.logon_shequ.Size = new System.Drawing.Size(212, 38);
            this.logon_shequ.TabIndex = 9;
            this.logon_shequ.Text = "管理员注册";
            this.logon_shequ.Click += new System.EventHandler(this.logon_shequ_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(717, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "退出";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 558);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logon_shequ);
            this.Controls.Add(this.suguan_logon);
            this.Controls.Add(this.fix);
            this.Controls.Add(this.login);
            this.Controls.Add(this.welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "inner";
            this.Text = "hello hello";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label fix;
        private System.Windows.Forms.Label suguan_logon;
        private System.Windows.Forms.Label logon_shequ;
        private System.Windows.Forms.Label label1;
    }
}