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
    public partial class 运输计划修改 : Form
    {
        private string id;
        private string kind;
        private string knd;
        private List<string> ld;
        private List<string> lm;
        private double totalUp;
        private double totalMin;
        private double hjtxt;
        private bool isLoad;

        public 运输计划修改(string id, string kind)
        {
            this.isLoad = false;
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

        private void 运输计划修改_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AllowUserToAddRows = false; 
            this.Text = "运输" + kind + "计划修改";
            this.groupBox1.Text = "运输" + kind + "计划";
            ld = new List<string>();
            lm = new List<string>();
            this.rb_railway.Checked = true;
            this.hjtxt = 0;
            this.totalMin = 0;
            this.totalUp = 0;
            
            String qs1 = "select * from " + knd + "Planning where ID = '" + this.id + "'";
            SQLquery q1 = new SQLquery(qs1);
            DataTable dt1 = q1.doSelect();
            if (dt1 != null)
            {
                this.txt_cmp.Text = dt1.Rows[0][1].ToString();
                string tem = dt1.Rows[0][2].ToString();
                this.txt_zxsj.Text = tem.Substring(0, 4) + "-" + tem.Substring(4, 2) + "-" + tem.Substring(6, 2) + " 至 " + tem.Substring(0, 4) + "-" + tem.Substring(8, 2) + "-" + tem.Substring(10, 2);
                this.txt_type.Text = dt1.Rows[0][3].ToString();
                this.txt_cjr.Text = dt1.Rows[0][6].ToString();
                this.txt_time.Text = dt1.Rows[0][7].ToString();
                this.txt_bz.Text = dt1.Rows[0][8].ToString();
                this.txt_fj.Text = dt1.Rows[0][9].ToString();

                if (this.kind == "年")
                {
                    //其下所以月计划量之和为计划量下限
                    String qStr2 = "select amount from MonthPlanning where planID = '" + this.id + "'";
                    SQLquery query2 = new SQLquery(qStr2);
                    DataTable dt2 = query2.doSelect();
                    if (dt2 != null)
                    {
                        this.totalMin = Convert.ToDouble(dt2.Rows[0][0].ToString());
                    }
                }
                else if (this.kind == "月")
                {
                    //其下所以月计划量之和为计划量下限
                    String qStr5 = "select amount from WeekPlanning where planID = '" + this.id + "'";
                    SQLquery query5 = new SQLquery(qStr5);
                    DataTable dt5 = query5.doSelect();
                    if (dt5 != null)
                    {
                        this.totalMin = Convert.ToDouble(dt5.Rows[0][0].ToString());
                    }

                    //对应年计划计划量减去此年计划下所有其他月计划量，为计划量上限
                    String qStr2 = "select amount from YearPlanning where ID = '" + dt1.Rows[0][10].ToString() + "'";
                    SQLquery query2 = new SQLquery(qStr2);
                    DataTable dt2 = query2.doSelect();
                    if (dt2 != null)
                    {
                        this.totalUp = Convert.ToDouble(dt2.Rows[0][0].ToString());
                    }

                    String qStr4 = "select ID,amount from MonthPlanning where planID = '" + dt1.Rows[0][10].ToString() + "'";
                    SQLquery query4 = new SQLquery(qStr4);
                    DataTable dt4 = query4.doSelect();
                    if (dt4 != null)
                    {
                        for (int i = 0; i < dt4.Rows.Count; i++)
                        {
                            if (this.id != dt4.Rows[i][0].ToString())
                            {
                                this.totalUp -= Convert.ToDouble(dt4.Rows[i][1].ToString());
                            }
                        }
                    }
                }
                else if (this.kind == "周")
                {
                    String qStr2 = "select amount from MonthPlanning where ID = '" + dt1.Rows[0][10].ToString() + "'";
                    SQLquery query2 = new SQLquery(qStr2);
                    DataTable dt2 = query2.doSelect();
                    if (dt2 != null)
                    {
                        this.totalUp = Convert.ToDouble(dt2.Rows[0][0].ToString());
                    }

                    String qStr4 = "select ID,amount from WeekPlanning where planID = '" + dt1.Rows[0][10].ToString() + "'";
                    SQLquery query4 = new SQLquery(qStr4);
                    DataTable dt4 = query4.doSelect();
                    if (dt4 != null)
                    {
                        for (int i = 0; i < dt4.Rows.Count; i++)
                        {
                            if (this.id != dt4.Rows[i][0].ToString())
                            {
                                this.totalUp -= Convert.ToDouble(dt4.Rows[i][1].ToString());
                            }
                        }
                    }
                }
            }

            String qs3 = "select * from PlanningDetail where planID = '" + this.id + "'";
            SQLquery q3 = new SQLquery(qs3);
            DataTable dt3 = q3.doSelect();
            if (dt3 != null)
            {
                for (int i = 0; i < dt3.Rows.Count; i++)
                {
                    this.dataGridView1.Rows.Add(dt3.Rows[i][0].ToString(), dt3.Rows[i][1].ToString(), dt3.Rows[i][2].ToString(),
                        dt3.Rows[i][3].ToString(), dt3.Rows[i][4].ToString(), dt3.Rows[i][5].ToString(), "删除", dt3.Rows[i][7].ToString());
                    hjtxt += Convert.ToDouble(dt3.Rows[i][5].ToString());
                }
            }
            this.txt_hj.Text = hjtxt.ToString("0.0");
            this.isLoad = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (this.txt_fhdw.Text == "" || this.txt_shdw.Text == "" || this.txt_shd.Text == "" || this.txt_jhl.Text == "")
            {
                MessageBox.Show("必填项(带*号)不能为空！", "提示");
            }
            else
            {
                if (!jhlValid(this.txt_jhl.Text))
                {
                    MessageBox.Show("输入计划量无效！", "错误");
                    this.txt_jhl.Text = "";
                    return;
                }

                this.txt_jhl.Text = Dtrim(this.txt_jhl.Text);

                string trans;
                if (this.rb_railway.Checked)
                {
                    trans = "铁路";
                }
                else if (this.rb_sea.Checked)
                {
                    trans = "海运";
                }
                else
                {
                    trans = "公路";
                }

                this.dataGridView1.Rows.Add(this.txt_fhdw.Text, trans, this.txt_shdw.Text, this.txt_shd.Text,
                    this.txt_fjdz.Text, this.txt_jhl.Text, "删除", "");
                hjtxt += Convert.ToDouble(this.txt_jhl.Text);
                this.txt_hj.Text = hjtxt.ToString("0.0");

                this.txt_fhdw.Text = "";
                this.txt_shdw.Text = "";
                this.txt_shd.Text = "";
                this.txt_jhl.Text = "";
                this.txt_fjdz.Text = "";
                this.rb_railway.Checked = true;
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            //判定计划量是否超出
            double tmpJHL = 0;
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                tmpJHL += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
            }
            if (this.kind == "年")
            {
                if ((totalMin * 10) > (tmpJHL * 10))
                {
                    MessageBox.Show("运输计划量低于其下月计划总量，请修改明细！", "错误");
                    return;
                }
            }
            else if (this.kind == "月")
            {
                if ((totalUp * 10) < (tmpJHL * 10))
                {
                    MessageBox.Show("运输计划量高于年计划剩余计划量，请修改明细！", "错误");
                    return;
                }
                if ((totalMin * 10) > (tmpJHL * 10))
                {
                    MessageBox.Show("运输计划量低于其下周计划总量，请修改明细！", "错误");
                    return;
                }
            }
            else if (this.kind == "周")
            {
                if ((totalUp * 10) < (tmpJHL * 10))
                {
                    MessageBox.Show("计划量不足，请修改明细！", "错误");
                    return;
                }
            }
            
            string fjhl = tmpJHL.ToString("0.0");
            
            bool b3 = false;
            bool b4 = false;
            //修改计划
            String qStr1 = "update " + knd + "Planning set amount = " + fjhl + ", creator = '" + this.txt_cjr.Text + "', remark = '" + this.txt_bz.Text
                + "', attachment = '" + this.txt_fj.Text + "' where ID = '" + id + "'";
            SQLquery query1 = new SQLquery(qStr1);
            bool b1 = query1.doModify();

            //删除计划明细
            String lid = "";
            for(int i = 0; i < ld.Count-1; i++)
            {
                lid += ("'" + ld[i] + "' or ID = ");
            }
            lid += ("'" + ld[ld.Count-1] + "'");
            String qStr2 = "delete from PlanningDetail where ID = " + lid;
            SQLquery query2 = new SQLquery(qStr2);
            bool b2 = query2.doModify();

            //修改计划明细
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                string itid = this.dataGridView1.Rows[i].Cells["_ID"].Value.ToString();
                if (lm.Contains(itid))
                {
                    String qStr4 = "update PlanningDetail set forwarding_unit = '" + this.dataGridView1.Rows[i].Cells[0].Value.ToString()
                        + "', transportation = '" + this.dataGridView1.Rows[i].Cells[1].Value.ToString() + "', consignee = '" +
                        this.dataGridView1.Rows[i].Cells[2].Value.ToString() + "', receiptPlace = '" + this.dataGridView1.Rows[i].Cells[3].Value.ToString()
                        + "', address = '" + this.dataGridView1.Rows[i].Cells[4].Value.ToString() + "', amount = " +
                        this.dataGridView1.Rows[i].Cells[5].Value.ToString() + " where ID = '" + itid + "'";
                    SQLquery query4 = new SQLquery(qStr4);
                    b4 = query4.doModify();
                }
            }

            //新增计划明细
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                if (this.dataGridView1.Rows[i].Cells["_ID"].Value.ToString() == "")
                {
                    String detail = "";
                    for (int j = 0; j < 5; j++)
                    {
                        detail += "'" + this.dataGridView1.Rows[i].Cells[j].Value + "',";
                    }
                    detail += this.dataGridView1.Rows[i].Cells[5].Value;
                    String qStr3 = "insert into PlanningDetail values(" + detail + ",'" + this.id + "')";
                    SQLquery query3 = new SQLquery(qStr3);
                    b3 = query3.doModify();
                }
            }

            if (b1 || b2 || b3 || b4)
            {
                MessageBox.Show("修改" + kind + "计划成功！", "提示");
            }
            else if (!b1 && !b2 && !b3 && !b4)
            {
                MessageBox.Show("未修改" + kind + "计划！", "提示");
            }
            else
            {
                MessageBox.Show("修改" + kind + "计划失败！", "提示");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                if (this.dataGridView1.Rows[e.RowIndex].Cells["_ID"].Value.ToString() != "")
                {
                    ld.Add(this.dataGridView1.Rows[e.RowIndex].Cells["_ID"].Value.ToString());
                }
                this.hjtxt -= Convert.ToDouble(this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                this.txt_hj.Text = hjtxt.ToString("0.0");
                this.dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!this.isLoad)
                return;

            if (e.ColumnIndex < 6)
            {
                if (e.ColumnIndex == 5)
                {
                    hjtxt = 0;
                    if (!jhlValid(this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ToString()))
                    {
                        MessageBox.Show("计划量更改无效，请重新输入！", "错误");
                        this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "0";
                        for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                        {
                            hjtxt += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                        }
                        this.txt_hj.Text = hjtxt.ToString("0.0");

                        return;
                    }
                    for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                    {
                        hjtxt += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                    }
                    this.txt_hj.Text = hjtxt.ToString("0.0");
                }
                MessageBox.Show(e.RowIndex.ToString());

                string s = this.dataGridView1.Rows[e.RowIndex].Cells["_ID"].Value.ToString();
                if (s != "" && !lm.Contains(s))
                {
                    lm.Add(s);
                }
            }
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

        private bool jhlValid(string s)
        {
            if (!isNum(s))
            {
                return false;
            }

            if (s.Length > 20)
            {
                MessageBox.Show("计划量过大！", "错误");
                return false;
            }

            long m = Convert.ToInt64(s);
            if (m < 0)
            {
                return false;
            }

            return true;
        }

        private string Dtrim(string s)
        {
            double n = Convert.ToDouble(s);
            string r = n.ToString("0.0");
            return r;
        }
    }
}
