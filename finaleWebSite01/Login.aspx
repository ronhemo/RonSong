<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="log-form">
        <div id="login">
            <div class="container">
                <div id="login-row" class="row justify-content-center align-items-center">
                    <div id="login-column" class="col-md-6">
                        <div id="login-box" class="col-md-12">
                            <form id="login-form" class="form" method="post">
                                <h3 class="text-center text-info"><u>Login</u></h3>
                                <div class="form-group">
                                    <asp:TextBox id="Email" runat="server" placeholder="Email" CssClass="form-control" required Text=""></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox id="password" runat="server" TextMode="Password" placeholder="Password" CssClass="form-control" required Text=""></asp:TextBox>                               
                                </div>
                                <div class="form-group">
                                    <asp:Button ID="Button1" runat="server" class="btn btn-info btn-md" Text="Login" OnClick="Button1_Click" />
                                </div>
                                <div id="register-link" class="text-right">
                                    <a href="Register.aspx" class="text-info">Register here</a>
                                </div>
                                <asp:Label style="color:red;" ID="error" runat="server"></asp:Label>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

