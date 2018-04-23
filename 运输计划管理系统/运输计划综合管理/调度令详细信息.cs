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
    public partial class 调度令详细信息 : Form
    {
        private string id;
        private string kind;
        private string knd;
        public 调度令详细信息(string id, string kind)
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 调度令详细信息_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AllowUserToAddRows = false; 
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

            String qs1 = "select * from TransportSchedule where planID = '" + this.id + "'";
            SQLquery q1 = new SQLquery(qs1);
            DataTable dt1 = q1.doSelect();
            if (dt1 != null)
            {
                this.txt_flsj.Text = dt1.Rows[0][0].ToString();
                this.txt_qfr.Text = dt1.Rows[0][1].ToString();
                this.txt_zlzt.Text = dt1.Rows[0][2].ToString();
                this.txt_jb.Text = dt1.Rows[0][3].ToString();
                this.txt_jsrxm.Text = dt1.Rows[0][4].ToString();
                this.txt_jsrczdh.Text = dt1.Rows[0][5].ToString();
                this.txt_flr.Text = dt1.Rows[0][6].ToString();
                this.txt_flrczdh.Text = dt1.Rows[0][7].ToString();
            }

            String qs3 = "select * from " + knd + "Planning where ID = '" + this.id + "'";
            SQLquery q3 = new SQLquery(qs3);
            DataTable dt3 = q3.doSelect();
            if (dt3 != null)
            {
                this.txt_jsdw.Text = dt3.Rows[0][1].ToString();
                string tem = dt3.Rows[0][2].ToString();
                this.txt_zxsj.Text = tem.Substring(0, 4) + "-" + tem.Substring(4, 2) + "-" + tem.Substring(6, 2) + " 至 " + tem.Substring(0, 4) + "-" + tem.Substring(8, 2) + "-" + tem.Substring(10, 2);
                this.txt_hj.Text = dt3.Rows[0][5].ToString();
                this.txt_bz.Text = dt3.Rows[0][8].ToString();
                this.txt_fj.Text = dt3.Rows[0][9].ToString();
            }
        }
    }
}
