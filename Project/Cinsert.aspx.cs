using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Project
{
    public partial class Cinsert : System.Web.UI.Page
    {
        Class1 objcls = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/photo/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string ins = "insert into Category_Tab values('" + TextBox1.Text + "','" + p+ "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
            int i = objcls.FUN_NonQuery(ins);
            if (i == 1)
            {
                Label1.Text = "inserted";
            }
        }

        
        

    }

}