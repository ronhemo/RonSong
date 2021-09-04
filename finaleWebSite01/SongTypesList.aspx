<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SongTypesList.aspx.cs" Inherits="SongTypeView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <center>
            <center style="color:floralwhite;"><i style="font-size:xx-large;" class="fas fa-compact-disc text-success"><u><font><%=songtype %></font></u></i></center><br />
        <audio src="" controls id="audioPlayer">
            Sorry, your browser doesn't support html5!
        </audio>
    </center>
    <ul id="playlist" class="list-group">
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <li class="list-group-item d-flex justify-content-between align-items-center">
                    <a class="a fas fa-play" href="<%# Eval("location") %>">
                        <%# Eval("songname") %> | <%# Eval("songsinger") %>
                    </a>
                    <a class="btn btn-info" target="_blank" href="SongView.aspx?songid=<%# Eval("songid") %>">
                        more details
                    </a>
                </li>
            </ItemTemplate>
            <SeparatorTemplate>
            </SeparatorTemplate>
        </asp:Repeater>
    </ul>
    <div class="card"><center><a class="fas fa-backward" onclick="preTrack()"></a> &nbsp <a class="fas fa-forward" onclick="nextTrack()"></a></center></div>
    <script src="audioPlayer.js"></script>
    <script>

        //goes every 0.5 sec
        window.setInterval(function () {
            if (localStorage["update"] == "1") {
                localStorage["update"] = "0";
                location.reload();
            }
        }, 500);
    </script>
</asp:Content>

