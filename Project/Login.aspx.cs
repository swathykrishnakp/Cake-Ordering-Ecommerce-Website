using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Project
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        Class1 ob = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
            }
        
    }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "select count(reg_id) from Login_Tab1 where log_username='" + TextBox1.Text + "' and log_Password='" + TextBox2.Text + "'";
            string cid = ob.FUN_Scalar(str);
            int cid1 = Convert.ToInt32(cid);
            if (cid1 == 1)
            {
                string str1 = "select reg_id from Login_Tab1 where log_username='" + TextBox1.Text + "' and log_password='" + TextBox2.Text + "'";
                string regid1 = ob.FUN_Scalar(str1);
                Session["userid"] = regid1;
                string str2 = "select log_type from Login_Tab1 where log_username='" + TextBox1.Text + "' and log_password='" + TextBox2.Text + "'";
                string logtype = ob.FUN_Scalar(str2);
                if (logtype == "admin")
                {
                    //Label3.Text = "Admin";
                    Response.Redirect("adminhome.aspx");
                }
                else if (logtype == "user")
                {
                    //Label3.Text = "User";
                    Response.Redirect("userhome.aspx");
                }
            }
            else
            {
                Label3.Text = "Invalid Username and Password";
            }
        }
    }
}