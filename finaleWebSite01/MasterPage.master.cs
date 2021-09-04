using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["logined"] == null)
        {
            login.Visible = true;
            register.Visible = true;
            signOut.Visible = false;
            Songs.Visible = false;
            AdminPage.Visible = false;
        }
        else
        {
            login.Visible = false;
            register.Visible = false;
            signOut.Visible = true;
            Songs.Visible = true;
            if(Session["isadmin"] == null)
            {
                AdminPage.Visible = false;
            }
            else
            {
                AdminPage.Visible = true;
            }
        }
    }

    protected void signOut_Click(object sender, EventArgs e)
    {
        Session["logined"] = null;
        Response.Redirect("Default.aspx");
    }
}
