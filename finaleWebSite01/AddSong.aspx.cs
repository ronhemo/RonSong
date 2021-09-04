using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddSong : System.Web.UI.Page
{
    public string songid;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["isadmin"] != null)
        {      
            string q = string.Format("select * from tbltype");
            DataSet ds = DbQ.ExecuteQuery(q);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                SongList.Items.Add(new ListItem(ds.Tables[0].Rows[i]["songtype"].ToString(), ds.Tables[0].Rows[i]["songtype"].ToString()));
            }
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }
    protected void SendAddSong_Click(object sender, EventArgs e)
    {
        if (myUpload.HasFile)
        {
            if (SongList.SelectedIndex > -1)
            {
                string songname = SongName.Text.Trim();
                string songsinger = SongSinger.Text.Trim();
                string songwords = SongWords.Text.Trim();
                songwords = songwords.Replace("'", "");
                songwords = songwords.Replace(". ", "<br/>");
                string location = "Songs//" + myUpload.FileName;
                string songpic = SongPic.Text.Trim();
                string songtype = SongList.SelectedValue.ToString();
                string q1 = string.Format("select * from tbltype where songtype = '{0}';", songtype);
                DataSet ds = DbQ.ExecuteQuery(q1);
                int type = int.Parse(ds.Tables[0].Rows[0]["typeid"].ToString());
                myUpload.PostedFile.SaveAs(Server.MapPath("~/Songs/" + myUpload.FileName));
                string q = string.Format("insert into tblsongs (songname, songsinger, songwords, location, songpic, songtype) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', {5});", songname, songsinger, songwords, location, songpic, type);
                DbQ.ExecuteNonQuery(q);
                Response.Redirect("Default.aspx");
            }
            else
            {
                error.Text = "you must pick a song type.";
            }
        }
        else
        {
            error.Text = "you need to upload a song.";
        }
    }
}