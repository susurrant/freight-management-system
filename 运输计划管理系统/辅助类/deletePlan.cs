using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 运输计划管理系统
{
    class deletePlan
    {
        private string id;
        private string kind;
        public deletePlan(string id, string kind)
        {
            this.id = id;
            this.kind = kind;
        }

        public bool doDelete()
        {
            if (deleteP() && deleteDDL() && deleteJHMX() && deleteSPD())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool deleteP()
        {
            //删除计划
            String qStr = "delete from " + kind + "Planning where ID = '" + id + "'";
            SQLquery query = new SQLquery(qStr);
            bool b = query.doModify();

            if (b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool deleteDDL()
        {
            //删除对应调度令
            String qStr2 = "delete from Schedule where planID = '" + id + "'";
            SQLquery query2 = new SQLquery(qStr2);
            bool b2 = query2.doModify();

            if (b2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool deleteJHMX()
        {
            //删除对应计划明细
            String qStr1 = "delete from PlanningDetail where planID = '" + id + "'";
            SQLquery query1 = new SQLquery(qStr1);
            bool b1 = query1.doModify();
            if (b1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool deleteSPD()
        {
            String qStr3 = "delete from Approval where planID = '" + id + "'";
            SQLquery query3 = new SQLquery(qStr3);
            bool b3 = query3.doModify();
            if (b3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
