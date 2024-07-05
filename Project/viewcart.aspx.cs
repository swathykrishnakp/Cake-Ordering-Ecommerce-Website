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
    public partial class viewcart : System.Web.UI.Page
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
            string s = "select * from Cart_Tab";
            DataSet ds = objcls.fUN_Adapter(s);


            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            grid_Bind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            //TextBox txtquantity = (TextBox)GridView1.Rows[i].Cells[5].Controls[0];

            //TextBox txtprize = (TextBox)GridView1.Rows[i].Cells[6].Controls[0];
            TextBox txtQuantity = (TextBox)GridView1.Rows[i].Cells[6].Controls[0];
            int qu = int.Parse(txtQuantity.Text);
            string prp = "select prod_prize from Product_Tab where prod_id=" + Session["pid"] + "";
            string val = objcls.FUN_Scalar(prp);




            // Convert the result to an integer
            int pv = Convert.ToInt32(val);
            int tp = qu * pv;

            string strupdate = "update Cart_Tab set quantity='" + txtQuantity.Text + "',total_price='" + tp + "' where cart_id=" + getid + "";
            int i1 = objcls.FUN_NonQuery(strupdate);
            GridView1.EditIndex = -1;
            grid_Bind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            {
                GridView1.EditIndex = -1;
                grid_Bind();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;// row index ,i=2..
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            string del = "delete from Cart_Tab where cart_id=" + getid + "";
            int i2 = objcls.FUN_NonQuery(del);
            grid_Bind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            {

                //int user_id = 0;
                //int prod_id = 0;
                //int quantity = 0;
                //int prize = 0;

                string sel = "select Max(cart_id) from Cart_Tab where user_id=" + Session["userid"] + "";
                string val1 = objcls.FUN_Scalar(sel);
                int n = Convert.ToInt32(val1);
                for (int i = 1; i <= n; i++)
                {
                    //string sep = "select * from Cart_Tab where cart_id='" + i + "'";
                    string se = "select * from Cart_Tab where user_id=" + Session["userid"] + "";
                    SqlDataReader dr = objcls.FUN_Dtatareader(se);
                    int user_id = 0;
                    int prod_id = 0;
                    int quantity = 0;
                    long total_price = 0;

                    while (dr.Read())
                    {
                        user_id = (int)dr["user_id"];
                        prod_id = (int)dr["prod_id"];
                        quantity = (int)dr["quantity"];
                        total_price = (long)dr["total_price"];




                    }
                    TextBox1.Text = DateTime.Now.ToLocalTime().ToString();
                    //string ins = "insert into Order_Tab1 values(" + user_id + "," + prod_id + "," + quantity + "," + total_price + ",'" + TextBox1.Text + "','" + TextBox2.Text + "')";
                    //string ins = "insert into Order_Tab1 values(" + user_id + "," + prod_id + "," + quantity + "," + total_price + ",'" + TextBox1.Text + "','  ordered ')";
                    string ins = "insert into Order_Table values(" + user_id + "," + prod_id + "," + quantity + "," + total_price + ",'" + TextBox1.Text + "','  ordered ')";

                    int i3 = objcls.FUN_NonQuery(ins);
                    if (i3 == 1)
                    {
                        Label1.Text = "inserted";
                    }

                    string del = "delete from Cart_Tab where Cart_id='" + i + "'";
                    int i4 = objcls.FUN_NonQuery(del);
                    if (i4 == 1)
                    {
                        Label2.Text = "Deleted";
                    }

                }
                string selbill = "select sum(total_price) from Order_Table where user_id=" + Session["userid"] + "";
                string billid = objcls.FUN_Scalar(selbill);
                int gt = Convert.ToInt32(billid);

                string ins1 = "insert into Bill_Table values('" + TextBox1.Text + "'," + Session["userid"] + " ," + gt + " )";
                int i5 = objcls.FUN_NonQuery(ins1);

                if (i5 == 1)
                {
                    Label3.Text = "added";
                }

            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewbill.aspx");
        }
    }
}