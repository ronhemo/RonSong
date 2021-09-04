using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminAddUpdate : System.Web.UI.Page
{
    public string songid;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["isadmin"] != null)
        {

        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }
}