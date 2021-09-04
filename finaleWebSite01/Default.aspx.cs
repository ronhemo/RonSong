using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["logined"] != null)
        {
            string admin = "";
            if (Session["isadmin"] == null)
            {
                admin = "member";
            }
            else
            {
                admin = "admin";
            }
            info.Text = string.Format("welcome {0} {1} {2}.", admin, Session["uname"].ToString(), Session["ulname"].ToString());
        }
    }
}