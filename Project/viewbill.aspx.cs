using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Project
{
    public partial class viewbill : System.Web.UI.Page
    {
        Class1 objcls = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
               
                //string sjoin = "select User_Tab.user_id,User_Tab.User_name,User_Tab.User_address,User_Tab.User_phone,Order_Tab.order_id,Order_Tab1.prod_id,Order_Tab1.Date,Order_Tab1.total_price,Bill_Tab.bill_id from User_Tab join Order_Tab1 on User_Tab.user_id=Order_Tab1.user_id join User_Tab.user_id =Bill_Tab.user_id";

                int grand_total = 0;
                // string sjoin = "SELECT  User_Tab.user_id,User_Tab.user_name, User_Tab.User_address, User_Tab.User_phone,Order_Tab1.order_id,  Order_Tab1.prod_id, Order_Tab1.Date,Order_Tab1.total_price,  Bill_Tab.bill_id  FROM User_Tab JOIN Order_Tab1 ON User_Tab.user_id = Order_Tab1.user_id JOIN Bill_Tab ON User_Tab.user_id = Bill_Tab.user_id";

                //string sjoin = "SELECT  User_Tab.user_id,User_Tab.user_name, Order_Tab2.order_id,  Order_Tab2.prod_id, Order_Tab2.Date,Order_Tab2.total_price,  Bill_Tab.bill_id  FROM User_Tab JOIN Order_Tab2 ON User_Tab.user_id = Order_Tab2.user_id JOIN Bill_Tab ON User_Tab.user_id = Bill_Tab.user_id where Order_Tab2.user_id=" + Session["userid"] + "";

                //////////string sjoin = "SELECT  Order_Table.user_id, Order_Table.order_id,  Order_Table.prod_id, Order_Table.Date,Order_Table.total_price,  Bill_Table.bill_id  FROM  Order_Table  JOIN Bill_Table ON Order_Table.user_id = Bill_Table.user_id   GROUP BY Order_Table.user_id, Order_Table.order_id,  Order_Table.prod_id,  Order_Table.Date, Order_Table.total_price,  Bill_Table.bill_id";


                //string sjoin= "SELECT  o.user_id,  o.prod_id,  o.Date,   o.total_price,   b.bill_id from(select user_id, order_id, prod_id,   Date, SUM(total_price) AS total_price   FROM Order_Tab2 where user_id=" + Session["userid"] + " GROUP BY   user_id, order_id, prod_id, Date) AS o JOIN  Bill_Tab AS b ON o.user_id = b.user_id";

                //string sjoin = "SELECT Order_Table.user_id, Order_Table.order_id, SUM(Order_Table.total_price) AS total_price " +
                //         "FROM Order_Table " +
                //         "JOIN Bill_Table ON Order_Table.user_id = Bill_Table.user_id " +
                //         "GROUP BY Order_Table.user_id, Order_Table.order_id";



                // string sjoin = "SELECT Order_Table.user_id, Order_Table.order_id, Order_Table.prod_id, SUM(Order_Table.total_price) AS total_price " +
                //"FROM Order_Table " +
                //"JOIN Bill_Table ON Order_Table.user_id = Bill_Table.user_id " +
                //"GROUP BY Order_Table.user_id, Order_Table.order_id, Order_Table.prod_id";



                // string sjoin = "SELECT Order_Table.user_id, Order_Table.order_id, Order_Table.prod_id, Order_Table.total_price " +
                //"FROM Order_Table " +
                //"JOIN Bill_Table ON Order_Table.user_id = Bill_Table.user_id " +
                //"GROUP BY Order_Table.user_id, Order_Table.order_id, Order_Table.prod_id, Order_Table.total_price";






                // string sjoin = "SELECT Order_Table.user_id, Order_Table.order_id, Order_Table.prod_id, Order_Table.total_price " +
                //"FROM Order_Table " +
                //"JOIN Bill_Table ON Order_Table.user_id = Bill_Table.user_id " +
                //"WHERE Order_Table.user_id =" + Session["userid"] + " " +
                //"GROUP BY Order_Table.user_id, Order_Table.order_id, Order_Table.prod_id, Order_Table.total_price";



                string sjoin = "SELECT Order_Table.user_id, User_Tab.user_name, Order_Table.order_id, Order_Table.prod_id, Order_Table.total_price " +
               "FROM Order_Table " +
               "JOIN Bill_Table ON Order_Table.user_id = Bill_Table.user_id " +
               "JOIN User_Tab ON Order_Table.user_id = User_Tab.user_id " +
               "WHERE Order_Table.user_id = '" + Session["userid"] + "' " +
               "GROUP BY Order_Table.user_id, User_Tab.user_name, Order_Table.order_id, Order_Table.prod_id, Order_Table.total_price";











                DataSet ds = objcls.fUN_Adapter(sjoin);
                GridView1.DataSource = ds;
                GridView1.DataBind();
                //string s = "select  user_id,bill_id from Bill_Tab";
                //string s1 = "SELECT SUM(total_price) FROM Order_Tab1 WHERE user_id = " + Session["userid"] + "";
                string s1 = "SELECT SUM(total_price) FROM Order_Table WHERE user_id = " + Session["userid"] + "";

               
                string val = objcls.FUN_Scalar(s1);
                grand_total= Convert.ToInt32(val);
                TextBox1.Text = grand_total.ToString();




            }




        }


        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Insert_Account.aspx");
        }

       
    }
    }
