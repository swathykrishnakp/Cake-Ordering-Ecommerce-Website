using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	

	SqlConnection con = new SqlConnection(@"server=LAPTOP-3CFR6UM5\SQLEXPRESS;database=PROJECTDB1;integrated Security=True");
	
	
	public int Check_Balance(int accno)
    {
		string str= "select bal_amount from Acc_Tab where acc_num="+accno+"";
		SqlCommand cmd = new SqlCommand(str, con);
		con.Open();
		SqlDataReader dr=cmd.ExecuteReader();
		int bal = 0;
        while (dr.Read())
        {
			bal = (int)dr["bal_amount"];
        }
		con.Close();
		return bal;
	}




	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}
}
