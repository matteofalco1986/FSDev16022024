<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/BaseTemplate.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Week15_Esame.Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <h1>SHOPPING CART</h1>
    <div class="container">
        <div class="row row-cols-1 row-cols-sm-2 row-cols-md-3 row-cols-lg-4 row-cols-xl-6" id="CartList" runat="server">
        </div>
    </div>
    <asp:Button ID="BtnToHome" runat="server" Text="Back to Home Page" CssClass="btn btn-primary" OnClick="BackToHomeClick"/>


</asp:Content>
