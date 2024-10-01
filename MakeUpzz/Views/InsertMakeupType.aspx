<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="InsertMakeupType.aspx.cs" Inherits="MakeUpzz.Views.InsertMakeupType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        * {
            font-family: Helvetica, sans-serif;
        }

        h1 {
            text-align: center;
            color: #0056b3;
            margin-top: 1rem;
            font-size: 2.5rem;
        }

        .form-container {
            background-color: #f9f9f9;
            padding: 2rem;
            border-radius: 10px;
            max-width: 500px;
            margin: 2rem auto;
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
            border: 2px solid #ccc;
            border-radius: 5px;
            font-size: 1.25rem;
        }

        .button {
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

            .button:hover {
                background-color: #0056b3;
            }
    </style>

    <h1>Insert MakeupType Page</h1>

    <div class="form-container">
        <div class="form-group">
            <asp:Label ID="nameLbl" CssClass="label" runat="server" Text="Name : "></asp:Label>
            <asp:TextBox ID="nameTB" CssClass="input" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="insertBtn" CssClass="button" runat="server" Text="Insert" OnClick="insertBtn_Click" />
            <asp:Button ID="backBtn" CssClass="button" runat="server" Text="Back" OnClick="backBtn_Click" />
        </div>
        <asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
