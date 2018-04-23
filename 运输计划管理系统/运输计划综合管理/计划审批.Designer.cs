namespace 运输计划管理系统
{
    partial class 计划审批
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_fj = new System.Windows.Forms.TextBox();
            this.txt_bz = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_cjr = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_hj = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fhdw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ysfs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shdw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fjdz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jhl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_zxsj = new System.Windows.Forms.TextBox();
            this.txt_cmp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_pfyj = new System.Windows.Forms.TextBox();
            this.txt_pfrq = new System.Windows.Forms.TextBox();
            this.txt_pfr = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rb_no = new System.Windows.Forms.RadioButton();
            this.rb_yes = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_detail = new System.Windows.Forms.Label();
            this.btn_approve = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(371, 617);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 30);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "返回";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_fj);
            this.groupBox2.Controls.Add(this.txt_bz);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txt_time);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_cjr);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(14, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 147);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "附加信息";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "已添加附件";
            // 
            // txt_fj
            // 
            this.txt_fj.Location = new System.Drawing.Point(139, 107);
            this.txt_fj.Name = "txt_fj";
            this.txt_fj.ReadOnly = true;
            this.txt_fj.Size = new System.Drawing.Size(438, 20);
            this.txt_fj.TabIndex = 7;
            // 
            // txt_bz
            // 
            this.txt_bz.Location = new System.Drawing.Point(139, 47);
            this.txt_bz.Multiline = true;
            this.txt_bz.Name = "txt_bz";
            this.txt_bz.ReadOnly = true;
            this.txt_bz.Size = new System.Drawing.Size(438, 58);
            this.txt_bz.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(69, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "备注";
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(455, 17);
            this.txt_time.Name = "txt_time";
            this.txt_time.ReadOnly = true;
            this.txt_time.Size = new System.Drawing.Size(122, 20);
            this.txt_time.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(354, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "创建时间";
            // 
            // txt_cjr
            // 
            this.txt_cjr.Location = new System.Drawing.Point(139, 17);
            this.txt_cjr.Name = "txt_cjr";
            this.txt_cjr.ReadOnly = true;
            this.txt_cjr.Size = new System.Drawing.Size(100, 20);
            this.txt_cjr.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(69, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "创建人";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_hj);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(14, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(645, 171);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "计划明细";
            // 
            // txt_hj
            // 
            this.txt_hj.Location = new System.Drawing.Point(544, 148);
            this.txt_hj.Name = "txt_hj";
            this.txt_hj.ReadOnly = true;
            this.txt_hj.Size = new System.Drawing.Size(100, 20);
            this.txt_hj.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "合计";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fhdw,
            this.ysfs,
            this.shdw,
            this.shd,
            this.fjdz,
            this.jhl});
            this.dataGridView1.Location = new System.Drawing.Point(0, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(643, 129);
            this.dataGridView1.TabIndex = 0;
            // 
            // fhdw
            // 
            this.fhdw.HeaderText = "发货单位";
            this.fhdw.Name = "fhdw";
            this.fhdw.ReadOnly = true;
            // 
            // ysfs
            // 
            this.ysfs.HeaderText = "运输方式";
            this.ysfs.Name = "ysfs";
            this.ysfs.ReadOnly = true;
            // 
            // shdw
            // 
            this.shdw.HeaderText = "收货单位";
            this.shdw.Name = "shdw";
            this.shdw.ReadOnly = true;
            // 
            // shd
            // 
            this.shd.HeaderText = "收货地";
            this.shd.Name = "shd";
            this.shd.ReadOnly = true;
            // 
            // fjdz
            // 
            this.fjdz.HeaderText = "附加地址";
            this.fjdz.Name = "fjdz";
            this.fjdz.ReadOnly = true;
            // 
            // jhl
            // 
            this.jhl.HeaderText = "计划量/吨";
            this.jhl.Name = "jhl";
            this.jhl.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_type);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_zxsj);
            this.groupBox1.Controls.Add(this.txt_cmp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 89);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "运输计划";
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(113, 55);
            this.txt_type.Name = "txt_type";
            this.txt_type.ReadOnly = true;
            this.txt_type.Size = new System.Drawing.Size(107, 20);
            this.txt_type.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "计划类型";
            // 
            // txt_zxsj
            // 
            this.txt_zxsj.Location = new System.Drawing.Point(357, 19);
            this.txt_zxsj.Name = "txt_zxsj";
            this.txt_zxsj.ReadOnly = true;
            this.txt_zxsj.Size = new System.Drawing.Size(189, 20);
            this.txt_zxsj.TabIndex = 4;
            // 
            // txt_cmp
            // 
            this.txt_cmp.Location = new System.Drawing.Point(113, 19);
            this.txt_cmp.Name = "txt_cmp";
            this.txt_cmp.ReadOnly = true;
            this.txt_cmp.Size = new System.Drawing.Size(143, 20);
            this.txt_cmp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "区域公司";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txt_pfyj);
            this.groupBox4.Controls.Add(this.txt_pfrq);
            this.groupBox4.Controls.Add(this.txt_pfr);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(14, 467);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(641, 144);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "批复内容";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "批复意见*";
            // 
            // txt_pfyj
            // 
            this.txt_pfyj.Location = new System.Drawing.Point(104, 92);
            this.txt_pfyj.Multiline = true;
            this.txt_pfyj.Name = "txt_pfyj";
            this.txt_pfyj.Size = new System.Drawing.Size(473, 51);
            this.txt_pfyj.TabIndex = 5;
            // 
            // txt_pfrq
            // 
            this.txt_pfrq.Location = new System.Drawing.Point(418, 17);
            this.txt_pfrq.Name = "txt_pfrq";
            this.txt_pfrq.Size = new System.Drawing.Size(159, 20);
            this.txt_pfrq.TabIndex = 4;
            // 
            // txt_pfr
            // 
            this.txt_pfr.Location = new System.Drawing.Point(104, 17);
            this.txt_pfr.Name = "txt_pfr";
            this.txt_pfr.Size = new System.Drawing.Size(159, 20);
            this.txt_pfr.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rb_no);
            this.groupBox5.Controls.Add(this.rb_yes);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(29, 43);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(275, 43);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // rb_no
            // 
            this.rb_no.AutoSize = true;
            this.rb_no.Location = new System.Drawing.Point(186, 18);
            this.rb_no.Name = "rb_no";
            this.rb_no.Size = new System.Drawing.Size(61, 17);
            this.rb_no.TabIndex = 2;
            this.rb_no.TabStop = true;
            this.rb_no.Text = "不通过";
            this.rb_no.UseVisualStyleBackColor = true;
            // 
            // rb_yes
            // 
            this.rb_yes.AutoSize = true;
            this.rb_yes.Location = new System.Drawing.Point(101, 18);
            this.rb_yes.Name = "rb_yes";
            this.rb_yes.Size = new System.Drawing.Size(49, 17);
            this.rb_yes.TabIndex = 1;
            this.rb_yes.TabStop = true;
            this.rb_yes.Text = "通过";
            this.rb_yes.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "批复决定*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "批复日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "批复人";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "审批意见";
            // 
            // lb_detail
            // 
            this.lb_detail.AutoSize = true;
            this.lb_detail.Location = new System.Drawing.Point(274, 9);
            this.lb_detail.Name = "lb_detail";
            this.lb_detail.Size = new System.Drawing.Size(103, 13);
            this.lb_detail.TabIndex = 16;
            this.lb_detail.Text = "运输计划详细信息";
            // 
            // btn_approve
            // 
            this.btn_approve.Location = new System.Drawing.Point(202, 617);
            this.btn_approve.Name = "btn_approve";
            this.btn_approve.Size = new System.Drawing.Size(75, 30);
            this.btn_approve.TabIndex = 17;
            this.btn_approve.Text = "审批";
            this.btn_approve.UseVisualStyleBackColor = true;
            this.btn_approve.Click += new System.EventHandler(this.btn_approve_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // 计划审批
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 651);
            this.Controls.Add(this.btn_approve);
            this.Controls.Add(this.lb_detail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "计划审批";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计划审批";
            this.Load += new System.EventHandler(this.计划审批_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_fj;
        private System.Windows.Forms.TextBox txt_bz;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_cjr;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_zxsj;
        private System.Windows.Forms.TextBox txt_cmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_hj;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_detail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_pfyj;
        private System.Windows.Forms.TextBox txt_pfrq;
        private System.Windows.Forms.TextBox txt_pfr;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rb_no;
        private System.Windows.Forms.RadioButton rb_yes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_approve;
        private System.Windows.Forms.DataGridViewTextBoxColumn fhdw;
        private System.Windows.Forms.DataGridViewTextBoxColumn ysfs;
        private System.Windows.Forms.DataGridViewTextBoxColumn shdw;
        private System.Windows.Forms.DataGridViewTextBoxColumn shd;
        private System.Windows.Forms.DataGridViewTextBoxColumn fjdz;
        private System.Windows.Forms.DataGridViewTextBoxColumn jhl;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}