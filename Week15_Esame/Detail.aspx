<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/BaseTemplate.Master" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="Week15_Esame.Detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <div id="DetailContainer" runat="server">

    </div>
    <asp:Button ID="BackToHome" runat="server" Text="BackToHome" CssClass="btn btn-primary" OnClick="BackToHomeClick"/>
    <asp:Button ID="BtnDeleteProduct" runat="server" Text="Delete from Cart" CssClass="btn btn-danger" OnClick="DeleteFromCartClick"/>
    <asp:Button ID="BtnAddProduct" runat="server" Text="Add to Cart" CssClass="btn btn-success" OnClick="AddToCartClick"/>


</asp:Content>
