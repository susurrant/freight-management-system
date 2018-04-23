using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 运输计划管理系统
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
            this.skinEngine1.SkinFile = "Page.ssk";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_r_Click(object sender, EventArgs e)
        {
            if (this.txt_zh.Text == "" || this.txt_mm.Text == "" || this.txt_qrmm.Text == "" || this.cb_kind.Text == "")
            {
                MessageBox.Show("账号、密码或用户类型不能为空！", "错误");
                return;
            }

            if (this.txt_mm.Text != this.txt_qrmm.Text)
            {
                MessageBox.Show("确认密码不一致！", "错误");
                this.txt_qrmm.Text = "";
                return;
            }

            String qStr = "select * from Usr where account = '" + this.txt_zh.Text + "'";
            SQLquery query = new SQLquery(qStr);
            DataTable dt = query.doSelect();
            if (dt != null)
            {
                MessageBox.Show("账号已存在！", "错误");
                this.txt_zh.Text = "";
                this.txt_mm.Text = "";
                this.txt_qrmm.Text = "";
                this.cb_kind.SelectedIndex = -1;
                return;
            }

            String qStr1 = "insert into Usr values('" + this.txt_zh.Text + "','" + 
                this.txt_mm.Text + "','" + this.cb_kind.Text + "')";
            SQLquery query1 = new SQLquery(qStr1);
            if (query1.doModify())
            {
                MessageBox.Show("用户注册成功！", "提示");
                this.txt_zh.Text = "";
                this.txt_mm.Text = "";
                this.txt_qrmm.Text = "";
                this.cb_kind.SelectedIndex = -1;
                this.Close();
            }
            else
            {
                MessageBox.Show("用户注册失败！", "提示");
            }
        }

        private void register_Load(object sender, EventArgs e)
        {
            this.cb_kind.Items.Add("业务员");
            this.cb_kind.Items.Add("审批员");
        }
    }
}
