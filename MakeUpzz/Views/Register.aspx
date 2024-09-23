<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="MakeUpzz.Views.Register" %>

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

        .register-btn {
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

        .register-btn:hover {
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
        <h1>Register Page</h1>
        <div class="form-group">
            <asp:Label ID="nameLbl" runat="server" CssClass="form-label" Text="Name "></asp:Label>
            <asp:TextBox ID="nameTB" runat="server" CssClass="form-input"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="emailLbl" runat="server" CssClass="form-label" Text="Email "></asp:Label>
            <asp:TextBox ID="emailTB" runat="server" CssClass="form-input"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="genderLbl" runat="server"  CssClass="form-label" Text="Gender"></asp:Label>
            <asp:RadioButtonList ID="genderList" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div class="form-group">
            <asp:Label ID="passwordLbl" runat="server" CssClass="form-label" Text="Password "></asp:Label>
            <asp:TextBox ID="passwordTB" runat="server" CssClass="form-input" TextMode="Password"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="confirmLbl" runat="server" CssClass="form-label" Text="Confirm Password "></asp:Label>
            <asp:TextBox ID="confirmTB" runat="server" CssClass="form-input" TextMode="Password"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="DOBLbl" runat="server" CssClass="form-label" Text="Date Of Birth "></asp:Label>
            <asp:Calendar ID="dobCalendar" runat="server"></asp:Calendar>
        </div>

        <asp:Button ID="RegisterButton" runat="server" CssClass="register-btn" Text="Register" OnClick="RegisterButton_Click" />
        
        <div class="text-center">
            <asp:HyperLink ID="LoginLink" runat="server" NavigateUrl="~/Views/Login.aspx" Text="Already have an account? Login Here!" />
        </div>
        
        <div class="error-label">
            <asp:Label ID="ErrorLbl" runat="server" CssClass="error-label" Text="" ForeColor="Red"></asp:Label>
        </div>
    </div>
</asp:Content>
