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
    public partial class 运输周计划录入 : Form
    {
        private string yid;
        private double total;
        private string kind;
        private double hjtxt;

        public 运输周计划录入(string yid, string kind)
        {
            this.yid = yid;
            this.kind = kind;

            InitializeComponent();
            this.skinEngine1.SkinFile = "WaveColor1.ssk";
        }

        private void 运输周计划录入_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AllowUserToAddRows = false; 
            this.Text = kind + "运输周计划录入";
            this.txt_time.Text = DateTime.Now.ToLocalTime().ToString("yyyy-MM-dd hh:mm:ss");
            this.rb_g.Checked = true;
            this.rb_railway.Checked = true;
            this.hjtxt = 0;
            this.txt_hj.Text = "0";

            for (int i = 1; i < 5; i++)
            {
                this.cb_zs.Items.Add(i.ToString());
            }

            //对应月计划计划量减去此月计划下所有周计划量，为此次录入可用计划量
            String qStr = "select company,date,amount from MonthPlanning where ID = '" + this.yid + "'";
            SQLquery query = new SQLquery(qStr);
            DataTable dt = query.doSelect();
            if (dt != null)
            {
                this.txt_cmp.Text = dt.Rows[0][0].ToString();
                this.txt_year.Text = dt.Rows[0][1].ToString().Substring(0, 4);
                this.txt_syue.Text = dt.Rows[0][1].ToString().Substring(4, 2);
                this.dateTimePicker1.Value = new DateTime(Convert.ToInt16(this.txt_year.Text), Convert.ToInt16(this.txt_syue.Text), 1);
                this.dateTimePicker2.Value = new DateTime(Convert.ToInt16(this.txt_year.Text), Convert.ToInt16(this.txt_syue.Text), 7);

                total = Convert.ToDouble(dt.Rows[0][2].ToString());
            }

            String qStr4 = "select amount from WeekPlanning where planID = '" + this.yid + "'";
            SQLquery query4 = new SQLquery(qStr4);
            DataTable dt4 = query4.doSelect();
            if (dt4 != null)
            {
                for (int i = 0; i < dt4.Rows.Count; i++)
                {
                    this.total -= Convert.ToDouble(dt4.Rows[i][0].ToString());
                }
            }
            MessageBox.Show("本月运输计划还剩余计划量" + this.total + "吨", "提示");
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

                double left = total * 10 - Convert.ToDouble(this.txt_jhl.Text) * 10;
                if (left < 0)
                {
                    MessageBox.Show("月剩余计划量已不足" + this.txt_jhl.Text + "吨！", "提示");
                    return;
                }

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
                    this.txt_fjdz.Text, this.txt_jhl.Text, "删除");
                this.total = left/10.0;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Rows.Count > 0 && e.ColumnIndex == 6)
            {
                this.hjtxt -= Convert.ToDouble(this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                this.txt_hj.Text = hjtxt.ToString("0.0");
                this.total += Convert.ToDouble(this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                this.dataGridView1.Rows.RemoveAt(e.RowIndex);
            }  
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count < 1 || this.txt_cmp.Text == "" || this.txt_year.Text == "" || this.cb_zs.Text == "")
            {
                MessageBox.Show("必填项(带*号)不能为空！", "提示");
                return;
            }

            int pdyear = Convert.ToInt16(this.txt_year.Text);
            int pdmonth = Convert.ToInt16(this.txt_syue.Text);
            if (this.dateTimePicker1.Value.Year != pdyear || this.dateTimePicker1.Value.Month != pdmonth)
            {
                MessageBox.Show("起始年月不在范围内！", "错误");
                return;
            }
            if (this.dateTimePicker2.Value.Year != pdyear || this.dateTimePicker2.Value.Month != pdmonth)
            {
                MessageBox.Show("结束年月不在范围内！", "错误");
                return;
            }

            if (this.dateTimePicker1.Value.Day >= this.dateTimePicker2.Value.Day)
            {
                MessageBox.Show("日期段异常！", "错误");
                return;
            }

            MessageBox.Show("数据已临时保存！", "提示");
            
        }

        private void btn_transmit_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count < 1 || this.txt_cmp.Text == "" || this.txt_year.Text == "" || this.cb_zs.Text == "")
            {
                MessageBox.Show("必填项(带*号)不能为空！", "提示");
            }
            else
            {
                //判断日期选择是否在范围内
                int pdyear = Convert.ToInt16(this.txt_year.Text);
                int pdmonth= Convert.ToInt16(this.txt_syue.Text);
                if (this.dateTimePicker1.Value.Year != pdyear || this.dateTimePicker1.Value.Month != pdmonth)
                {
                    MessageBox.Show("起始年月不在范围内！", "错误");
                    return;
                }

                if (this.dateTimePicker2.Value.Year != pdyear || this.dateTimePicker2.Value.Month != pdmonth)
                {
                    MessageBox.Show("结束年月不在范围内！", "错误");
                    return;
                }
                if (this.dateTimePicker1.Value.Day >= this.dateTimePicker2.Value.Day)
                {
                    MessageBox.Show("日期段异常！", "错误");
                    return;
                }

                int tag = 0;
                string type;
                if (this.rb_g.Checked)
                {
                    type = "普通";
                }
                else
                {
                    type = "追加";
                }
                double amount = 0;
                Guid u = System.Guid.NewGuid();
                string id = "Z-" + u;
                
                for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                {
                    String detail = "";
                    amount += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                    for (int j = 0; j < 5; j++)
                    {
                        detail += "'" + this.dataGridView1.Rows[i].Cells[j].Value.ToString() + "',";
                    }
                    detail += this.dataGridView1.Rows[i].Cells[5].Value.ToString();
                    String qStr = "insert into PlanningDetail values(" + detail + ",'" + id + "')";
                    SQLquery query = new SQLquery(qStr);
                    if (query.doModify())
                    {
                        if (i == this.dataGridView1.Rows.Count - 1)
                        {
                            tag += 1;
                            this.dataGridView1.Rows.Clear();
                        }
                    }
                }
                
                string statues;
                if (kind == "下达")
                {
                    statues = "未下达";
                }
                else
                {
                    statues = "新增";
                }

                string sday = this.dateTimePicker1.Value.Day.ToString();
                if (this.dateTimePicker1.Value.Day < 10)
                {
                    sday = "0" + sday;
                }
                string eday = this.dateTimePicker2.Value.Day.ToString();
                if (this.dateTimePicker1.Value.Day < 10)
                {
                    eday = "0" + eday;
                }
                

                string sj = this.txt_year.Text + this.txt_syue.Text + sday + this.txt_syue.Text + eday;
                String qStr1 = "insert into WeekPlanning values('" + id + "','" + this.txt_cmp.Text + "','" + sj
                        + "','" + type + "','" + statues + "'," + amount + ",'" + this.txt_cjr.Text + "','" + this.txt_time.Text + "','" + this.txt_bz.Text
                        + "','" + this.txt_fj.Text + "','" + this.yid + "',"+ this.cb_zs.Text +")";
                
                SQLquery query1 = new SQLquery(qStr1);
                if (query1.doModify())
                {
                    tag += 1;
                }

                if (tag == 2)
                {
                    MessageBox.Show("录入周计划成功！", "提示");
                    this.txt_cjr.Text = "系统管理员";
                    this.txt_bz.Text = "";
                    this.txt_fj.Text = "";
                    this.cb_zs.SelectedIndex = -1;
                    this.hjtxt = 0;
                    this.txt_hj.Text = "";
                    this.txt_time.Text = DateTime.Now.ToLocalTime().ToString("yyyy-MM-dd hh:mm:ss");
                    total -= amount;
                }
                else
                {
                    MessageBox.Show("录入周计划失败！", "提示");
                }
              
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_attach_Click(object sender, EventArgs e)
        {
            if (this.txt_fj.Text.Length > 1000)
            {
                MessageBox.Show("附件量已达上限！", "提示");
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "E:\\";
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
