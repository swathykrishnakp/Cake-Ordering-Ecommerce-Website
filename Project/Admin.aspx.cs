using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Project
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Class1 obj = new Class1();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            string sel = "select max(reg_id) from Login_Tab1";
            string regidd = obj.FUN_Scalar(sel);
            int reg_id1 = 0;
            if (regidd == "")
            {
                reg_id1 = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(regidd);
                reg_id1 = newregid + 1;
            }
            string ins = "insert into Admin_Reg_Tab values(" + reg_id1 + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "'," + TextBox4.Text + ")";
            int i = obj.FUN_NonQuery(ins);
            if (i == 1)
            {
                string inslog = "insert into Login_Tab1 values(" + reg_id1 + ",'" + TextBox5.Text + "','" + TextBox6.Text + "','admin')";
                int j = obj.FUN_NonQuery(inslog);

            }


        }
    }
}