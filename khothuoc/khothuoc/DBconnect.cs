using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace khothuoc
{
    class DBconnect
    {
        SqlConnection myConnection;
        string conStr = @"Data Source=ADMIN;Initial Catalog=QLT;Integrated Security=True";
        public DBconnect()
        {
            myConnection = new SqlConnection(conStr);
        }
        public SqlConnection connected()
        {
            return myConnection;
        }
        public DataTable getData(string sql)
        {
            SqlDataAdapter myDa = new SqlDataAdapter(sql, myConnection);
            DataTable myDt = new DataTable();
            myDa.Fill(myDt);
            return myDt;

        }

        public int check(string st)
        {
            string sql = "select COUNT(*) from USERS where TenDangNhap = '" + st + "'";
            SqlCommand cmd = new SqlCommand(sql, myConnection);
            int a = (int)cmd.ExecuteScalar();
            return a;
        }

        public void excute(string st)
        {
            SqlCommand cmd = new SqlCommand(st, myConnection);
            cmd.ExecuteNonQuery();
        }
    }
}
