<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="AdminAddUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <center style="color:floralwhite;"><i style="font-size:xx-large;" class="fas fa-compact-disc text-success"><u><font>Admin Page</font></u></i></center><br />
        <br />
        <a runat="server" Class="btn btn-success" ID="AddSong" href="AddSong.aspx">Add Song</a>
        <br />
        <br />
        <a runat="server" Class="btn btn-success" ID="AddType" href="AddType.aspx">Create Playlist</a>
</asp:Content>

