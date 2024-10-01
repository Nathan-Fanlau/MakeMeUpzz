<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="HandleTransaction.aspx.cs" Inherits="MakeUpzz.Views.HandleTransaction" %>

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

        .transaction-table {
            width: 100%;
            border-collapse: collapse;
            font-size: 1.25rem;
            margin-top: 4rem;
        }

        .transaction-table th, .transaction-table td {
            padding: 10px;
            text-align: left;
            border: 1px solid #D8D2C2;
        }

        .transaction-table th {
            background-color: #0056b3;
            color: white;
        }

        .transaction-table tr:nth-child(even) {
            background-color: #dceafa;
        }

        .transaction-table tr:hover {
            background-color: #a8b1ba;
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

    </style>

    <h1>Handle Transaction</h1>
    <asp:GridView ID="TransactionGV" runat="server" AutoGenerateColumns="false"  CssClass="transaction-table">
        <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="TransactionID" SortExpression="TransactionID"></asp:BoundField>
            <asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID"></asp:BoundField>
            <asp:BoundField DataField="TransactionDate" HeaderText="Date" SortExpression="TransactionDate"></asp:BoundField>
            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="TransactionStatus"></asp:BoundField>


            <asp:TemplateField HeaderText="Action">
                <ItemTemplate>
                    <asp:Button ID="HandleButton" CssClass="button" runat="server" Text="Handle Transaction" CommandArgument='<%# Eval("TransactionID") %>' OnClick="HandleButton_Click" Visible='<%# Eval("Status").ToString() == "Unhandled" %>'/>
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
    </asp:GridView>
</asp:Content>
