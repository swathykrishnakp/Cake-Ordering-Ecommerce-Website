using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace Project
{
    public class Class1
    {

        SqlCommand cmd;
        SqlConnection con;

        public Class1()
        {
            con = new SqlConnection(@"server =LAPTOP-3CFR6UM5\SQLEXPRESS; database = PROJECTDB1; integrated Security = True");

        }


        //public int FUN_NonQuery(string sql)
        //{

        //    cmd = new SqlCommand(sql, con);
        //    con.Open();
        //    int i = cmd.ExecuteNonQuery();
        //    con.Close();
        //    return i;

        //}
        //public string FUN_Scalar(string sql)
        //{

        //    cmd = new SqlCommand(sql, con);
        //    con.Open();
        //    string s = cmd.ExecuteScalar().ToString();
        //    con.Close();
        //    return s;
        //}
        public int FUN_NonQuery(string sqlquery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;

        }
        public string FUN_Scalar(string sqlquery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            string s = cmd.ExecuteScalar().ToString();
            con.Close();
            return s;
        }
        public SqlDataReader FUN_Dtatareader(string sqlquery)
        {
            if (con.State == ConnectionState.Open)

            {
                con.Close();

            }
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;

        }
        public DataSet fUN_Adapter(string sqlquery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataTable FUN_Datatable(string sqlquery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}