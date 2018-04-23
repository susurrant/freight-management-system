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
    public partial class 计划审批 : Form
    {
        private string kind;
        private string knd;
        private string id;
        private bool sp;

        public 计划审批(string id, string kind)
        {
            this.id = id;
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
            InitializeComponent();
            this.skinEngine1.SkinFile = "WaveColor2.ssk";
        }

        private void 计划审批_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AllowUserToAddRows = false; 
            this.Text = "上报" + kind + "计划审批";
            this.groupBox1.Text = "运输" + kind + "计划";
            this.lb_detail.Text = "运输" + kind + "计划详细信息";
            this.rb_yes.Checked = true;
            this.txt_pfrq.Text = DateTime.Now.ToString("yyyy-MM-dd");
            this.sp = false;

            String qs1 = "select * from " + knd + "Planning where ID = '" + this.id + "'";
            SQLquery q1 = new SQLquery(qs1);
            DataTable dt1 = q1.doSelect();
            if (dt1 != null)
            {
                this.txt_cmp.Text = dt1.Rows[0][1].ToString();
                string tem = dt1.Rows[0][2].ToString();
                this.txt_zxsj.Text = tem.Substring(0, 4) + "-" + tem.Substring(4, 2) + "-" + tem.Substring(6, 2) + " 至 " + tem.Substring(0, 4) + "-" + tem.Substring(8, 2) + "-" + tem.Substring(10, 2);
                this.txt_type.Text = dt1.Rows[0][3].ToString();
                this.txt_hj.Text = dt1.Rows[0][5].ToString();
                this.txt_cjr.Text = dt1.Rows[0][6].ToString();
                this.txt_time.Text = dt1.Rows[0][7].ToString();
                this.txt_bz.Text = dt1.Rows[0][8].ToString();
                this.txt_fj.Text = dt1.Rows[0][9].ToString();
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_approve_Click(object sender, EventArgs e)
        {
            if (this.sp)
            {
                MessageBox.Show("该年计划已被审批过了！", "提示");
                return;
            }

            if (txt_pfyj.Text == "")
            {
                MessageBox.Show("请填写批复意见", "提示");
                return;
            }

            string decision = "通过";
            if (this.rb_no.Checked)
            {
                decision = "不通过";
            }

            String qStr = "insert into Approval values('" + this.txt_pfr.Text + "','" + this.txt_pfrq.Text +
                "','" + decision + "','" + this.txt_pfyj.Text + "','" + this.id + "')";
            SQLquery query = new SQLquery(qStr);
            bool b = query.doModify();

            String qStr1 = "update " + knd + "Planning set status = '" + decision + "' where ID = '" + this.id + "'";
            SQLquery query1 = new SQLquery(qStr1);
            bool b1 = query1.doModify();

            if (b && b1)
            {
                MessageBox.Show("审批完成！", "提示");
                this.sp = true;
            }
            else
            {
                MessageBox.Show("审批失败！", "提示");
            }
        }


    }
}
