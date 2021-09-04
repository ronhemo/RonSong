<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content >
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container"></div>
    <center style="color:floralwhite;"><i style="font-size:xx-large;" class="fas fa-compact-disc text-success"><u><font>RonSong</font></u></i></center><br />
    <center style="color:floralwhite;"><asp:Label ID="info" runat="server" Text=""></asp:Label></center>
    <div class="jumbotron">
        <div class="row">
            <div class="col-sm-4 text-center">
                creator:<div class="text-muted">Ron Hemo</div><br />
            </div>
            <div class="col-sm-4 text-center">
                Phone:<div class="text-muted">0547422614</div><br />
            </div>
            <div class="col-sm-4 text-center">
                Email:<div class="text-muted">ronhemo050@gmail.com</div><br />
            </div>
        </div>
    </div>
</asp:Content>