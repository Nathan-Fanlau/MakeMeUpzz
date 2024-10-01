<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="ManageMakeup.aspx.cs" Inherits="MakeUpzz.Views.ManageMakeup" %>

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

        h2 {
            text-align: center;
            font-size: 2rem;
        }

        .makeup-table {
            width: 100%;
            border-collapse: collapse;
            font-size: 1.25rem;
        }

        .makeup-table th, .makeup-table td {
            padding: 10px;
            text-align: left;
            border: 1px solid #D8D2C2;
        }

        .makeup-table th {
            background-color: #0056b3;
            color: white;
        }

        .makeup-table tr:nth-child(even) {
            background-color: #dceafa;
        }

        .makeup-table tr:hover {
            background-color: #a8b1ba;
        }

        .button-container {
            display: flex;
            justify-content: center;
            margin-bottom: 2.5rem;
        }

        .button {
            text-align: center;
            font-size: 1.25rem;
            padding: 10px 20px;
            background-color: #0056b3;
            color: white;
            border: 2px solid #0056b3;
            border-radius: 0.5rem;
            cursor: pointer;
            transition: background-color 0.3s ease, color 0.3s ease;
        }

        .button:hover {
            background-color: white;
            color: #0056b3;
            border: 2px solid #0056b3;
        }

        .command-btn {
            text-align: center;
            font-size: 1.25rem;
            padding: 5px 10px;
            background-color: #0056b3;
            color: white;
            border: 2px solid #0056b3;
            border-radius: 0.5rem;
            cursor: pointer;
            transition: background-color 0.3s ease, color 0.3s ease;
        }

        .command-btn:hover {
            background-color: white;
            color: #0056b3;
            border: 2px solid #0056b3;
        }
    </style>

    <h1>Manage Makeup Page</h1>
    <hr />
    <h2>Makeup</h2>
    <div>
        <asp:GridView ID="MangeMakeup" CssClass="makeup-table" runat="server" AutoGenerateColumns="False" OnRowDeleting="MangeMakeup_RowDeleting" OnRowEditing="MangeMakeup_RowEditing">
            <Columns>
                <asp:BoundField DataField="MakeupName" HeaderText="Name" SortExpression="MakeupName" />
                <asp:BoundField DataField="MakeupPrice" HeaderText="Price" SortExpression="MakeupPrice" />
                <asp:BoundField DataField="MakeupWeight" HeaderText="Weight (grams)" SortExpression="MakeupWeight" />
                <asp:BoundField DataField="MakeupType.MakeupTypeName" HeaderText="Type" SortExpression="MakeupType.MakeupTypeName" />
                <asp:BoundField DataField="MakeupBrand.MakeupBrandName" HeaderText="Brand" SortExpression="MakeupBrand.MakeupBrandName" />
                <asp:CommandField ControlStyle-CssClass="command-btn" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ButtonType="Button" ShowHeader="True" HeaderText="Action"></asp:CommandField>
            </Columns>
        </asp:GridView>
        <br />
        <div class="button-container">
            <asp:Button ID="InsertMakeupBtn" CssClass="button" runat="server" Text="Insert Makeup" OnClick="InsertMakeupBtnBtn_Click" />
        </div>
    </div>


    <hr />
    <h2>Makeup Type</h2>
    <div>
        <asp:GridView ID="MakeupTypeGV" CssClass="makeup-table" runat="server" AutoGenerateColumns="False" OnRowDeleting="MakeupTypeGV_RowDeleting" OnRowEditing="MakeupTypeGV_RowEditing">
            <Columns>
                <asp:BoundField DataField="MakeupTypeName" HeaderText="MakeupTypeName" SortExpression="MakeupTypeName" />
                <asp:CommandField ControlStyle-CssClass="command-btn" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ButtonType="Button" ShowHeader="True" HeaderText="Action"></asp:CommandField>
            </Columns>

        </asp:GridView>
        <br />
        <div class="button-container">
            <asp:Button ID="InsertTypeBtn" CssClass="button" runat="server" Text="Insert Makeup Type" OnClick="InsertTypeBtn_Click" />
        </div>
    </div>

    <hr />
    <h2>Makeup Brand</h2>
    <div>
        <asp:GridView ID="MakeupBrandGV" CssClass="makeup-table" runat="server" AutoGenerateColumns="False" OnRowDeleting="MakeupBrandGV_RowDeleting" OnRowEditing="MakeupBrandGV_RowEditing">
            <Columns>
                <asp:BoundField DataField="MakeupBrandName" HeaderText="MakeupBrandName" SortExpression="MakeupBrandName" />
                <asp:BoundField DataField="MakeupBrandRating" HeaderText="MakeupBrandRating" SortExpression="MakeupBrandRating" />
                <asp:CommandField ControlStyle-CssClass="command-btn" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ButtonType="Button" ShowHeader="True" HeaderText="Action"></asp:CommandField>
            </Columns>
        </asp:GridView>
        <br />
        <div class="button-container">
            <asp:Button ID="InsertBrandBtn" CssClass="button" runat="server" Text="Insert Makeup Brand" OnClick="InsertBrandBtn_Click" />
        </div>
    </div>
</asp:Content>
