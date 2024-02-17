<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/BaseTemplate.Master" AutoEventWireup="true" CodeBehind="NotFound.aspx.cs" Inherits="Week15_Esame.NotFound" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <h1 class="m-3 text-center">Prodotto non trovato</h1>
    <div class="d-flex justify-content-center">
        <asp:Button ID="BtnHome" runat="server" Text="Torna alla Home" OnClick="ToHomeClick" CssClass="btn btn-primary m-3" />
    </div>
</asp:Content>
