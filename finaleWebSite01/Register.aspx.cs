using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    public bool IsEmailValid(string emailaddress)
    {
        try
        {
            MailAddress m = new MailAddress(emailaddress);
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try 
        {
            string uName = name.Text.Trim().ToString();
            string uLName = lName.Text.Trim().ToString();
            string uEmail = email.Text.Trim().ToString();
            string uPass = password.Text.Trim().ToString();
            bool isValid = IsEmailValid(uEmail);
            if (isValid == true)
            {
                int uid = -1;
                string s = string.Format("select * from tblusers where useremail = '{0}'", uEmail);
                DataSet ds = DbQ.ExecuteQuery(s);
                try
                {
                    uid = int.Parse(ds.Tables[0].Rows[0]["userid"].ToString());
                }
                catch { }
                if (uid > -1)
                {
                    error.Text = "err email already exists. try again.";
                }
                else
                {
                    string q = string.Format("insert into tblusers (fname, lname, useremail, userpassword) values('{0}', '{1}', '{2}', '{3}');", uName, uLName, uEmail, uPass);
                    DbQ.ExecuteNonQuery(q);
                    Session["uname"] = uName;
                    Session["isadmin"] = null;
                    Session["ulname"] = uLName;
                    Session["logined"] = 1;
                    Response.Redirect("Default.aspx");
                }
            }
            else
            {
                error.Text = "err email has to be in email form. try again.";
            }
        }
        catch { error.Text = "err something went wronge. try again."; }
    }
}