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
    public partial class 上报运输月计划列表 : Form
    {
        private string cmp;
        private string year;
        private string month;
        private string statues;
        private string ptype;
        private bool searchClick;
        private string usrKind;

        public 上报运输月计划列表(string usrKind)
        {
            this.usrKind = usrKind; 
            InitializeComponent();
            this.skinEngine1.SkinFile = "WaveColor1.ssk";
        }

        private void 上报运输月计划列表_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AllowUserToAddRows = false; 
            showData();
            this.cb_type.Items.Add("追加");
            this.cb_type.Items.Add("普通");
            this.cb_type.SelectedIndex = 1;
            if (this.usrKind == "业务员")
            {
                this.cb_statues.Items.Add("新增");
                this.cb_statues.Items.Add("待审");
                this.cb_statues.Items.Add("通过");
                this.cb_statues.Items.Add("不通过");
            }
            else if (this.usrKind == "审批员")
            {
                this.cb_statues.Items.Add("待审");
                this.cb_statues.Items.Add("通过");
                this.cb_statues.Items.Add("不通过");
            }
            this.cmp = "";
            this.year = "";
            this.statues = "";
            this.month = "";
            this.ptype = "普通";
            this.searchClick = false;

            for (int i = 1; i < 10; i++)
            {
                this.cb_month.Items.Add("0" + Convert.ToString(i));
            }
            this.cb_month.Items.Add(Convert.ToString(10));
            this.cb_month.Items.Add(Convert.ToString(11));
            this.cb_month.Items.Add(Convert.ToString(12));
        }

        private void showData()
        {
            String qStr = "select * from MonthPlanning where status <> '已下达' and status <> '未下达'";
            if (this.usrKind == "审批员")
            {
                qStr = "select * from MonthPlanning where status <> '已下达' and status <> '未下达' and status <> '新增'";
            }
            
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
            this.searchClick = true;

            updateDataGridView();
        }

        private void updateDataGridView()
        {
            if (this.searchClick == true)
            {
                string sj = this.year + this.month;
                String qStr = "select company,date,amount,type,status,ID from MonthPlanning where company " + (cmp != "" ? ("= '" + cmp + "'") : "is not null") +
                    " and date " + (sj != "" ? ("like '" + sj + "%'") : "is not null") + " and type " + (ptype != "" ? (" = '" + ptype + "'") : "is not null") +
                    " and (status " + (statues != "" ? (" = '" + statues + "')") : (" <> '已下达' and status <> '未下达')"));

                if (this.usrKind == "审批员")
                {
                    qStr = "select company,date,amount,type,status,ID from MonthPlanning where company " + (cmp != "" ? ("= '" + cmp + "'") : "is not null") +
                        " and date " + (year != "" ? ("like '" + year + "%'") : "is not null") + " and type " + (ptype != "" ? (" = '" + ptype + "'") : "is not null") +
                        " and (status " + (statues != "" ? (" = '" + statues + "')") : (" <> '已下达' and status <> '未下达' and status <> '新增')"));
                }

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
                            dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), "录入", dt.Rows[i][5].ToString());
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
            this.cmp = "";
            this.year = "";
            this.statues = "";
            this.ptype = "";
            this.month = "";

            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Update();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                if (this.dataGridView1.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                {
                    运输计划详细信息 dlg = new 运输计划详细信息(this.dataGridView1.Rows[i].Cells["ID"].Value.ToString(), "月");
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
                    if (this.dataGridView1.Rows[i].Cells[7].Value.ToString() == "新增" ||
                        this.dataGridView1.Rows[i].Cells[7].Value.ToString() == "不通过")
                    {
                        if (this.usrKind != "业务员")
                        {
                            MessageBox.Show("用户权限不够！", "提示");
                            return;
                        }
                        运输计划修改 dlg = new 运输计划修改(this.dataGridView1.Rows[i].Cells["ID"].Value.ToString(), "月");
                        dlg.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("该月计划不可修改！", "提示");
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
                    if (this.dataGridView1.Rows[i].Cells[7].Value.ToString() == "新增" ||
                        this.dataGridView1.Rows[i].Cells[7].Value.ToString() == "不通过")
                    {
                        if (this.usrKind != "业务员")
                        {
                            MessageBox.Show("用户权限不够！", "提示");
                            return;
                        }
                        //删除月计划
                        deletePlan d = new deletePlan(this.dataGridView1.Rows[i].Cells["ID"].Value.ToString(), "月");
                        bool b = d.doDelete();

                        //得到对应周计划ID，删除对应周计划
                        String qStr = "select ID from WeekPlanning where planID = '" + this.dataGridView1.Rows[i].Cells["ID"].Value.ToString() + "'";
                        SQLquery query = new SQLquery(qStr);
                        DataTable dt = query.doSelect();
                        if (dt != null)
                        {
                            for (int j = 0; j < dt.Rows.Count; j++)
                            {
                                deletePlan d2 = new deletePlan(dt.Rows[j][0].ToString(), "周");
                                d2.doDelete();
                            }
                        }

                        if (b)
                        {
                            MessageBox.Show("删除月计划成功！", "提示");
                            this.dataGridView1.Rows.RemoveAt(i);
                            updateDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("删除月计划失败！", "提示");
                        }
                    }
                    else
                    {
                        MessageBox.Show("该月计划不可删除！", "提示");
                    }
                }
            }
        }

        private void btn_transmit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                if (this.dataGridView1.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                {
                    if (this.dataGridView1.Rows[i].Cells[7].Value.ToString() == "新增" ||
                        this.dataGridView1.Rows[i].Cells[7].Value.ToString() == "不通过")
                    {
                        if (this.usrKind != "业务员")
                        {
                            MessageBox.Show("用户权限不够！", "提示");
                            return;
                        }

                        String qStr = "update MonthPlanning set status = '待审' where ID = '" + this.dataGridView1.Rows[i].Cells["ID"].Value.ToString() + "'";
                        SQLquery query = new SQLquery(qStr);
                        if (query.doModify())
                        {
                            MessageBox.Show("月计划提交成功！", "提示");
                            updateDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("月计划提交失败！", "提示");
                        }
                    }
                    else
                    {
                        MessageBox.Show("该月计划不可提交！", "提示");
                    }
                }
            }
        }

        private void btn_approve_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                if (this.dataGridView1.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                {
                    if (this.dataGridView1.Rows[i].Cells[7].Value.ToString() == "待审")
                    {
                        if (this.usrKind != "审批员")
                        {
                            MessageBox.Show("用户权限不够！", "提示");
                            return;
                        }

                        计划审批 dlg = new 计划审批(this.dataGridView1.Rows[i].Cells["ID"].Value.ToString(), "月");
                        dlg.ShowDialog();
                    }
                    else  if (this.dataGridView1.Rows[i].Cells[7].Value.ToString() == "新增")
                    {
                        MessageBox.Show("该月计划尚未提交！", "错误");
                    }
                    else if (this.dataGridView1.Rows[i].Cells[7].Value.ToString() == "通过")
                    {
                        MessageBox.Show("该月计划已审批通过！", "禁止");
                    }
                }
            }
        }

        private void btn_spd_Click(object sender, EventArgs e)
        {
            //updateDataGridView();
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                if (this.dataGridView1.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                {
                    if (this.dataGridView1.Rows[i].Cells[7].Value.ToString() == "通过" ||
                        this.dataGridView1.Rows[i].Cells[7].Value.ToString() == "不通过")
                    {
                        审批单 dlg = new 审批单(this.dataGridView1.Rows[i].Cells["ID"].Value.ToString(), "月");
                        dlg.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("该月计划尚未审批！", "提示");
                    }
                }

            }
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

            if (e.ColumnIndex == 8 && e.RowIndex >= 0)
            {
                if (this.usrKind != "业务员")
                {
                    MessageBox.Show("用户权限不够！", "提示");
                    return;
                }

                if (this.dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString() != "通过")
                {
                    MessageBox.Show("该计划尚未审批通过，不能录入！", "错误");
                    return;
                }
                运输周计划录入 dlg = new 运输周计划录入(this.dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString(), "上报");
                dlg.ShowDialog();
            }  
        }



    }
}
