<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SongTypes.aspx.cs" Inherits="SongsType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center style="color:floralwhite;"><i style="font-size:xx-large;" class="fas fa-compact-disc text-success"><u><font>Categorys</font></u></i></center><br />
    <asp:Repeater ID="Repeater1" runat="server" >
      
        <ItemTemplate>
          <center>
            <div class="card" style="width:400px">
                <img class="card-img-top" src="<%#Eval("typepic") %>" alt="Card image">
                <div class="card-body">
                <h4 class="card-title"><%#Eval("songtype") %></h4>
                <p class="card-text"><%#Eval("typeinfo") %></p>
                <a href="SongTypesList.aspx?typeid=<%#Eval("typeid")%>" class="btn btn-secondary">listen</a>
                </div>
            </div>
          </center>
        </ItemTemplate>
        <SeparatorTemplate>
            <br />
        </SeparatorTemplate>
    </asp:Repeater>
          </div>
</asp:Content>

