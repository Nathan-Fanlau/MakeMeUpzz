<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="MakeUpzz.Views.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        * {
            font-family: Helvetica, sans-serif;
        }

        h2 {
            text-align: center;
            font-size: 2rem;
        }

        .profile-container {
            background-color: #f9f9f9;
            padding: 2rem;
            border-radius: 10px;
            max-width: 500px;
            margin: 2rem auto;
            box-shadow: 0 4px 10px rgba(0, 0, 0, 0.1);
        }

        .password-section {
            display: flex;
            flex-direction: column;
            gap: 1rem;
            background-color: #f1f1f1;
            padding: 2rem;
            border-radius: 10px;
            max-width: 500px;
            margin: 2rem auto;
            box-shadow: 0 4px 10px rgba(0, 0, 0, 0.1);
        }

        .form-group {
            margin-bottom: 1rem;
            display: flex;
            flex-direction: column;
            align-items: start;
        }

        .label {
            display: block;
            font-weight: bold;
            margin-bottom: 5px;
            font-size: 1.25rem;
        }

        .input {
            width: 95%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 5px;
            font-size: 1.25rem;
        }

        .update-button {
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

        .update-button:hover {
            background-color: #0056b3;
        }
        
    </style>

    <div class="profile-container">
        <h2>Update Profile</h2>
        <asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>
        <div class="form-group">
            <asp:Label ID="nameLbl" CssClass="label" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="nameTB" CssClass="input" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="emailLbl" CssClass="label" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="emailTB" CssClass="input" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="genderLbl" CssClass="label" runat="server" Text="Gender"></asp:Label>
            <asp:RadioButtonList ID="genderList" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div class="form-group">
            <asp:Label ID="DOBLbl" CssClass="label" runat="server" Text="Date Of Birth"></asp:Label>
            <asp:Calendar ID="dobCalendar" runat="server"></asp:Calendar>
        </div>
        <br />
        <asp:Button ID="UpdateProfileBtn" CssClass="update-button" runat="server" Text="Update Profile" OnClick="UpdateProfileBtn_Click" />
    </div>

    <div class="password-section">
        <h2>Change Password</h2>
        <asp:TextBox ID="OldPasswordTB" CssClass="input" runat="server" TextMode="Password" Placeholder="Old Password"></asp:TextBox>
        <asp:TextBox ID="NewPasswordTB" CssClass="input" runat="server" TextMode="Password" Placeholder="New Password"></asp:TextBox>
        <asp:Label ID="PwdErrorMsg" CssClass="label" runat="server" ForeColor="Red"></asp:Label>
        <asp:Button ID="UpdatePasswordBtn" CssClass="update-button" runat="server" Text="Update Password" OnClick="UpdatePasswordBtn_Click" />
    </div>
    <asp:Label ID="ErrorLbl2" runat="server" Text=""></asp:Label>
</asp:Content>
