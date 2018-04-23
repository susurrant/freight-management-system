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
    public partial class Form1 : Form
    {
        private string usrKind;
        private bool menuEnabled;

        public Form1()
        {
            InitializeComponent();
            this.skinEngine1.SkinFile = "Wave.ssk";
        }

        private void 下达运输年计划ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            下达运输年计划列表 dlg = new 下达运输年计划列表(usrKind);
            dlg.ShowDialog();
        }

        private void 上报运输年计划ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            上报运输年计划列表 dlg = new 上报运输年计划列表(usrKind);
            dlg.ShowDialog();
        }

        private void 已下达运输年计划ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            已下达运输年计划列表 dlg = new 已下达运输年计划列表();
            dlg.ShowDialog();
        }

        private void 下达运输月计划ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            下达运输月计划列表 dlg = new 下达运输月计划列表(usrKind);
            dlg.ShowDialog();
        }

        private void 上报运输月计划ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            上报运输月计划列表 dlg = new 上报运输月计划列表(usrKind);
            dlg.ShowDialog();
        }

        private void 已下达运输年计划ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            已下达运输月计划列表 dlg = new 已下达运输月计划列表();
            dlg.ShowDialog();
        }

        private void 下达运输周计划ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            下达运输周计划列表 dlg = new 下达运输周计划列表(usrKind);
            dlg.ShowDialog();
        }

        private void 上报运输周计划ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            上报运输周计划列表 dlg = new 上报运输周计划列表(usrKind);
            dlg.ShowDialog();
        }

        private void 已下达运输周计划ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            已下达运输月计划列表 dlg = new 已下达运输月计划列表();
            dlg.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("谢谢使用运输管理系统！", "提示");
            this.Close();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About dlg = new About();
            dlg.ShowDialog();
        }

        private void btn_regis_Click(object sender, EventArgs e)
        {
            register dlg = new register();
            dlg.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String qStr = "select password,type from Usr where account = '" + this.txt_account.Text + "'";
            SQLquery query = new SQLquery(qStr);
            DataTable dt = query.doSelect();
            if (dt == null)
            {
                MessageBox.Show("用户不存在！", "提示");
            }
            else if (dt.Rows[0][0].ToString() != this.txt_password.Text)
            {
                MessageBox.Show("密码错误！", "提示");
                this.txt_password.Text = "";
            }
            else if (dt.Rows[0][0].ToString() == this.txt_password.Text)
            {
                this.usrKind = dt.Rows[0][1].ToString();
                this.txt_usrType.Text = dt.Rows[0][1].ToString();
                this.txt_usrAccount.Text = this.txt_account.Text;
                this.menuEnabled = true;
                menuEnable();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clearInfo();
            this.menuEnabled = false;
            menuEnable();
            this.timer1.Enabled = true;
        }

        private void menuEnable()
        {
            if (menuEnabled)
            {
                this.gb_login.Visible = false;
                this.gb_user.Visible = true;
                this.gb_menu.Visible = true;
                this.menuStrip1.Items[0].Enabled = true;
                this.menuStrip1.Items[1].Enabled = true;
                this.menuStrip1.Items[2].Enabled = true;
                if (this.usrKind == "业务员")
                {
                    this.下达运输年计划ToolStripMenuItem.Enabled = false;
                    this.下达运输月计划ToolStripMenuItem.Enabled = false;
                    this.下达运输周计划ToolStripMenuItem.Enabled = false;
                    this.btn_ysjhxd_month.Enabled = false;
                    this.btn_ysjhxd_year.Enabled = false;
                    this.btn_ysjhxd_week.Enabled = false;
                }
                else
                {
                    this.下达运输年计划ToolStripMenuItem.Enabled = true;
                    this.下达运输月计划ToolStripMenuItem.Enabled = true;
                    this.下达运输周计划ToolStripMenuItem.Enabled = true;
                    this.btn_ysjhxd_month.Enabled = true;
                    this.btn_ysjhxd_year.Enabled = true;
                    this.btn_ysjhxd_week.Enabled = true;
                }
            }
            else
            {
                this.gb_login.Visible = true;
                this.gb_user.Visible = false;
                this.gb_menu.Visible = false;
                this.menuStrip1.Items[0].Enabled = false;
                this.menuStrip1.Items[1].Enabled = false;
                this.menuStrip1.Items[2].Enabled = false;
            }
        }

        private void btn_changeUser_Click(object sender, EventArgs e)
        {
            clearInfo();
            this.menuEnabled = false;
            menuEnable();
        }

        private void clearInfo()
        {
            this.txt_account.Text = "";
            this.txt_password.Text = "";
            this.txt_usrAccount.Text = "";
            this.txt_usrType.Text = "";
            this.usrKind = "";
        }

        private void btn_ysjhxd_year_Click(object sender, EventArgs e)
        {
            下达运输年计划列表 dlg = new 下达运输年计划列表(usrKind);
            dlg.ShowDialog();
        }

        private void btn_ysjhxd_month_Click(object sender, EventArgs e)
        {
            下达运输月计划列表 dlg = new 下达运输月计划列表(usrKind);
            dlg.ShowDialog();
        }

        private void btn_ysjhxd_week_Click(object sender, EventArgs e)
        {
            下达运输周计划列表 dlg = new 下达运输周计划列表(usrKind);
            dlg.ShowDialog();
        }

        private void btn_ysjhsb_year_Click(object sender, EventArgs e)
        {
            上报运输年计划列表 dlg = new 上报运输年计划列表(usrKind);
            dlg.ShowDialog();
        }

        private void btn_ysjhsb_month_Click(object sender, EventArgs e)
        {
            上报运输月计划列表 dlg = new 上报运输月计划列表(usrKind);
            dlg.ShowDialog();
        }

        private void btn_ysjhsb_week_Click(object sender, EventArgs e)
        {
            上报运输周计划列表 dlg = new 上报运输周计划列表(usrKind);
            dlg.ShowDialog();
        }

        private void btn_yxdjh_year_Click(object sender, EventArgs e)
        {
            已下达运输年计划列表 dlg = new 已下达运输年计划列表();
            dlg.ShowDialog();
        }

        private void btn_yxdjh_month_Click(object sender, EventArgs e)
        {
            已下达运输月计划列表 dlg = new 已下达运输月计划列表();
            dlg.ShowDialog();
        }

        private void btn_yxdjh_week_Click(object sender, EventArgs e)
        {
            已下达运输周计划列表 dlg = new 已下达运输周计划列表();
            dlg.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = System.DateTime.Now.ToLongDateString();
            this.toolStripStatusLabel2.Text = System.DateTime.Now.ToLongTimeString();
        }

    }
}
