using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Project
{
    public partial class userhome : System.Web.UI.Page
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
            string s1 = "select cat_id,cat_img,cat_name,cat_description from Category_Tab";

            DataSet ds = objcls.fUN_Adapter(s1);
            DataList2.DataSource = ds;
            DataList2.DataBind();

        }

        protected void DataList2_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "SelectCategory")
            {
                //string categoryId = e.CommandArgument.ToString();

                ////string sel = "select prod_image,prod_name,prod_prize,prod_description from Product_Tab where cat_id='"+categoryId+"'";
                int categoryId = Convert.ToInt32(e.CommandArgument);
                //string sel = "select prod_image,prod_name,prod_prize,prod_description from Product_Tab where cat_id="+categoryId+"";

                if (categoryId == Convert.ToInt32(e.CommandArgument))
                {

                    Session["uid"] = categoryId;
                    Response.Redirect("cat1_prod.aspx?cat_id=" + categoryId);


                }
               
            }


        }

        protected void ImageButton2_Command(object sender, CommandEventArgs e)
        {
            //    if (e.CommandName == "SelectCategory")
            //    {
            //        string categoryId = e.CommandArgument.ToString();

            //        ////string sel = "select prod_image,prod_name,prod_prize,prod_description from Product_Tab where cat_id='"+categoryId+"'";
            //        //int categoryId = Convert.ToInt32(e.CommandArgument);
            //        //string sel = "select prod_image,prod_name,prod_prize,prod_description from Product_Tab where cat_id="+categoryId+"";

            //        if (categoryId == "1")
            //        {

            //            Session["uid"] = categoryId;
            //            Response.Redirect("cat1_prod.aspx?cat_id=" + categoryId);


            //        }

            //        //        //DataSet ds1 = objcls.fUN_Adapter(sel);
            //        //        //DataList3.DataSource = ds1;
            //        //        //DataList3.DataBind();



            //    }
        }


    }
}
