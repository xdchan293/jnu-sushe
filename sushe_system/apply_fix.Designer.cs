
namespace sushe_system
{
    partial class apply_fix
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
            this.input_dorm = new System.Windows.Forms.ComboBox();
            this.dorm = new System.Windows.Forms.Label();
            this.dorm_num = new System.Windows.Forms.Label();
            this.input_dorm_num = new System.Windows.Forms.TextBox();
            this.fix_reason = new System.Windows.Forms.ComboBox();
            this.reson = new System.Windows.Forms.Label();
            this.detail = new System.Windows.Forms.Label();
            this.input_detail = new System.Windows.Forms.RichTextBox();
            this.submit = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.input_dorm.Location = new System.Drawing.Point(539, 191);
            this.input_dorm.Name = "input_dorm";
            this.input_dorm.Size = new System.Drawing.Size(179, 39);
            this.input_dorm.TabIndex = 9;
            // 
            // dorm
            // 
            this.dorm.AutoSize = true;
            this.dorm.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dorm.ForeColor = System.Drawing.Color.SeaGreen;
            this.dorm.Location = new System.Drawing.Point(198, 191);
            this.dorm.Name = "dorm";
            this.dorm.Size = new System.Drawing.Size(176, 44);
            this.dorm.TabIndex = 10;
            this.dorm.Text = "宿舍楼栋";
            this.dorm.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dorm_num
            // 
            this.dorm_num.AutoSize = true;
            this.dorm_num.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dorm_num.ForeColor = System.Drawing.Color.SeaGreen;
            this.dorm_num.Location = new System.Drawing.Point(198, 288);
            this.dorm_num.Name = "dorm_num";
            this.dorm_num.Size = new System.Drawing.Size(137, 44);
            this.dorm_num.TabIndex = 11;
            this.dorm_num.Text = "宿舍号";
            this.dorm_num.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // input_dorm_num
            // 
            this.input_dorm_num.Font = new System.Drawing.Font("华文中宋", 16.2F);
            this.input_dorm_num.Location = new System.Drawing.Point(539, 288);
            this.input_dorm_num.Name = "input_dorm_num";
            this.input_dorm_num.Size = new System.Drawing.Size(192, 43);
            this.input_dorm_num.TabIndex = 12;
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
            this.fix_reason.Location = new System.Drawing.Point(539, 109);
            this.fix_reason.Name = "fix_reason";
            this.fix_reason.Size = new System.Drawing.Size(179, 39);
            this.fix_reason.TabIndex = 13;
            // 
            // reson
            // 
            this.reson.AutoSize = true;
            this.reson.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reson.ForeColor = System.Drawing.Color.SeaGreen;
            this.reson.Location = new System.Drawing.Point(198, 101);
            this.reson.Name = "reson";
            this.reson.Size = new System.Drawing.Size(176, 44);
            this.reson.TabIndex = 14;
            this.reson.Text = "报修类型";
            this.reson.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // detail
            // 
            this.detail.AutoSize = true;
            this.detail.Font = new System.Drawing.Font("华文中宋", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.detail.ForeColor = System.Drawing.Color.SeaGreen;
            this.detail.Location = new System.Drawing.Point(198, 378);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(176, 44);
            this.detail.TabIndex = 15;
            this.detail.Text = "具体描述";
            this.detail.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // input_detail
            // 
            this.input_detail.Location = new System.Drawing.Point(539, 378);
            this.input_detail.Name = "input_detail";
            this.input_detail.Size = new System.Drawing.Size(241, 88);
            this.input_detail.TabIndex = 17;
            this.input_detail.Text = "";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.submit.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.submit.ForeColor = System.Drawing.Color.Snow;
            this.submit.Location = new System.Drawing.Point(796, 502);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(142, 55);
            this.submit.TabIndex = 18;
            this.submit.Text = "提交";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.back.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.back.ForeColor = System.Drawing.Color.Snow;
            this.back.Location = new System.Drawing.Point(34, 36);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(124, 49);
            this.back.TabIndex = 19;
            this.back.Text = "返回";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // apply_fix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 589);
            this.Controls.Add(this.back);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.input_detail);
            this.Controls.Add(this.detail);
            this.Controls.Add(this.reson);
            this.Controls.Add(this.fix_reason);
            this.Controls.Add(this.input_dorm_num);
            this.Controls.Add(this.dorm_num);
            this.Controls.Add(this.dorm);
            this.Controls.Add(this.input_dorm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "apply_fix";
            this.Text = "学生报修";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.apply_fix_FormClosed);
            this.Load += new System.EventHandler(this.apply_fix_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox input_dorm;
        private System.Windows.Forms.Label dorm;
        private System.Windows.Forms.Label dorm_num;
        private System.Windows.Forms.TextBox input_dorm_num;
        private System.Windows.Forms.ComboBox fix_reason;
        private System.Windows.Forms.Label reson;
        private System.Windows.Forms.Label detail;
        private System.Windows.Forms.RichTextBox input_detail;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button back;
    }
}