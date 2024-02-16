<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/BaseTemplate.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Week15_Esame.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <div class="container">
        <div class="row row-cols-1 row-cols-sm-2 row-cols-md-3 row-cols-lg-4 row-cols-xl-6" id="ProductsList" runat="server">
        
        </div>
    </div>
    <asp:Button ID="BtnToCart" runat="server" Text="Go to Cart" CssClass="btn btn-black" OnClick="GoToCartClick"/>

</asp:Content>
