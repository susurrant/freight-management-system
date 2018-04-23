namespace 运输计划管理系统
{
    partial class 已下达运输周计划列表
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_schedule = new System.Windows.Forms.Button();
            this.btn_detail = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_zs = new System.Windows.Forms.ComboBox();
            this.cb_month = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_year = new System.Windows.Forms.ComboBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.cb_company = new System.Windows.Forms.ComboBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(491, 293);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 25;
            this.btn_exit.Text = "退出";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.NO,
            this.company,
            this.startTime,
            this.endTime,
            this.amount,
            this.type,
            this.ID});
            this.dataGridView1.Location = new System.Drawing.Point(12, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 166);
            this.dataGridView1.TabIndex = 24;
            // 
            // check
            // 
            this.check.HeaderText = "";
            this.check.Name = "check";
            this.check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.check.Width = 30;
            // 
            // NO
            // 
            this.NO.HeaderText = "序号";
            this.NO.Name = "NO";
            this.NO.Width = 40;
            // 
            // company
            // 
            this.company.HeaderText = "区域公司";
            this.company.Name = "company";
            // 
            // startTime
            // 
            this.startTime.HeaderText = "开始日期";
            this.startTime.Name = "startTime";
            this.startTime.Width = 80;
            // 
            // endTime
            // 
            this.endTime.HeaderText = "结束日期";
            this.endTime.Name = "endTime";
            this.endTime.Width = 80;
            // 
            // amount
            // 
            this.amount.HeaderText = "计划量/吨";
            this.amount.Name = "amount";
            // 
            // type
            // 
            this.type.HeaderText = "计划类型";
            this.type.Name = "type";
            this.type.Width = 80;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // btn_schedule
            // 
            this.btn_schedule.Location = new System.Drawing.Point(292, 293);
            this.btn_schedule.Name = "btn_schedule";
            this.btn_schedule.Size = new System.Drawing.Size(75, 23);
            this.btn_schedule.TabIndex = 23;
            this.btn_schedule.Text = "调度令";
            this.btn_schedule.UseVisualStyleBackColor = true;
            this.btn_schedule.Click += new System.EventHandler(this.btn_schedule_Click);
            // 
            // btn_detail
            // 
            this.btn_detail.Location = new System.Drawing.Point(185, 293);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Size = new System.Drawing.Size(75, 23);
            this.btn_detail.TabIndex = 22;
            this.btn_detail.Text = "详细信息";
            this.btn_detail.UseVisualStyleBackColor = true;
            this.btn_detail.Click += new System.EventHandler(this.btn_detail_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "运输月计划列表";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cb_zs);
            this.groupBox1.Controls.Add(this.cb_month);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb_year);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.cb_company);
            this.groupBox1.Controls.Add(this.cb_type);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 86);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "运输年计划查询";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(325, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "周";
            // 
            // cb_zs
            // 
            this.cb_zs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_zs.FormattingEnabled = true;
            this.cb_zs.Location = new System.Drawing.Point(269, 17);
            this.cb_zs.Name = "cb_zs";
            this.cb_zs.Size = new System.Drawing.Size(47, 21);
            this.cb_zs.TabIndex = 17;
            // 
            // cb_month
            // 
            this.cb_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_month.FormattingEnabled = true;
            this.cb_month.Location = new System.Drawing.Point(186, 17);
            this.cb_month.Name = "cb_month";
            this.cb_month.Size = new System.Drawing.Size(52, 21);
            this.cb_month.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "月";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "年";
            // 
            // cb_year
            // 
            this.cb_year.FormattingEnabled = true;
            this.cb_year.Location = new System.Drawing.Point(67, 17);
            this.cb_year.Name = "cb_year";
            this.cb_year.Size = new System.Drawing.Size(79, 21);
            this.cb_year.TabIndex = 13;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(458, 46);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(84, 33);
            this.btn_reset.TabIndex = 9;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(458, 10);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(84, 33);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "检索";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cb_company
            // 
            this.cb_company.FormattingEnabled = true;
            this.cb_company.Location = new System.Drawing.Point(67, 53);
            this.cb_company.Name = "cb_company";
            this.cb_company.Size = new System.Drawing.Size(147, 21);
            this.cb_company.TabIndex = 7;
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(292, 53);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(121, 21);
            this.cb_type.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "区域公司";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "计划类型";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "时间";
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // 已下达运输周计划列表
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 322);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_schedule);
            this.Controls.Add(this.btn_detail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "已下达运输周计划列表";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "已下达运输周计划列表";
            this.Load += new System.EventHandler(this.已下达运输周计划列表_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_schedule;
        private System.Windows.Forms.Button btn_detail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_month;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_year;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cb_company;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_zs;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}