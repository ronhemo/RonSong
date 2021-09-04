using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SongsType : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string q = string.Format("select * from tbltype");
        Repeater1.DataSource = DbQ.ExecuteQuery(q);
        Repeater1.DataBind();
    }
}