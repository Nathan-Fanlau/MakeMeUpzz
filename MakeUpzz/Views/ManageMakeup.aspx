<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="ManageMakeup.aspx.cs" Inherits="MakeUpzz.Views.ManageMakeup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Manage Page</h1>
    <hr />
    <h1>Makeup</h1>
    <div>
        <asp:GridView ID="MangeMakeup" runat="server" AutoGenerateColumns="False" OnRowDeleting="MangeMakeup_RowDeleting" OnRowEditing="MangeMakeup_RowEditing">
            <Columns>
                <asp:BoundField DataField="MakeupName" HeaderText="Name" SortExpression="MakeupName" />
                <asp:BoundField DataField="MakeupPrice" HeaderText="Price" SortExpression="MakeupPrice" />
                <asp:BoundField DataField="MakeupWeight" HeaderText="Weight (grams)" SortExpression="MakeupWeight" />
                <asp:BoundField DataField="MakeupType.MakeupTypeName" HeaderText="Type" SortExpression="MakeupType.MakeupTypeName" />
                <asp:BoundField DataField="MakeupBrand.MakeupBrandName" HeaderText="Brand" SortExpression="MakeupBrand.MakeupBrandName" />
                <asp:CommandField ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ButtonType="Button" ShowHeader="True" HeaderText="Action"></asp:CommandField>
            </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="InsertMakeupBtn" runat="server" Text="Insert Makeup" OnClick="InsertMakeupBtnBtn_Click" />
    </div>


    <hr />
    <h1>Makeup Type</h1>
    <div>
        <asp:GridView ID="MakeupTypeGV" runat="server" AutoGenerateColumns="False" OnRowDeleting="MakeupTypeGV_RowDeleting" OnRowEditing="MakeupTypeGV_RowEditing">
            <Columns>
                <asp:BoundField DataField="MakeupTypeName" HeaderText="MakeupTypeName" SortExpression="MakeupTypeName" />
                <asp:CommandField ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ButtonType="Button" ShowHeader="True" HeaderText="Action"></asp:CommandField>
            </Columns>

        </asp:GridView>
        <br />
        <asp:Button ID="InsertTypeBtn" runat="server" Text="Insert Makeup Type" OnClick="InsertTypeBtn_Click" />
    </div>

    <hr />
    <h1>Makeup Brand</h1>
    <div>
        <asp:GridView ID="MakeupBrandGV" runat="server" AutoGenerateColumns="False" OnRowDeleting="MakeupBrandGV_RowDeleting" OnRowEditing="MakeupBrandGV_RowEditing">
            <Columns>
                <asp:BoundField DataField="MakeupBrandName" HeaderText="MakeupBrandName" SortExpression="MakeupBrandName" />
                <asp:BoundField DataField="MakeupBrandRating" HeaderText="MakeupBrandRating" SortExpression="MakeupBrandRating" />
                <asp:CommandField ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ButtonType="Button" ShowHeader="True" HeaderText="Action"></asp:CommandField>
            </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="InsertBrandBtn" runat="server" Text="Insert Makeup Brand" OnClick="InsertBrandBtn_Click" />
    </div>
</asp:Content>
