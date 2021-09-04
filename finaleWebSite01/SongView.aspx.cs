using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SongVieww : System.Web.UI.Page
{
    public string songname, songsinger, songwords, songpic, location, songid;
    public int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["logined"] != null)
        {
            main.Visible = true;
            update.Visible = false;
            int songid = 1;
            if (Session["isadmin"] == null)
            {
                admins.Visible = false;
            }
            else
            {
                admins.Visible = true;
            }
            try
            {
                songid = int.Parse(Request.QueryString["songid"].ToString());
            }
            catch { }
            string q = string.Format("select * from tblsongs where songid = {0}", songid);
            DataSet ds = DbQ.ExecuteQuery(q);
            id = int.Parse(ds.Tables[0].Rows[0]["songid"].ToString());
            songname = ds.Tables[0].Rows[0]["songname"].ToString();
            songsinger = ds.Tables[0].Rows[0]["songsinger"].ToString();
            songwords = ds.Tables[0].Rows[0]["songwords"].ToString();
            songpic = ds.Tables[0].Rows[0]["songpic"].ToString();
            location = ds.Tables[0].Rows[0]["location"].ToString();
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }

    protected void DeleteSong_Click(object sender, EventArgs e)
    {
        try
        {
            string q = string.Format("delete * from tblsongs where songid = {0};", id);
            DbQ.ExecuteNonQuery(q);
            Response.Write("<script>window.close(); localStorage.setItem('update', '1');</script>");
            //remove the song from Songs
            File.Delete(Server.MapPath(location));
            FileInfo fInfoEvent;
            fInfoEvent = new FileInfo(location);
            fInfoEvent.Delete();
        }
        catch
        {
            error.Text = "something went wronge";
        }
    }

    protected void UpdateSong_Click(object sender, EventArgs e)
    {
        main.Visible = false;
        update.Visible = true;
        string q = string.Format("select * from tbltype");
        DataSet ds1 = DbQ.ExecuteQuery(q);
        for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
        {
            SongList.Items.Add(new ListItem(ds1.Tables[0].Rows[i]["songtype"].ToString(), ds1.Tables[0].Rows[i]["songtype"].ToString()));
        }
        try
        {
            songid = Request.QueryString["songid"].ToString();
            string a = string.Format("select * from tblsongs where songid={0}", songid);
            DataSet ds = DbQ.ExecuteQuery(a);
            lblSongid.Text = "ID: " + songid;
            SongName.Text = ds.Tables[0].Rows[0]["songname"].ToString();
            SongSinger.Text = ds.Tables[0].Rows[0]["songsinger"].ToString();
            string SsongWords = ds.Tables[0].Rows[0]["songwords"].ToString();
            SongWords.Text = SsongWords.Replace("<br/>", ". ");
            SongPic.Text = ds.Tables[0].Rows[0]["songpic"].ToString();
            int type = int.Parse(ds.Tables[0].Rows[0]["songtype"].ToString());
            string q1 = string.Format("select * from tbltype where typeid = {0};", type);
            DataSet dss = DbQ.ExecuteQuery(q1);
            string songtype = dss.Tables[0].Rows[0]["songtype"].ToString();
            SongList.SelectedValue = songtype;
            lblSongid.Visible = true;

        }
        catch {error.Text="err try again..."; }
    }

    protected void SendEditSong_Click(object sender, EventArgs e)
    {
        string songname = SongName.Text.Trim();
        string songsinger = SongSinger.Text.Trim();
        string songwords = SongWords.Text.Trim();
        songwords = songwords.Replace("'", "");
        songwords = songwords.Replace(". ", "<br/>");
        string songpic = SongPic.Text.Trim();
        string songtype = SongList.SelectedValue;
        string q1 = string.Format("select * from tbltype where songtype = '{0}';", songtype);
        DataSet ds = DbQ.ExecuteQuery(q1);
        int type = int.Parse(ds.Tables[0].Rows[0]["typeid"].ToString());
        string q = string.Format("update tblsongs set songname = '{0}', songsinger = '{1}', songwords = '{2}', songpic = '{3}',songtype = {4} where songid = {5};", songname, songsinger, songwords, songpic, type, id);
        DbQ.ExecuteNonQuery(q);
        Response.Write("<script>window.close(); localStorage.setItem('update', '1');</script>");
    }
}