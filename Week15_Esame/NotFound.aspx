<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/BaseTemplate.Master" AutoEventWireup="true" CodeBehind="NotFound.aspx.cs" Inherits="Week15_Esame.NotFound" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <h1>Product not found</h1>
    <asp:Button ID="BtnHome" runat="server" Text="Go back to the home page" OnClick="ToHomeClick" CssClass="btn btn-primary" />
</asp:Content>
