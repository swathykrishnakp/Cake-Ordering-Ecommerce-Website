using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Insert_Account : System.Web.UI.Page
    {
        Class1 objcls = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ins= "insert into Acc_Tab1 values(" + Session["userid"] + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";

            int i = objcls.FUN_NonQuery(ins);
            if (i == 1)
            {
                Label1.Text = "inserted";
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AccBal.aspx");
        }
    }
}