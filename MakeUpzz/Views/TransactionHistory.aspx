<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="MakeUpzz.Views.TransactionHistory" %>

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

    .history-table {
        width: 100%;
        border-collapse: collapse;
        font-size: 1.25rem;
        margin-top: 4rem;
    }

    .history-table th, .history-table td {
        padding: 10px;
        text-align: left;
        border: 1px solid #D8D2C2;
    }

    .history-table th {
        background-color: #0056b3;
        color: white;
    }

    .history-table tr:nth-child(even) {
        background-color: #dceafa;
    }

    .history-table tr:hover {
        background-color: #a8b1ba;
    }

    .DetailButton {
        font-size: 1.25rem;
        padding: 10px 20px;
        background-color: #0056b3;
        color: white;
        border: 2px solid #0056b3;
        border-radius: 0.5rem;
        cursor: pointer;
        transition: background-color 0.3s ease, color 0.3s ease;
    }

    .DetailButton:hover {
        background-color: white;
        color: #0056b3;
        border: 2px solid #0056b3;
    }


</style>

    <h1>Transaction History</h1>
    <asp:GridView ID="TransactionGV" runat="server" AutoGenerateColumns="false"  CssClass="history-table">
        <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="TransactionID" SortExpression="TransactionID"></asp:BoundField>
            <asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID"></asp:BoundField>
            <asp:BoundField DataField="TransactionDate" HeaderText="Date" SortExpression="TransactionDate"></asp:BoundField>
            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="TransactionStatus"></asp:BoundField>


            <asp:TemplateField HeaderText="Transaction Detail">
                <ItemTemplate>
                    <asp:Button ID="DetailButton" CssClass="DetailButton" runat="server" Text="View Details" CommandArgument='<%# Eval("TransactionID") %>' OnClick="DetailButton_Click" />
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
    </asp:GridView>
</asp:Content>
