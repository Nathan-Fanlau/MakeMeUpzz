<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="MakeUpzz.Views.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        * {
            font-family: Helvetica, sans-serif;
        }

        .user-info {
            text-align: center;
            margin-top: 2rem;
        }
        .user-info .label {
            display: block;
            font-size: 1.5rem;
            font-weight: bold;
            color: #333;
            margin: 1rem 0;
        }
        .user-info #UserRoleLabel {
            font-size: 1.8rem;
            color: #007bff;
        }
        .user-info #UserNameLabel {
            font-size: 1.5rem;
            color: #444;
        }
        h1 {
            text-align: center;
            color: #007bff;
            margin-top: 1rem;
            font-size: 2.5rem;
        }

        .user-table {
            width: 100%;
            border-collapse: collapse;
            font-size: 1.5rem;
            margin-top: 4rem;
        }

        .user-table th, .user-table td {
            padding: 10px;
            text-align: left;
            border: 1px solid #D8D2C2;
        }

        .user-table th {
            background-color: #007bff;
            color: white;
        }

        .user-table tr:nth-child(even) {
            background-color: #dceafa;
        }

        .user-table tr:hover {
            background-color: #a8b1ba;
        }
    </style>

    <h1>Home Page</h1>
    <div class="user-info">
        <asp:Label ID="UserRoleLabel" runat="server" CssClass="label"></asp:Label>
        <asp:Label ID="UserNameLabel" runat="server" CssClass="label"></asp:Label>
    </div>
    <asp:GridView ID="CustomerGV" runat="server" AutoGenerateColumns="False" CssClass="user-table">
        <Columns>
            <asp:BoundField DataField="UserID" HeaderText="ID" SortExpression="UserID" />
            <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
            <asp:BoundField DataField="UserEmail" HeaderText="User Email" SortExpression="UserEmail" />
            <asp:BoundField DataField="UserDOB" HeaderText="User DOB" SortExpression="UserDOB" />
            <asp:BoundField DataField="UserGender" HeaderText="User Gender" SortExpression="UserGender" />
            <asp:BoundField DataField="UserRole" HeaderText="User Role" SortExpression="UserRole" />
            <asp:BoundField DataField="UserPassword" HeaderText="User Password" SortExpression="UserPassword" />
        </Columns>
    </asp:GridView>
</asp:Content>
