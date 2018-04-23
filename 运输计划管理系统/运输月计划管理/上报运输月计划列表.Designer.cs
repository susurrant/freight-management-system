namespace 运输计划管理系统
{
    partial class 上报运输月计划列表
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
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_approve = new System.Windows.Forms.Button();
            this.btn_transmit = new System.Windows.Forms.Button();
            this.btn_spd = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.btn_detail = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekPlan = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_month = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_year = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.cb_company = new System.Windows.Forms.ComboBox();
            this.cb_statues = new System.Windows.Forms.ComboBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(674, 377);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 30;
            this.btn_exit.Text = "退出";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(674, 106);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 29;
            this.btn_refresh.Text = "刷新";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_approve
            // 
            this.btn_approve.Location = new System.Drawing.Point(429, 377);
            this.btn_approve.Name = "btn_approve";
            this.btn_approve.Size = new System.Drawing.Size(75, 23);
            this.btn_approve.TabIndex = 28;
            this.btn_approve.Text = "审批";
            this.btn_approve.UseVisualStyleBackColor = true;
            this.btn_approve.Click += new System.EventHandler(this.btn_approve_Click);
            // 
            // btn_transmit
            // 
            this.btn_transmit.Location = new System.Drawing.Point(344, 377);
            this.btn_transmit.Name = "btn_transmit";
            this.btn_transmit.Size = new System.Drawing.Size(75, 23);
            this.btn_transmit.TabIndex = 27;
            this.btn_transmit.Text = "提交";
            this.btn_transmit.UseVisualStyleBackColor = true;
            this.btn_transmit.Click += new System.EventHandler(this.btn_transmit_Click);
            // 
            // btn_spd
            // 
            this.btn_spd.Location = new System.Drawing.Point(514, 377);
            this.btn_spd.Name = "btn_spd";
            this.btn_spd.Size = new System.Drawing.Size(75, 23);
            this.btn_spd.TabIndex = 26;
            this.btn_spd.Text = "审批单";
            this.btn_spd.UseVisualStyleBackColor = true;
            this.btn_spd.Click += new System.EventHandler(this.btn_spd_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(259, 377);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 25;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.Location = new System.Drawing.Point(174, 377);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(75, 23);
            this.btn_mod.TabIndex = 24;
            this.btn_mod.Text = "修改";
            this.btn_mod.UseVisualStyleBackColor = true;
            this.btn_mod.Click += new System.EventHandler(this.btn_mod_Click);
            // 
            // btn_detail
            // 
            this.btn_detail.Location = new System.Drawing.Point(89, 377);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Size = new System.Drawing.Size(75, 23);
            this.btn_detail.TabIndex = 23;
            this.btn_detail.Text = "详细信息";
            this.btn_detail.UseVisualStyleBackColor = true;
            this.btn_detail.Click += new System.EventHandler(this.btn_detail_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "运输月计划列表";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.no,
            this.company,
            this.startTime,
            this.endTime,
            this.planAmount,
            this.type,
            this.status,
            this.weekPlan,
            this.ID});
            this.dataGridView1.Location = new System.Drawing.Point(16, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(733, 225);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // check
            // 
            this.check.HeaderText = "";
            this.check.Name = "check";
            this.check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.check.Width = 30;
            // 
            // no
            // 
            this.no.HeaderText = "序号";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Width = 40;
            // 
            // company
            // 
            this.company.HeaderText = "区域公司";
            this.company.Name = "company";
            this.company.ReadOnly = true;
            // 
            // startTime
            // 
            this.startTime.HeaderText = "开始日期";
            this.startTime.Name = "startTime";
            this.startTime.ReadOnly = true;
            this.startTime.Width = 80;
            // 
            // endTime
            // 
            this.endTime.HeaderText = "结束日期";
            this.endTime.Name = "endTime";
            this.endTime.ReadOnly = true;
            this.endTime.Width = 80;
            // 
            // planAmount
            // 
            this.planAmount.HeaderText = "计划量/吨";
            this.planAmount.Name = "planAmount";
            this.planAmount.ReadOnly = true;
            // 
            // type
            // 
            this.type.HeaderText = "计划类型";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 80;
            // 
            // status
            // 
            this.status.HeaderText = "状态";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 80;
            // 
            // weekPlan
            // 
            this.weekPlan.HeaderText = "周计划";
            this.weekPlan.Name = "weekPlan";
            this.weekPlan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.weekPlan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_month);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb_year);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.cb_company);
            this.groupBox1.Controls.Add(this.cb_statues);
            this.groupBox1.Controls.Add(this.cb_type);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 86);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "运输月计划查询";
            // 
            // cb_month
            // 
            this.cb_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_month.FormattingEnabled = true;
            this.cb_month.Location = new System.Drawing.Point(389, 50);
            this.cb_month.Name = "cb_month";
            this.cb_month.Size = new System.Drawing.Size(52, 21);
            this.cb_month.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "月";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "年";
            // 
            // cb_year
            // 
            this.cb_year.FormattingEnabled = true;
            this.cb_year.Location = new System.Drawing.Point(302, 50);
            this.cb_year.Name = "cb_year";
            this.cb_year.Size = new System.Drawing.Size(56, 21);
            this.cb_year.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "时间";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(641, 23);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(84, 33);
            this.btn_reset.TabIndex = 9;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(528, 23);
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
            this.cb_company.Location = new System.Drawing.Point(90, 17);
            this.cb_company.Name = "cb_company";
            this.cb_company.Size = new System.Drawing.Size(147, 21);
            this.cb_company.TabIndex = 7;
            // 
            // cb_statues
            // 
            this.cb_statues.FormattingEnabled = true;
            this.cb_statues.Location = new System.Drawing.Point(90, 50);
            this.cb_statues.Name = "cb_statues";
            this.cb_statues.Size = new System.Drawing.Size(121, 21);
            this.cb_statues.TabIndex = 6;
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(302, 17);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(121, 21);
            this.cb_type.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "所在区域公司";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "状态";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "计划类型";
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // 上报运输月计划列表
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 408);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_approve);
            this.Controls.Add(this.btn_transmit);
            this.Controls.Add(this.btn_spd);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_detail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "上报运输月计划列表";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "上报运输月计划列表";
            this.Load += new System.EventHandler(this.上报运输月计划列表_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_approve;
        private System.Windows.Forms.Button btn_transmit;
        private System.Windows.Forms.Button btn_spd;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_mod;
        private System.Windows.Forms.Button btn_detail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cb_company;
        private System.Windows.Forms.ComboBox cb_statues;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_month;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn planAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewButtonColumn weekPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}