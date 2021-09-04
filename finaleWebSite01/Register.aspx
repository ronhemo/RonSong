<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="log-form">
        <div id="login">
            <div class="container">
                <div id="login-row" class="row justify-content-center align-items-center">
                    <div id="login-column" class="col-md-6">
                        <div id="login-box" class="col-md-12">
                            <form id="login-form" class="form">
                                <h3 class="text-center text-info"><u>Register</u></h3>
                                <div class="form-group">
                                    <asp:TextBox id="name" runat="server" placeholder="Name" CssClass="form-control" required Text=""></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox id="lName" runat="server" placeholder="Last Name" CssClass="form-control" required Text=""></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox id="email" runat="server" placeholder="Email" CssClass="form-control" required Text=""></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox id="password" runat="server" TextMode="Password" placeholder="Password" CssClass="form-control" required Text=""></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Button ID="Button1" runat="server" class="btn btn-info btn-md" Text="submit" OnClick="Button1_Click" />
                                </div>
                                <div id="register-link" class="text-right">
                                    <a href="Login.aspx" class="text-info">Login here</a>
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

