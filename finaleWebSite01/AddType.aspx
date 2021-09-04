<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddType.aspx.cs" Inherits="AddCategory" %>

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
                                    <h3 runat="server" id="caption" class="text-center text-info"><u>Add Type</u></h3>
                                    <div class="form-group">
                                        Playlist Name: <asp:TextBox runat="server" ID="SongType" CssClass="form-control" required></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        info: <asp:TextBox runat="server" ID="TypeInfo" CssClass="form-control" required></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        Playlist Pic Src: <asp:TextBox runat="server" ID="TypePic" CssClass="form-control" required></asp:TextBox>
                                    </div>
                                    <asp:Label style="color:red;" ID="error" runat="server"></asp:Label>
                                    <br />
                                    <asp:Button runat="server" id="BtnAdd" CssClass="btn btn-success" Text="Add Type" OnClick="SendAdd_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </center>
</asp:Content>

