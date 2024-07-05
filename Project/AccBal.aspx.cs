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
    public partial class AccBal : System.Web.UI.Page
    {
        Class1 objcls = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AC_Service.ServiceClient ob = new AC_Service.ServiceClient();

            string bal = ob.Check_Balance(TextBox1.Text);

            Label1.Text = bal;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {


            int grand_total = 0;
            int amount = 0;



            //int new_balance = 0;
            string s1 = "SELECT SUM(total_price) FROM Order_Table WHERE user_id = " + Session["userid"] + "";

            //DataSet ds1 = objcls.fUN_Adapter(s1);
            //GridView2.DataSource = ds1;
            //GridView2.DataBind();
            string val = objcls.FUN_Scalar(s1);
            grand_total = Convert.ToInt32(val);
            string sel = "select bal_amount from Acc_Tab1 where user_id = " + Session["userid"] + " ";
            string ba = objcls.FUN_Scalar(sel);
            amount = Convert.ToInt32(ba);
            string new_balance = (amount - grand_total).ToString();
            if (amount > grand_total)
            {
                string up = "update Order_Table set order_status='Paid' where user_id=" + Session["userid"] + "";
                int i3 = objcls.FUN_NonQuery(up);
                if (i3 == 1)
                {
                    Label2.Text = "Amount Paid";
                }
                else
                {
                    Label3.Text = "failed";
                }
                string upacc = "update Acc_Tab1 set bal_amount='" + new_balance + "' where user_id=" + Session["userid"] + "";
                int i1 = objcls.FUN_NonQuery(upacc);
                if (i1 == 1)
                {
                    //Label3.Text = "updated";
                }












                string countp = "select count(prod_id) from Order_Table where user_id=" + Session["userid"] + "";
                string pcount = objcls.FUN_Scalar(countp);
                int n = Convert.ToInt32(pcount);
                for (int i = 0; i < n; i++)
                {

                    //string cor = "select  order_id from Order_Tab where user_id=" + Session["userid"] + "";

                    string cor = "select order_id from Order_Table where user_id=" + Session["userid"].ToString();

                    string oid = objcls.FUN_Scalar(cor);
                    int orderId = Convert.ToInt32(oid) + i;
                    Session["orid"] = oid;
                    string sep = "select prod_id,quantity from Order_Table where user_id=" + Session["userid"] + " and order_id= " + orderId;

                    SqlDataReader dr = objcls.FUN_Dtatareader(sep);
                    int prod_id = 0;
                    int quantity = 0;
                    while (dr.Read())
                    {
                        prod_id = (int)dr["prod_id"];
                        quantity = (int)dr["quantity"];
                    }

                    string p = "select prod_id from Order_Table where order_id=" + orderId;
                    string nwpd = objcls.FUN_Scalar(p);
                    Session["pd"] = nwpd;
                    string sta = "select prod_stock from Product_Tab where prod_id=" + Session["pd"] + "";
                    string pstock = objcls.FUN_Scalar(sta);
                    int oldstock = Convert.ToInt32(pstock);
                    //if (pstock == "0")
                        //{
                        //    string upstaus = "update Product_Tab set prod_status='Unavilable ' where prod_id=" + Session["pd"] + "";
                        //    int i5 = objcls.FUN_NonQuery(up);
                        //    if (i5 == 1)
                        //    {
                        //        Label6.Text = "Updated";
                        //    }

                        int prodquantity = Convert.ToInt32(quantity);
                    int newstock = Convert.ToInt32(oldstock - prodquantity);
                    string upstock = "update Product_Tab set prod_stock=" + newstock + " where prod_id=" + Session["pd"] + "";

                    int i2 = objcls.FUN_NonQuery(upstock);
                    if (i2 == 1)
                    {
                        Label5.Text = "updated";
                    }














                }

            }




            else
            {
                Label4.Text = "Insuffient Balance";
            }



            
                
            
        }
                protected void Button3_Click(object sender, EventArgs e)
                {
                    //string countp = "select count(prod_id) from Order_Tab2 where user_id=" + Session["userid"];
                    //string pcount = objcls.FUN_Scalar(countp);
                    //int n = Convert.ToInt32(pcount);

                    //for (int i = 1; i <= n; i++)
                    //{
                    //    string sep = "select prod_id, quantity from Order_Tab2 where user_id=" + Session["userid"];
                    //    SqlDataReader dr = objcls.FUN_Dtatareader(sep);

                    //    // Loop through all records for the current user
                    //    while (dr.Read())
                    //    {
                    //        int prod_id = (int)dr["prod_id"];
                    //        int quantity = (int)dr["quantity"];

                    //        string sta = "select prod_stock from Product_Tab where prod_id=" + prod_id;
                    //        string pstock = objcls.FUN_Scalar(sta);
                    //        int oldstock = Convert.ToInt32(pstock);

                    //        int prodquantity = Convert.ToInt32(quantity);
                    //        int newstock = oldstock - prodquantity;

                    //        string upstock = "update Product_Tab set prod_stock=" + newstock + " where prod_id=" + prod_id;

                    //        int i2 = objcls.FUN_NonQuery(upstock);
                    //        if (i2 == 1)
                    //        {
                    //            Label5.Text = "updated";
                    //        }
                    //    }
                    //     // Close the data reader after processing all records for the current user
                    //}



                    //string countp = "select count(prod_id) from Order_Table where user_id=" + Session["userid"];
                    //string pcount = objcls.FUN_Scalar(countp);
                    //int n = Convert.ToInt32(pcount);
                    //for (int i = 1; i <= n; i++)
                    //{
                    //    string sep = "select prod_id, quantity from Order_Table where user_id=" + Session["userid"];
                    //    SqlDataReader dr = objcls.FUN_Dtatareader(sep);
                    //    int prod_id = 0;
                    //    int quantity = 0;
                    //    // Loop through all records for the current user
                    //    while (dr.Read())
                    //    {
                    //        prod_id = (int)dr["prod_id"];
                    //        quantity = (int)dr["quantity"];
                    //    }

                    //    string sta = "select prod_stock from Product_Tab where prod_id=" + prod_id;
                    //    string pstock = objcls.FUN_Scalar(sta);
                    //    int oldstock = Convert.ToInt32(pstock);

                    //    int prodquantity = Convert.ToInt32(quantity);
                    //    int newstock = oldstock - prodquantity;

                    //    string upstock = "update Product_Tab set prod_stock=" + newstock + " where prod_id=" + prod_id;

                    //    int i2 = objcls.FUN_NonQuery(upstock);
                    //    if (i2 == 1)
                    //    {
                    //        Label5.Text = "updated";
                    //    }
                    //}




                }
            

        }
    }
  
