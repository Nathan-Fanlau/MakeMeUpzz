<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MakeUpzz.Views.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        * {
            font-family: Helvetica, sans-serif;
            font-size: 1rem;
        }

        .form-container {
            max-width: 500px;
            margin: 50px auto;
            padding: 20px;
            background-color: #f4f4f4;
            border-radius: 10px;
            box-shadow: 4px 4px 4px rgba(0, 0, 0, 0.1);
        }

        h1 {
            text-align: center;
            color: #333;
            margin-bottom: 20px;
            font-size: 1.2rem;
        }

        .form-group {
            margin-bottom: 15px;
        }

        .form-label {
            display: block;
            font-weight: bold;
            margin-bottom: 5px;
        }

        .form-input {
            width: 95%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }

        .login-btn {
            width: 100%;
            padding: 10px;
            background-color: #007bff;
            color: white;
            border: none;
            border-radius: 5px;
            font-size: 16px;
            font-weight: bold;
            cursor: pointer;
            margin-top: 20px;
        }

        .login-btn:hover {
            background-color: #0056b3;
        }

        .text-center {
            text-align: center;
            margin-top: 15px;
        }

        .error-label {
            color: red;
            text-align: center;
        }

    </style>

    <div class="form-container">
        <h1>Login Page</h1>
        <div class="form-group">
            <asp:Label runat="server" CssClass="form-label" Text="Username"></asp:Label>
            <asp:TextBox ID="nameTB" runat="server" CssClass="form-input"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="passwordLbl" runat="server" CssClass="form-label" Text="Password"></asp:Label>
            <asp:TextBox ID="passwordTB" runat="server" CssClass="form-input" TextMode="Password"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:CheckBox ID="termsCB" runat="server"></asp:CheckBox>
            <asp:Label runat="server" Text="Remember Me"></asp:Label>
        </div>
        <asp:Button ID="loginBtn" runat="server" CssClass="login-btn" Text="Login" OnClick="loginBtn_Click" />
        <div class="text-center">
            <asp:HyperLink ID="RegisterLink" runat="server" NavigateUrl="~/Views/Register.aspx" Text="Don't have an account? Register Here!" />
        </div>
        <div class="form-group">
            <asp:Label ID="ErrorLbl" runat="server" CssClass="error-label" Text="" ForeColor="Red"></asp:Label>
        </div>
    </div>
</asp:Content>
