<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="UpdateMakeup.aspx.cs" Inherits="MakeUpzz.Views.UpdateMakeup" %>

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

    <h1>Update Page</h1>
    <h1>Makeup ID: <%=Request.QueryString["id"] %></h1>
    <hr />

    <div class="form-container">
        <div class="form-group">
            <asp:Label ID="NameLbl" CssClass="label" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="NameTB" CssClass="input" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="PriceLbl" CssClass="label" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="PriceTB" CssClass="input" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="WeightLbl" CssClass="label" runat="server" Text="Weight"></asp:Label>
            <asp:TextBox ID="WeightTB" CssClass="input" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="MakeUpTypeIdLbl" CssClass="label" runat="server" Text="MakeUpTypeId"></asp:Label>
            <asp:DropDownList ID="MakeUpTypeDD" CssClass="input" runat="server"></asp:DropDownList>
        </div>
        <div class="form-group">
            <asp:Label ID="MakeUpBrandIdLbl" CssClass="label" runat="server" Text="MakeUpBrandId"></asp:Label>
            <asp:DropDownList ID="MakeUpBrandDD" CssClass="input" runat="server"></asp:DropDownList>
        </div>
        <div>
            <asp:Button ID="UpdateBtn" CssClass="button" runat="server" Text="Update" OnClick="UpdateBtn_Click" />
            <asp:Button ID="BackBtn" CssClass="button" runat="server" Text="Back" OnClick="BackBtn_Click" />
        </div>
        <asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>

    </div>


</asp:Content>
