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
    public partial class 已下达运输年计划列表 : Form
    {
        public 已下达运输年计划列表()
        {
            InitializeComponent();
            this.skinEngine1.SkinFile = "WaveColor1.ssk";
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.cb_company.SelectedIndex = -1;
            this.cb_type.SelectedIndex = -1;
            this.cb_year.SelectedIndex = -1;

            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Update();
        }

        private void 已下达运输年计划列表_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AllowUserToAddRows = false; 
            this.cb_type.Items.Add("追加");
            this.cb_type.Items.Add("普通");
            this.cb_type.SelectedIndex = 1;

            String qStr = "select * from YearPlanning where status = '已下达'";
            SQLquery query = new SQLquery(qStr);
            DataTable dt = query.doSelect();
            if (dt != null)
            {
                List<string> lcmp = new List<string>();
                List<string> lyear = new List<string>();
                string temp;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    temp = dt.Rows[i][1].ToString();
                    if (!lcmp.Contains(temp))
                    {
                        lcmp.Add(temp);
                    }
                    temp = dt.Rows[i][2].ToString().Substring(0, 4);
                    if (!lyear.Contains(temp))
                    {
                        lyear.Add(temp);
                    }
                }
                foreach (string s in lcmp)
                {
                    this.cb_company.Items.Add(s);
                }
                foreach (string s in lyear)
                {
                    this.cb_year.Items.Add(s);
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string cmp = this.cb_company.Text;
            string year = this.cb_year.Text;
            string ptype = this.cb_type.Text;

            String qStr = "select company,date,amount,type,ID from YearPlanning where company " + (cmp != "" ? ("= '" + cmp + "'") : "is not null") +
                    " and date " + (year != "" ? ("like '" + year + "%'") : "is not null") + " and type " + (ptype != "" ? (" = '" + ptype + "'") : "is not null") +
                    " and status = '已下达'";

            SQLquery query = new SQLquery(qStr);
            DataTable dt = query.doSelect();
            if (dt == null)
            {
                MessageBox.Show("未查到符合条件的记录！", "提示");
            }
            else
            {
                this.dataGridView1.Rows.Clear();
                this.dataGridView1.Update();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string tem = dt.Rows[i][1].ToString();
                    string st = tem.Substring(0, 4) + "-" + tem.Substring(4, 2) + "-" + tem.Substring(6, 2);
                    string et = tem.Substring(0, 4) + "-" + tem.Substring(8, 2) + "-" + tem.Substring(10, 2);
                    this.dataGridView1.Rows.Add("false", i + 1, dt.Rows[i][0].ToString(), st, et,
                        dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString());
                 }
            }
         }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                if (this.dataGridView1.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                {
                    运输计划详细信息 dlg = new 运输计划详细信息(this.dataGridView1.Rows[i].Cells["ID"].Value.ToString(), "年");
                    dlg.ShowDialog();
                }
            }
        }

        private void btn_schedule_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                if (this.dataGridView1.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                {
                    调度令详细信息 dlg = new 调度令详细信息(this.dataGridView1.Rows[i].Cells["ID"].Value.ToString(), "年");
                    dlg.ShowDialog();
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
