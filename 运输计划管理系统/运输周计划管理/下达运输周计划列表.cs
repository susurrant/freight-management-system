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
    public partial class 下达运输周计划列表 : Form
    {
        private string cmp;
        private string year;
        private string month;
        private string z;
        private string statues;
        private string ptype;
        private bool searchClick;
        private string usrKind;

        public 下达运输周计划列表(string usrKind)
        {
            this.usrKind = usrKind; 
            InitializeComponent();
            this.skinEngine1.SkinFile = "WaveColor1.ssk";
        }

        private void 下达运输周计划列表_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AllowUserToAddRows = false; 
            showData();
            this.cb_type.Items.Add("追加");
            this.cb_type.Items.Add("普通");
            this.cb_statues.Items.Add("未下达");
            this.cb_statues.Items.Add("已下达");
            this.cb_type.SelectedIndex = 1;
            this.cmp = "";
            this.year = "";
            this.month = "";
            this.statues = "";
            this.z = "";
            this.ptype = "普通";
            this.searchClick = false;

            for (int i = 1; i < 10; i++)
            {
                this.cb_month.Items.Add("0" + Convert.ToString(i));
            }
            this.cb_month.Items.Add(Convert.ToString(10));
            this.cb_month.Items.Add(Convert.ToString(11));
            this.cb_month.Items.Add(Convert.ToString(12));

            for (int i = 1; i < 5; i++)
            {
                this.cb_zs.Items.Add(i.ToString());
            }
        }

        private void showData()
        {
            String qStr = "select * from WeekPlanning where status = '已下达' or status = '未下达'";
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
            this.cmp = this.cb_company.Text;
            this.year = this.cb_year.Text;
            this.statues = this.cb_statues.Text;
            this.ptype = this.cb_type.Text;
            this.month = this.cb_month.Text;
            this.z = this.cb_zs.Text;
            this.searchClick = true;

            updateDataGridView();
        }

        private void updateDataGridView()
        {
            if (this.searchClick == true)
            {
                string sj = this.year + this.month;
                String qStr = "select company,date,amount,type,status,ID from WeekPlanning where company " + (cmp != "" ? ("= '" + cmp + "'") : "is not null") +
                    " and date " + (sj != "" ? ("like '" + sj + "%'") : "is not null") + " and week " + (z != "" ? ("= " + z ) : "> 0") + 
                    " and type " + (ptype != "" ? (" = '" + ptype + "'") : "is not null") +
                    " and (status " + (statues != "" ? (" = '" + statues + "')") : (" = '已下达' or status = '未下达')"));

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
                            dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), "下达", dt.Rows[i][5].ToString());

                        if (dt.Rows[i][4].ToString() != "未下达")
                        {
                            Font f = new Font("宋体", 9, FontStyle.Strikeout);
                            dataGridView1.Rows[i].Cells[8].Style.Font = f;
                        }
                    }
                }

            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.cb_company.SelectedIndex = -1;
            this.cb_statues.SelectedIndex = -1;
            this.cb_type.SelectedIndex = -1;
            this.cb_year.SelectedIndex = -1;
            this.cb_month.SelectedIndex = -1;
            this.cb_zs.SelectedIndex = -1;
            this.cmp = "";
            this.year = "";
            this.statues = "";
            this.ptype = "";
            this.month = "";
            this.z = "";

            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Update();
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                if (this.dataGridView1.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                {
                    运输计划详细信息 dlg = new 运输计划详细信息(this.dataGridView1.Rows[i].Cells["ID"].Value.ToString(), "周");
                    dlg.ShowDialog();
                }
            }
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                if (this.dataGridView1.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                {
                    if (this.dataGridView1.Rows[i].Cells[7].Value.ToString() == "未下达")
                    {
                        运输计划修改 dlg = new 运输计划修改(this.dataGridView1.Rows[i].Cells["ID"].Value.ToString(), "周");
                        dlg.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("该周计划不可修改！", "提示");
                    }
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                if (this.dataGridView1.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                {
                    if (this.dataGridView1.Rows[i].Cells[7].Value.ToString() == "未下达")
                    {
                        //删除周计划
                        deletePlan d = new deletePlan(this.dataGridView1.Rows[i].Cells["ID"].Value.ToString(), "周");
                        bool b = d.doDelete();

                        if (b)
                        {
                            MessageBox.Show("删除周计划成功！", "提示");
                            this.dataGridView1.Rows.RemoveAt(i);
                            updateDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("删除周计划失败！", "提示");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("该周计划不可删除！", "提示");
                }
            }
        }

        private void btn_schedule_Click(object sender, EventArgs e)
        {
            //updateDataGridView();
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                if (this.dataGridView1.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                {
                    if (this.dataGridView1.Rows[i].Cells[7].Value.ToString() == "已下达")
                    {
                        调度令详细信息 dlg = new 调度令详细信息(this.dataGridView1.Rows[i].Cells["ID"].Value.ToString(), "周");
                        dlg.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("该周计划尚未下达调度令！", "提示");
                    }
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[e.ColumnIndex].Value = false;
                }
                dataGridView1.Rows[e.RowIndex].Cells[0].Value = true;
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == 8 && this.dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString() == "未下达")
            {
                if (this.usrKind != "审批员")
                {
                    MessageBox.Show("用户权限不够！", "提示");
                    return;
                }

                下达调度令 dlg = new 下达调度令(this.dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString(), "周");
                dlg.ShowDialog();
            }
        }


    }
}
