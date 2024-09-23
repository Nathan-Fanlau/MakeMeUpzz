<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionDetails.aspx.cs" Inherits="MakeUpzz.Views.TransactionDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Transaction Detail</h1>
    <asp:GridView ID="TransactionDetailGV" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="TransactionID" SortExpression="TransactionID"></asp:BoundField>
            <asp:BoundField DataField="MakeupID" HeaderText="MakeupID" SortExpression="MakeupID"></asp:BoundField>
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity"></asp:BoundField>
        </Columns>
    </asp:GridView>
</asp:Content>
