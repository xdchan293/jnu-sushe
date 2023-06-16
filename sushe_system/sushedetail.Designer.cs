
namespace sushe_system
{
    partial class sushedetail
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
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dormlabel = new System.Windows.Forms.Label();
            this.dormnum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1082, 365);
            this.dataGridView1.TabIndex = 0;
            // 
            // dormlabel
            // 
            this.dormlabel.AutoSize = true;
            this.dormlabel.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dormlabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.dormlabel.Location = new System.Drawing.Point(52, 63);
            this.dormlabel.Name = "dormlabel";
            this.dormlabel.Size = new System.Drawing.Size(177, 38);
            this.dormlabel.TabIndex = 6;
            this.dormlabel.Text = "zhanwei1";
            // 
            // dormnum
            // 
            this.dormnum.AutoSize = true;
            this.dormnum.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dormnum.ForeColor = System.Drawing.Color.SeaGreen;
            this.dormnum.Location = new System.Drawing.Point(754, 63);
            this.dormnum.Name = "dormnum";
            this.dormnum.Size = new System.Drawing.Size(177, 38);
            this.dormnum.TabIndex = 7;
            this.dormnum.Text = "zhanwei1";
            // 
            // sushedetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 551);
            this.Controls.Add(this.dormnum);
            this.Controls.Add(this.dormlabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "sushedetail";
            this.Text = "sushedetail";
            this.Load += new System.EventHandler(this.sushedetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label dormlabel;
        private System.Windows.Forms.Label dormnum;
    }
}