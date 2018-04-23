namespace 运输计划管理系统
{
    partial class register
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
            this.btn_r = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_zh = new System.Windows.Forms.TextBox();
            this.txt_mm = new System.Windows.Forms.TextBox();
            this.txt_qrmm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_kind = new System.Windows.Forms.ComboBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // btn_r
            // 
            this.btn_r.Location = new System.Drawing.Point(87, 170);
            this.btn_r.Name = "btn_r";
            this.btn_r.Size = new System.Drawing.Size(75, 33);
            this.btn_r.TabIndex = 0;
            this.btn_r.Text = "确认注册";
            this.btn_r.UseVisualStyleBackColor = true;
            this.btn_r.Click += new System.EventHandler(this.btn_r_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(208, 170);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 33);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "退出";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "请输入账号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "请输入密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "确认密码：";
            // 
            // txt_zh
            // 
            this.txt_zh.Location = new System.Drawing.Point(150, 30);
            this.txt_zh.Name = "txt_zh";
            this.txt_zh.Size = new System.Drawing.Size(158, 20);
            this.txt_zh.TabIndex = 5;
            // 
            // txt_mm
            // 
            this.txt_mm.Location = new System.Drawing.Point(150, 66);
            this.txt_mm.Name = "txt_mm";
            this.txt_mm.PasswordChar = '*';
            this.txt_mm.Size = new System.Drawing.Size(158, 20);
            this.txt_mm.TabIndex = 6;
            // 
            // txt_qrmm
            // 
            this.txt_qrmm.Location = new System.Drawing.Point(150, 102);
            this.txt_qrmm.Name = "txt_qrmm";
            this.txt_qrmm.PasswordChar = '*';
            this.txt_qrmm.Size = new System.Drawing.Size(158, 20);
            this.txt_qrmm.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "用户类型：";
            // 
            // cb_kind
            // 
            this.cb_kind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_kind.FormattingEnabled = true;
            this.cb_kind.Location = new System.Drawing.Point(150, 138);
            this.cb_kind.Name = "cb_kind";
            this.cb_kind.Size = new System.Drawing.Size(158, 21);
            this.cb_kind.TabIndex = 9;
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 215);
            this.Controls.Add(this.cb_kind);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_qrmm);
            this.Controls.Add(this.txt_mm);
            this.Controls.Add(this.txt_zh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_r);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新用户注册";
            this.Load += new System.EventHandler(this.register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_r;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_zh;
        private System.Windows.Forms.TextBox txt_mm;
        private System.Windows.Forms.TextBox txt_qrmm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_kind;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}