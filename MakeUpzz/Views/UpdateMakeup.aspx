<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="UpdateMakeup.aspx.cs" Inherits="MakeUpzz.Views.UpdateMakeup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Page</h1>
    <h1><%=Request.QueryString["id"] %></h1>
    <hr />
    <div>
        <asp:Label ID="NameLbl" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="NameTB" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="PriceLbl" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="PriceTB" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="WeightLbl" runat="server" Text="Weight"></asp:Label>
        <asp:TextBox ID="WeightTB" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="MakeUpTypeIdLbl" runat="server" Text="MakeUpTypeId"></asp:Label>
        <asp:DropDownList ID="MakeUpTypeDD" runat="server"></asp:DropDownList>
    </div>
    <div>
        <asp:Label ID="MakeUpBrandIdLbl" runat="server" Text="MakeUpBrandId"></asp:Label>
        <asp:DropDownList ID="MakeUpBrandDD" runat="server"></asp:DropDownList>
    </div>
    <div>
        <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click" />
        <asp:Button ID="BackBtn" runat="server" Text="Back" Onclick="BackBtn_Click"/>
    </div>
    <asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>
</asp:Content>
