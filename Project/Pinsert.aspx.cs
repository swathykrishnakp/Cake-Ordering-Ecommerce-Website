using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Project
{
    public partial class Pinsert : System.Web.UI.Page
    {
        Class1 objcls = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string seldr = "select cat_id,cat_name from Category_Tab";


                DataSet ds = objcls.fUN_Adapter(seldr);



                DropDownList1.DataSource = ds;

                DropDownList1.DataValueField = "cat_id";
                DropDownList1.DataTextField = "cat_name";
                DropDownList1.DataBind();

            }
        }
    

        protected void Button1_Click(object sender, EventArgs e)
        {
            String p = "~/phs/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            TextBox1.Text = DropDownList1.SelectedItem.Value;
            string ins = "insert into Product_Tab values('" + DropDownList1.SelectedItem.Value + "','" + TextBox2.Text + "'," + TextBox3.Text + ",'" + p + "','" + TextBox5.Text + "','" + TextBox6.Text + "',"+ TextBox7.Text +")";

            int i = objcls.FUN_NonQuery(ins);
            if (i == 1)
            {
                Label1.Text = "inserted";
            }
        }
    }
}