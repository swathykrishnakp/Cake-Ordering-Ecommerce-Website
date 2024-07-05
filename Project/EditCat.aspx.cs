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
    public partial class EditCat : System.Web.UI.Page
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
            string s = "select * from Category_Tab";
            DataSet ds = objcls.fUN_Adapter(s);


            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
       

       
        
        protected void GridView1_RowEditing1(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            grid_Bind();
        }

        protected void GridView1_RowUpdating1(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox txtdes = (TextBox)GridView1.Rows[i].Cells[5].Controls[0];
            TextBox txtsta = (TextBox)GridView1.Rows[i].Cells[6].Controls[0];
            string strupdate = "update Category_Tab set cat_description='" + txtdes.Text + "',cat_status='" + txtsta.Text + "' where cat_id=" + getid + "";
            int i1 = objcls.FUN_NonQuery(strupdate);
            GridView1.EditIndex = -1;
            grid_Bind();
        }

        protected void GridView1_RowCancelingEdit1(object sender, GridViewCancelEditEventArgs e)
        {
            {
                GridView1.EditIndex = -1;
                grid_Bind();
            }
        }
    }
}
    
