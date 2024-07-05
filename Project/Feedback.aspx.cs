using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Feedback : System.Web.UI.Page
    {
        Class1 objcls = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ins = "insert into Feedback_Tab values(" + Session["userid"] + ",'" + TextBox1.Text + "',Null,0) ";
            int i = objcls.FUN_NonQuery(ins);
            if (i == 1)
            {
                Label3.Text = "Inserted";
            }
        }
    }
    
}