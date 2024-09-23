<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="OrderMakeup.aspx.cs" Inherits="MakeUpzz.Views.OrderMakeup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Order Makeup</h1>
    <asp:GridView ID="MakeupGV" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="MakeupName" HeaderText="Name" SortExpression="MakeupName" />
            <asp:BoundField DataField="MakeupPrice" HeaderText="Price" SortExpression="MakeupPrice" />
            <asp:BoundField DataField="MakeupWeight" HeaderText="Weight (grams)" SortExpression="MakeupWeight" />
            <asp:BoundField DataField="MakeupType.MakeupTypeName" HeaderText="Type" SortExpression="MakeupType.MakeupTypeName" />
            <asp:BoundField DataField="MakeupBrand.MakeupBrandName" HeaderText="Brand" SortExpression="MakeupBrand.MakeupBrandName" />
            <asp:TemplateField HeaderText="Quantity">
                <ItemTemplate>
                    <asp:TextBox ID="quantityTB" TextMode="Number" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Actions">
                <ItemTemplate>
                    <asp:Button ID="OrderButton" runat="server" Text="Order" CommandArgument='<%# Eval("MakeupID") %>' OnClick="OrderButton_Click" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Label ID="MessageLabel" runat="server" ForeColor="Red" />
    <br />
    <asp:Button ID="ClearCartButton" runat="server" Text="Clear Cart" CommandArgument='<%# Eval("CartID") %>' OnClick="ClearCartButton_Click" />
    <asp:Button ID="CheckoutButton" runat="server" Text="Checkout" OnClick="CheckoutButton_Click" />
</asp:Content>
