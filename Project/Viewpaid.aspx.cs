using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Project
{
    public partial class Viewpaid : System.Web.UI.Page
    {
        Class1 objcls = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string viewpaid = "select *  from Order_Table where order_status='Paid' ";

                DataSet ds = objcls.fUN_Adapter(viewpaid);
                GridView1.DataSource = ds;
                GridView1.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string uporder = "update Order_Table set order_status='Delivered 'where order_status='Paid' ";
            int i = objcls.FUN_NonQuery(uporder);
            if (i == 1)
            {
                Label1.Text = "Delivered";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
        //    string deleteQuery = "DELETE FROM Bill_Table WHERE user_id =  " + Session["userid"] + "";
        //    int j = objcls.FUN_NonQuery(deleteQuery);
        //    if (j == 1)
        //    {
        //        Label2.Text = "Deleted";
        //    }
        
        
        
        }

    }
}