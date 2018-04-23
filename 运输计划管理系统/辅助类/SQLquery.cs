using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace 运输计划管理系统
{
    public class SQLquery
    {
        public string conStr;
        String qStr;
        public SQLquery(String s)
        {
            conStr = @"Data Source=Sherry-PC;Initial Catalog=TransportPlanning;Integrated Security=True";
            qStr = s;
        }

        public DataTable doSelect()
        {
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                con.Open();
            }
            catch
            {
                return null;

            }
            SqlCommand cmd = new SqlCommand(qStr, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            
            if (dt.Rows.Count == 0)
            {
                dr.Close();
                con.Close();
                return null;
            }

            dr.Close();
            con.Close();
            return dt;
        }

        public bool doModify()
        {
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                con.Open();
            }
            catch
            {
                return false;

            }
            SqlCommand sql = new SqlCommand(qStr, con);
            sql.ExecuteNonQuery();
            con.Close();
            return true;
        }
    }
}
