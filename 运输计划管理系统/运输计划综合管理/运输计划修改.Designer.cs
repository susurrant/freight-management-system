﻿namespace 运输计划管理系统
{
    partial class 运输计划修改
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
            this.btn_edit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_fj = new System.Windows.Forms.TextBox();
            this.btn_attach = new System.Windows.Forms.Button();
            this.txt_bz = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_cjr = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_hj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_jhl = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_fjdz = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_shd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_shdw = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gb_trans = new System.Windows.Forms.GroupBox();
            this.rb_way = new System.Windows.Forms.RadioButton();
            this.rb_sea = new System.Windows.Forms.RadioButton();
            this.rb_railway = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_fhdw = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fhdw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ysfs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shdw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fjdz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jhl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this._ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.txt_zxsj = new System.Windows.Forms.TextBox();
            this.txt_cmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gb_trans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(384, 523);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(99, 32);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "返回";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(240, 523);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(99, 32);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "修改";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_fj);
            this.groupBox2.Controls.Add(this.btn_attach);
            this.groupBox2.Controls.Add(this.txt_bz);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txt_time);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_cjr);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(12, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(704, 147);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "附加信息";
            // 
            // txt_fj
            // 
            this.txt_fj.Location = new System.Drawing.Point(139, 111);
            this.txt_fj.Name = "txt_fj";
            this.txt_fj.Size = new System.Drawing.Size(438, 20);
            this.txt_fj.TabIndex = 7;
            // 
            // btn_attach
            // 
            this.btn_attach.Location = new System.Drawing.Point(47, 111);
            this.btn_attach.Name = "btn_attach";
            this.btn_attach.Size = new System.Drawing.Size(75, 23);
            this.btn_attach.TabIndex = 6;
            this.btn_attach.Text = "添加附件";
            this.btn_attach.UseVisualStyleBackColor = true;
            // 
            // txt_bz
            // 
            this.txt_bz.Location = new System.Drawing.Point(139, 47);
            this.txt_bz.Multiline = true;
            this.txt_bz.Name = "txt_bz";
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
            this.txt_cjr.Size = new System.Drawing.Size(100, 20);
            this.txt_cjr.TabIndex = 1;
            this.txt_cjr.Text = "系统管理员";
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
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_jhl);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_fjdz);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_shd);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_shdw);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.gb_trans);
            this.groupBox3.Controls.Add(this.txt_fhdw);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(706, 257);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "计划明细";
            // 
            // txt_hj
            // 
            this.txt_hj.Location = new System.Drawing.Point(544, 233);
            this.txt_hj.Name = "txt_hj";
            this.txt_hj.ReadOnly = true;
            this.txt_hj.Size = new System.Drawing.Size(100, 20);
            this.txt_hj.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "合计";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(560, 78);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(97, 32);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(452, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "吨";
            // 
            // txt_jhl
            // 
            this.txt_jhl.Location = new System.Drawing.Point(318, 90);
            this.txt_jhl.Name = "txt_jhl";
            this.txt_jhl.Size = new System.Drawing.Size(129, 20);
            this.txt_jhl.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(354, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "计划量*";
            // 
            // txt_fjdz
            // 
            this.txt_fjdz.Location = new System.Drawing.Point(6, 90);
            this.txt_fjdz.Name = "txt_fjdz";
            this.txt_fjdz.Size = new System.Drawing.Size(263, 20);
            this.txt_fjdz.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(99, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "附加地址";
            // 
            // txt_shd
            // 
            this.txt_shd.Location = new System.Drawing.Point(494, 44);
            this.txt_shd.Name = "txt_shd";
            this.txt_shd.Size = new System.Drawing.Size(163, 20);
            this.txt_shd.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(546, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "收货地*";
            // 
            // txt_shdw
            // 
            this.txt_shdw.Location = new System.Drawing.Point(333, 44);
            this.txt_shdw.Name = "txt_shdw";
            this.txt_shdw.Size = new System.Drawing.Size(138, 20);
            this.txt_shdw.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(373, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "收货单位*";
            // 
            // gb_trans
            // 
            this.gb_trans.Controls.Add(this.rb_way);
            this.gb_trans.Controls.Add(this.rb_sea);
            this.gb_trans.Controls.Add(this.rb_railway);
            this.gb_trans.Controls.Add(this.label7);
            this.gb_trans.Location = new System.Drawing.Point(158, 12);
            this.gb_trans.Name = "gb_trans";
            this.gb_trans.Size = new System.Drawing.Size(169, 52);
            this.gb_trans.TabIndex = 4;
            this.gb_trans.TabStop = false;
            // 
            // rb_way
            // 
            this.rb_way.AutoSize = true;
            this.rb_way.Location = new System.Drawing.Point(118, 32);
            this.rb_way.Name = "rb_way";
            this.rb_way.Size = new System.Drawing.Size(49, 17);
            this.rb_way.TabIndex = 6;
            this.rb_way.TabStop = true;
            this.rb_way.Text = "公路";
            this.rb_way.UseVisualStyleBackColor = true;
            // 
            // rb_sea
            // 
            this.rb_sea.AutoSize = true;
            this.rb_sea.Location = new System.Drawing.Point(62, 32);
            this.rb_sea.Name = "rb_sea";
            this.rb_sea.Size = new System.Drawing.Size(49, 17);
            this.rb_sea.TabIndex = 5;
            this.rb_sea.TabStop = true;
            this.rb_sea.Text = "海运";
            this.rb_sea.UseVisualStyleBackColor = true;
            // 
            // rb_railway
            // 
            this.rb_railway.AutoSize = true;
            this.rb_railway.Location = new System.Drawing.Point(7, 32);
            this.rb_railway.Name = "rb_railway";
            this.rb_railway.Size = new System.Drawing.Size(49, 17);
            this.rb_railway.TabIndex = 4;
            this.rb_railway.TabStop = true;
            this.rb_railway.Text = "铁路";
            this.rb_railway.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "运输方式*";
            // 
            // txt_fhdw
            // 
            this.txt_fhdw.Location = new System.Drawing.Point(6, 44);
            this.txt_fhdw.Name = "txt_fhdw";
            this.txt_fhdw.Size = new System.Drawing.Size(138, 20);
            this.txt_fhdw.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "发货单位*";
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
            this.jhl,
            this.delete,
            this._ID});
            this.dataGridView1.Location = new System.Drawing.Point(0, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(704, 115);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // fhdw
            // 
            this.fhdw.HeaderText = "发货单位";
            this.fhdw.Name = "fhdw";
            // 
            // ysfs
            // 
            this.ysfs.HeaderText = "运输方式";
            this.ysfs.Name = "ysfs";
            // 
            // shdw
            // 
            this.shdw.HeaderText = "收货单位";
            this.shdw.Name = "shdw";
            // 
            // shd
            // 
            this.shd.HeaderText = "收货地";
            this.shd.Name = "shd";
            // 
            // fjdz
            // 
            this.fjdz.HeaderText = "附加地址";
            this.fjdz.Name = "fjdz";
            // 
            // jhl
            // 
            this.jhl.HeaderText = "计划量/吨";
            this.jhl.Name = "jhl";
            // 
            // delete
            // 
            this.delete.HeaderText = "操作";
            this.delete.Name = "delete";
            this.delete.Text = "删除";
            this.delete.Width = 60;
            // 
            // _ID
            // 
            this._ID.HeaderText = "ID";
            this._ID.Name = "_ID";
            this._ID.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_type);
            this.groupBox1.Controls.Add(this.txt_zxsj);
            this.groupBox1.Controls.Add(this.txt_cmp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 89);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(151, 58);
            this.txt_type.Name = "txt_type";
            this.txt_type.ReadOnly = true;
            this.txt_type.Size = new System.Drawing.Size(107, 20);
            this.txt_type.TabIndex = 8;
            // 
            // txt_zxsj
            // 
            this.txt_zxsj.Location = new System.Drawing.Point(423, 19);
            this.txt_zxsj.Name = "txt_zxsj";
            this.txt_zxsj.ReadOnly = true;
            this.txt_zxsj.Size = new System.Drawing.Size(234, 20);
            this.txt_zxsj.TabIndex = 4;
            // 
            // txt_cmp
            // 
            this.txt_cmp.Location = new System.Drawing.Point(151, 19);
            this.txt_cmp.Name = "txt_cmp";
            this.txt_cmp.ReadOnly = true;
            this.txt_cmp.Size = new System.Drawing.Size(143, 20);
            this.txt_cmp.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "计划类型*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "时间*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "区域公司*";
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // 运输计划修改
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 567);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "运输计划修改";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.运输计划修改_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gb_trans.ResumeLayout(false);
            this.gb_trans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_fj;
        private System.Windows.Forms.Button btn_attach;
        private System.Windows.Forms.TextBox txt_bz;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_cjr;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_jhl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_fjdz;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_shd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_shdw;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gb_trans;
        private System.Windows.Forms.RadioButton rb_way;
        private System.Windows.Forms.RadioButton rb_sea;
        private System.Windows.Forms.RadioButton rb_railway;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_fhdw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_zxsj;
        private System.Windows.Forms.TextBox txt_cmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.TextBox txt_hj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn fhdw;
        private System.Windows.Forms.DataGridViewTextBoxColumn ysfs;
        private System.Windows.Forms.DataGridViewTextBoxColumn shdw;
        private System.Windows.Forms.DataGridViewTextBoxColumn shd;
        private System.Windows.Forms.DataGridViewTextBoxColumn fjdz;
        private System.Windows.Forms.DataGridViewTextBoxColumn jhl;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn _ID;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}