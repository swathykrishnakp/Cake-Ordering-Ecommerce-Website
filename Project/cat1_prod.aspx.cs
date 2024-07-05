using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Project
{
    public partial class cat1_prod : System.Web.UI.Page
    {
        Class1 objcls = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                grid_Bind();
            }
        }
        public void grid_Bind()
        {
            //string s1 = "select prod_image,prod_name,prod_prize,prod_description from Product_Tab";
            string s1 = "select  prod_id,prod_image,prod_name,prod_prize,prod_description from Product_Tab where cat_id="+Session["uid"]+"";


            DataSet ds = objcls.fUN_Adapter(s1);
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "SelectProduct")
            {
                //string categoryId = e.CommandArgument.ToString();

                ////string sel = "select prod_image,prod_name,prod_prize,prod_description from Product_Tab where cat_id='"+categoryId+"'";
                int productId = Convert.ToInt32(e.CommandArgument);
                //string sel = "select prod_image,prod_name,prod_prize,prod_description from Product_Tab where cat_id="+categoryId+"";

                if (productId == Convert.ToInt32(e.CommandArgument))
                {

                    Session["pid"] = productId;
                    Response.Redirect("ca2_prod.aspx?cat_id=" + productId);


                }

            }
        }
    }
    
}