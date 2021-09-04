using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddCategory : System.Web.UI.Page
{
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

    protected void SendAdd_Click(object sender, EventArgs e)
    {
        string songtype = SongType.Text.Trim();
        string typeinfo = TypeInfo.Text.Trim();
        string typepic = TypePic.Text.Trim();
        string q = string.Format("insert into tbltype (songtype, typepic, typeinfo) VALUES('{0}', '{1}', '{2}');", songtype, typepic, typeinfo);
        DbQ.ExecuteNonQuery(q);
        Response.Redirect("Default.aspx");
    }
}