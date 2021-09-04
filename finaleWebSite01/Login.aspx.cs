using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
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
        int isAdmin = 0;
        string uEmail = Email.Text.ToString();
        string uPass = password.Text.ToString();
        string q = string.Format("select * from tblusers where useremail = '{0}' and userpassword = '{1}'", uEmail, uPass);
        bool isvalid = IsEmailValid(uEmail);
        if(isvalid == true)
        {
            try
            {

                DataSet ds = DbQ.ExecuteQuery(q);
                if (uEmail == ds.Tables[0].Rows[0]["useremail"].ToString() && uPass == ds.Tables[0].Rows[0]["userpassword"].ToString())
                {
                    Session["uname"] = ds.Tables[0].Rows[0]["fname"].ToString();
                    if (ds.Tables[0].Rows[0]["isadmin"].ToString() == "True")
                    {
                        isAdmin = 1;
                    }
                    else if (ds.Tables[0].Rows[0]["isadmin"].ToString() == "False")
                    {
                        isAdmin = 0;
                    }
                    if(isAdmin == 0)
                    {
                        Session["isadmin"] = null;
                    }
                    else
                    {
                        Session["isadmin"] = isAdmin;
                    }
                    Session["ulname"] = ds.Tables[0].Rows[0]["lname"].ToString();
                    Session["logined"] = 1;
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    string a = string.Format("select * from tblusers where useremail = {0} and userpassword = {1}", uEmail, uPass);
                    DataSet dss = DbQ.ExecuteQuery(a);
                }
            }
            catch { error.Text = "err something went wronge try again."; }
        }
        else
        {
            error.Text = "err email has to be in email form. try again.";
        }
    }
}