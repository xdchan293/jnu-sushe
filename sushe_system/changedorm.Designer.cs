
namespace sushe_system
{
    partial class changedorm
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
            this.input_dormnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sure = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_dorm
            // 
            this.input_dorm.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.input_dorm.Location = new System.Drawing.Point(85, 100);
            this.input_dorm.Name = "input_dorm";
            this.input_dorm.Size = new System.Drawing.Size(134, 28);
            this.input_dorm.TabIndex = 54;
            this.input_dorm.Text = "楼栋";
            // 
            // input_dormnum
            // 
            this.input_dormnum.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input_dormnum.Location = new System.Drawing.Point(85, 148);
            this.input_dormnum.Name = "input_dormnum";
            this.input_dormnum.Size = new System.Drawing.Size(151, 31);
            this.input_dormnum.TabIndex = 55;
            this.input_dormnum.Text = "宿舍号";
            this.input_dormnum.Click += new System.EventHandler(this.input_dormnum_Click);
            this.input_dormnum.Leave += new System.EventHandler(this.input_dormnum_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(55, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 19);
            this.label1.TabIndex = 56;
            this.label1.Text = "请输入将要更换的具体宿舍信息";
            // 
            // sure
            // 
            this.sure.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.sure.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sure.ForeColor = System.Drawing.Color.Snow;
            this.sure.Location = new System.Drawing.Point(349, 194);
            this.sure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(75, 43);
            this.sure.TabIndex = 57;
            this.sure.Text = "确认";
            this.sure.UseVisualStyleBackColor = false;
            this.sure.Click += new System.EventHandler(this.sure_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.cancel.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.ForeColor = System.Drawing.Color.Snow;
            this.cancel.Location = new System.Drawing.Point(257, 194);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 43);
            this.cancel.TabIndex = 58;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // changedorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 248);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_dormnum);
            this.Controls.Add(this.input_dorm);
            this.Name = "changedorm";
            this.Text = "调宿";
            this.Load += new System.EventHandler(this.changedorm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox input_dorm;
        private System.Windows.Forms.TextBox input_dormnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sure;
        private System.Windows.Forms.Button cancel;
    }
}