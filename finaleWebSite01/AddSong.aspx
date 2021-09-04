<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddSong.aspx.cs" Inherits="AddSong" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <center>
            <div id="log-form">
                <div id="login">
                    <div class="container">
                        <div id="login-row" class="row justify-content-center align-items-center">
                            <div id="login-column" class="col-md-6">
                                <div id="login-box" class="col-md-12">
                                    <h3 runat="server" id="caption" class="text-center text-info"><u>Add Song</u></h3>
                                    <u><asp:Label ID="lblSongid" runat="server" Text=""></asp:Label></u>
                                    <div class="form-group">
                                        Song Name: <asp:TextBox runat="server" ID="SongName" CssClass="form-control" required></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        Song Singer: <asp:TextBox runat="server" ID="SongSinger" CssClass="form-control" required></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        Song lyrics: <asp:TextBox runat="server" ID="SongWords" CssClass="form-control" required></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        Song Pic Src: <asp:TextBox runat="server" ID="SongPic" CssClass="form-control" required></asp:TextBox>
                                    </div>
                                    <div runat="server" id="editnot">
                                        <asp:Label ID="lbl1" runat="server">File Type - mp3:</asp:Label><br />
                                        <div style="text-align:left;"><asp:FileUpload CssClass="" runat="server" ID="myUpload" accept=".mp3" /></div>
                                    </div>
                                    Song Type:<br />
                                    <asp:RadioButtonList ID="SongList" runat="server" RepeatLayout="Flow">

                                    </asp:RadioButtonList>
                                    <br />
                                    <asp:Label style="color:red;" ID="error" runat="server"></asp:Label>
                                    <br />
                                    <asp:Button runat="server" id="BtnAdd" CssClass="btn btn-success" Text="Add Song" OnClick="SendAddSong_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </center>
</asp:Content>

