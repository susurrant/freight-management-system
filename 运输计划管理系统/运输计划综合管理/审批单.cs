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
    public partial class 审批单 : Form
    {
        private string kind;
        private string knd;
        private string id;

        public 审批单(string id, string kind)
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

        private void 审批单_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AllowUserToAddRows = false; 
            this.Text = "上报" + kind + "计划审批";
            this.groupBox1.Text = "运输" + kind + "计划";
            this.lb_detail.Text = "运输" + kind + "计划详细信息";

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

            String qs3 = "select * from Approval where planID = '" + this.id + "'";
            SQLquery q3 = new SQLquery(qs3);
            DataTable dt3 = q3.doSelect();
            if (dt3 != null)
            {
                this.txt_pfr.Text = dt3.Rows[0][0].ToString();
                this.txt_pfrq.Text = dt3.Rows[0][1].ToString();
                this.txt_pfjd.Text = dt3.Rows[0][2].ToString();
                this.txt_pfyj.Text = dt3.Rows[0][3].ToString();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
