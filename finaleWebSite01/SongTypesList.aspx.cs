using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SongTypeView : System.Web.UI.Page
{
    public string songtype;
    public int typeid = 1;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["logined"] != null)
        {
            try
            {
                typeid = int.Parse(Request.QueryString["typeid"].ToString());
            }
            catch { }
            string q = string.Format("select * from tbltype where typeid = {0};", typeid);
            DataSet ds = DbQ.ExecuteQuery(q);
            songtype = ds.Tables[0].Rows[0]["songtype"].ToString();
            string q1 = string.Format("select * from tblsongs where songtype = {0};", typeid);
            Repeater1.DataSource = DbQ.ExecuteQuery(q1);
            Repeater1.DataBind();
            
        }
        else
        {
            Response.Redirect("Default.aspx");

        }
    }
}