using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Text;


namespace Project
{
    public partial class Viewfeedback : System.Web.UI.Page
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
            string fb = "select  user_id,fb_msg from Feedback_Tab";

            DataSet ds = objcls.fUN_Adapter(fb);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }





        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow r = GridView1.Rows[e.NewSelectedIndex];

            TextBox4.Text = r.Cells[2].Text;
            //string sel = "select User_email from User_Tab where user_id=" + TextBox4.Text + "";
            string sel = "select User_email from User_Tab where user_id=" + TextBox4.Text + "";
            string sele = "select User_name from User_Tab where user_id=" + TextBox4.Text + "";
            TextBox5.Text = objcls.FUN_Scalar(sele);
            //string ema = objcls.FUN_Scalar(sel);
            TextBox1.Text = objcls.FUN_Scalar(sel);

        }




        protected void Button1_Click(object sender, EventArgs e)
        
            {
                string yourName = "Swathy"; // Your name or application name
                string yourGmailUserName = "swathyproject98@gmail.com"; // Your Gmail address
                string yourGmailPassword = "mrkx gfxy twda dvwa"; // Your Gmail password
                string toName = TextBox5.Text; // Recipient's name
                string toEmail = TextBox1.Text;  // Recipient's email address from the form
                string subject = TextBox2.Text; // Subject from the form
                string body = TextBox3.Text; // Message body from the form

                SendEmail2(yourName, yourGmailUserName, yourGmailPassword, toName, toEmail, subject, body);



            string upfeed = "update Feedback_Tab set  replay_msg='"+TextBox3.Text+"',fb_status=1 where user_id='"+TextBox4.Text+"'";
            int i = objcls.FUN_NonQuery(upfeed);
            if (i == 1)
            {
                Label1.Text = "Replayed";
            }


        }




        public static void SendEmail2(string yourName, string yourGmailUserName, string yourGmailPassword, string toName, string toEmail, string subject, string body)
            {
                string to = toEmail;
                string from = yourGmailUserName;
                MailMessage message = new MailMessage(from, to);

                string mailbody = body;
                message.Subject = subject;
                message.Body = mailbody;
                message.BodyEncoding = Encoding.UTF8;
                message.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); // Gmail SMTP
                System.Net.NetworkCredential basicCredential1 = new System.Net.NetworkCredential(yourGmailUserName, yourGmailPassword);
                client.EnableSsl = true;
                client.UseDefaultCredentials = true;
                client.Credentials = basicCredential1;
                try
                {
                    client.Send(message);
                }
                catch (Exception ex)
                {
                    throw ex;

                }



            }

        // protected void Button2_Click(object sender, EventArgs e)
        // {
        //string upfeed ="update Feedback_Tab set  replay_msg=TextBox3.Text,status=1 where user_id=TextBox4.Text";
        //     int i = objcls.FUN_NonQuery(upfeed);
        //     if (i == 1)
        //     {
        //         Label1.Text = "Updated";
        //     }

        // }


    }

}