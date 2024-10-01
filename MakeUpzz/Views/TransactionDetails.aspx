<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionDetails.aspx.cs" Inherits="MakeUpzz.Views.TransactionDetails" %>
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

            .table {
                width: 100%;
                border-collapse: collapse;
                font-size: 1.25rem;
                margin-top: 2rem;
            }

            .table th, .table td {
                padding: 10px;
                text-align: left;
                border: 1px solid #D8D2C2;
            }

            .table th {
                background-color: #0056b3;
                color: white;
            }

            .table tr:nth-child(even) {
                background-color: #dceafa;
            }

            .table tr:hover {
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

    <h1>Transaction Detail</h1>
    <asp:Button ID="backBtn" CssClass="button" runat="server" Text="Back" OnClick="backBtn_Click" />
    <asp:GridView ID="TransactionDetailGV" CssClass="table" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="TransactionID" SortExpression="TransactionID"></asp:BoundField>
            <asp:BoundField DataField="MakeupID" HeaderText="MakeupID" SortExpression="MakeupID"></asp:BoundField>
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity"></asp:BoundField>
        </Columns>
    </asp:GridView>
</asp:Content>
