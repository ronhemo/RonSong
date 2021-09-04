<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SongView.aspx.cs" Inherits="SongVieww" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
    <title></title>
    <style>
        #log-form{
            padding-top:50px;
            padding-bottom:50px;
            background-color:#f3f3f3;
        }
        body {
             background-color:#303030;
        }
        font{
            font-Family:Arial;
            color:#f3f3f3;
        }
    </style>
</head>
<body>
    <div id="main" runat="server">
        <form id="form1" runat="server">
            <div style="text-align:right;" id="admins" runat="server">
                <asp:Button runat="server" CssClass="btn btn-danger" ID="DeleteSong" Text="Delete Song" OnClick="DeleteSong_Click"/>
                <asp:Button runat="server" CssClass="btn btn-warning" ID="UpdateSong" Text="Update Song" OnClick="UpdateSong_Click"/>
            </div>
            <center>
                <div class="card" style="width: 500px;">
                  <img src="<%=songpic %>" class="card-img-top" alt="..."/>
                  <div class="card-body">
                    <h5 class="card-title"><u><%=songname %> | <%=songsinger %></u></h5>
                    <p class="card-text"><%=songwords%></p>
                  </div>
                </div>
            </center>
        </form>
    </div>
    <div id="update" runat="server">
        <div style="text-align:right;">
            <a class="btn btn-secondary" href="SongView.aspx?songid=<%=id %>">Back</a>
        </div>
        <form runat="server">
            <center>
                <div id="log-form">
                    <div id="login">
                        <div class="container">
                            <div id="login-row" class="row justify-content-center align-items-center">
                                <div id="login-column" class="col-md-6">
                                    <div id="login-box" class="col-md-12">
                                        <h3 class="text-center text-info"><u>Update Song</u></h3>
                                        <u><asp:Label ID="lblSongid" runat="server" Text=""></asp:Label></u>
                                        <div class="form-group">
                                            Song Name: <asp:TextBox ID="SongName" runat="server" CssClass="form-control" required></asp:TextBox>
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
                                        Song Type:<br />
                                        <asp:RadioButtonList ID="SongList" runat="server" RepeatLayout="Flow">
                                        </asp:RadioButtonList>
                                        <br />
                                        <asp:Label style="color:red;" ID="error" runat="server"></asp:Label>
                                        <br />
                                        <asp:Button runat="server" id="BtnUpdate" CssClass="btn btn-success" Text="Edit Song" OnClick="SendEditSong_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </center>
        </form>
    </div>
</body>
</html>
