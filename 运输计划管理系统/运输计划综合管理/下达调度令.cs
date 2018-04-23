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
    public partial class 下达调度令 : Form
    {
        private string id;
        private string kind;
        private string knd;
        private bool xd;
        public 下达调度令(string id, string kind)
        {
            this.kind = kind;
            if (kind == "年")
            {
                knd = "Year";
            }
            else if (kind == "月")
            {
                knd = "Month";
            }
            else
            {
                knd = "Week";
            }
            this.id = id;
            InitializeComponent();
            this.skinEngine1.SkinFile = "WaveColor2.ssk";
        }

        private void 下达调度令_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AllowUserToAddRows = false; 
            this.xd = false;
            this.cb_jb.Items.Add("Ⅰ级");
            this.cb_jb.Items.Add("Ⅱ级");
            this.cb_jb.Items.Add("Ⅲ级");
            String qStr = "select * from " + knd + "Planning where ID = '" + this.id + "'";
            SQLquery query = new SQLquery(qStr);
            DataTable dt = query.doSelect();
            if (dt != null)
            {
                this.txt_jsdw.Text = dt.Rows[0][1].ToString();
                string tem = dt.Rows[0][2].ToString();
                this.txt_zxsj.Text = tem.Substring(0, 4) + "-" + tem.Substring(4, 2) + "-" + tem.Substring(6, 2) + " 至 " + tem.Substring(0, 4) + "-" + tem.Substring(8, 2) + "-" + tem.Substring(10, 2);
                this.txt_flsj.Text = DateTime.Now.ToLocalTime().ToString("yyyy-MM-dd hh:mm:ss");
                this.txt_hj.Text = dt.Rows[0][5].ToString();
                this.txt_bz.Text = dt.Rows[0][8].ToString();
                this.txt_fj.Text = dt.Rows[0][9].ToString();
            }

            String qs2 = "select * from PlanningDetail where planID = '" + this.id + "'";
            SQLquery q2 = new SQLquery(qs2);
            DataTable dt2 = q2.doSelect();
            if (dt2 != null)
            {
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    this.dataGridView1.Rows.Add(dt2.Rows[i][0].ToString(), dt2.Rows[i][1].ToString(), dt2.Rows[i][2].ToString(),
                        dt2.Rows[i][3].ToString(), dt2.Rows[i][4].ToString(), dt2.Rows[i][5].ToString());
                }
            }
        }

        private void btn_transmit_Click(object sender, EventArgs e)
        {
            if (this.xd)
            {
                MessageBox.Show("您刚已下达了调度令！", "提示");
                return;
            }

            if (this.txt_zlzt.Text == "" || this.txt_qfr.Text == "" || this.txt_jsrxm.Text == "" || this.cb_jb.Text == "")
            {
                MessageBox.Show("必填项(带*号)不能为空！", "提示");
                return;
            }

            if (!isNum(this.txt_flrczdh.Text) || !isNum(this.txt_jsrczdh.Text))
            {
                MessageBox.Show("传真电话格式错误！", "提示");
                return;
            }

            String qStr = "select status from " + knd + "Planning where ID = '" + this.id + "'";
            SQLquery query = new SQLquery(qStr);
            DataTable dt = query.doSelect();
            if (dt != null)
            {
                if (dt.Rows[0][0].ToString() != "未下达")
                {
                    MessageBox.Show("该计划调度令已下达！", "提示");
                    return;
                }
            }

            String qStr0 = "insert into TransportSchedule values('" + this.txt_flsj.Text + "','" + this.txt_qfr.Text
                + "','" + this.txt_zlzt.Text + "','" + this.cb_jb.Text + "','" + this.txt_jsrxm.Text + "','" + this.txt_jsrczdh.Text
                + "','" + this.txt_flr.Text + "','" + this.txt_flrczdh.Text + "','" + this.id + "')";
            SQLquery query0 = new SQLquery(qStr0);
            if (query0.doModify())
            {
                String qStr1 = "update " + knd + "Planning set status = '已下达', attachment = '" + this.txt_fj.Text + "' where ID = '" + this.id + "'";
                SQLquery query1 = new SQLquery(qStr1);
                if (query1.doModify())
                {
                    MessageBox.Show("下达调度令成功！", "提示");
                    this.xd = true;
                }
                else
                {
                    MessageBox.Show("下达调度令失败！", "提示");
                }
            }
            else
            {
                MessageBox.Show("下达调度令失败！", "提示");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (this.txt_zlzt.Text == "" || this.txt_qfr.Text == "" || this.txt_jsrxm.Text == "" ||
                this.cb_jb.Text == "")
            {
                MessageBox.Show("必填项(带*号)不能为空！", "提示");
                return;
            }

            if (!isNum(this.txt_flrczdh.Text) || !isNum(this.txt_jsrczdh.Text))
            {
                MessageBox.Show("传真电话格式错误！", "提示");
                return;
            }

            MessageBox.Show("数据已临时保存！", "提示");
        }

        private bool isNum(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                byte tempByte = Convert.ToByte(s[i]);
                if ((tempByte < 48 || tempByte > 57))
                {
                    return false;
                }
            }
            return true;
        }

        private void btn_fj_Click(object sender, EventArgs e)
        {
            if (this.txt_fj.Text.Length > 1000)
            {
                MessageBox.Show("附件量已达上限！", "提示");
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (this.txt_fj.Text.Length + openFileDialog.SafeFileName.Length > 1000)
                {
                    MessageBox.Show("附件量已达上限！", "提示");
                    return;
                }
                if (this.txt_fj.Text == "")
                {
                    this.txt_fj.Text = openFileDialog.SafeFileName;
                }
                else
                {
                    this.txt_fj.Text = txt_fj.Text + ", " + openFileDialog.SafeFileName;
                }
            }
        } 
    }
}
