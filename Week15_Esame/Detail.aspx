<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/BaseTemplate.Master" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="Week15_Esame.Detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <div id="DetailContainer" runat="server">
    </div>
    <div class="d-flex justify-content-center align-items-center GroupButtons">
        <asp:Button ID="BackToHome" runat="server" Text="Home" CssClass="btn btn-primary m-3" OnClick="BackToHomeClick" />
        <asp:Button ID="BtnDeleteProduct" runat="server" Text="Elimina dal carrello" CssClass="btn btn-danger m-3" OnClick="DeleteFromCartClick" />
        <asp:Button ID="BtnAddProduct" runat="server" Text="Aggiungi al carrello" CssClass="btn btn-success m-3" OnClick="AddToCartClick" />
        <asp:Button ID="BtnToCart" runat="server" Text="Carrello" CssClass="btn btn-info m-3" OnClick="GoToCartClick" />
    </div>
</asp:Content>
