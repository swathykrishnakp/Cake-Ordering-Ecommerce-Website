using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace Project
{
    public partial class ca2_prod : System.Web.UI.Page
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
            string s1 = "select prod_image,prod_name,prod_prize,prod_description from Product_Tab where prod_id=" + Session["pid"] + "";


            DataSet ds = objcls.fUN_Adapter(s1);
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "BackToUserPage")
            {
                // Redirect back to the user page
                Response.Redirect("userhome.aspx");
            }
            else if(e.CommandName== "AddToTheCart")
            {
                //int productID = Convert.ToInt32(e.CommandArgument);
                int productValue = 0;
                TextBox txtQuantity = (TextBox)(e.Item.FindControl("TextBox1"));
                
                string prp = "select prod_prize from Product_Tab where prod_id=" + Session["pid"] + "";
                string val = objcls.FUN_Scalar(prp);
                
            

           
                    // Convert the result to an integer
                    productValue = Convert.ToInt32(val);
                

                    
                //int quantity = Convert.ToInt32(txtQuantity);
                //int tp = Convert.ToInt32(txtQuantity.Text) * (val);
                int qu= int.Parse(txtQuantity.Text);

                int tp = qu * productValue;


                string sel = "select max(cart_id) from Cart_Tab";
                string carid = objcls.FUN_Scalar(sel);
                int car_id = 0;
                if (carid == "")
                {
                    car_id = 1;
                }
                else
                {
                    int newcarid = Convert.ToInt32(carid);
                    car_id = newcarid + 1;
                }
                string ins="insert into Cart_Tab Values("+car_id+"," + Session["userid"]  + "," + Session["pid"] + ","+ txtQuantity.Text+ ","+tp+")";
                int i = objcls.FUN_NonQuery(ins);
                if (i == 1)
                {
                    //Label6.Text = "inserted";
                    Response.Redirect("viewcart.aspx");
                }
            }
        }

        
    }
}