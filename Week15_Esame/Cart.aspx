<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/BaseTemplate.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Week15_Esame.Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <div class="d-flex justify-content-between align-items-center">
        <h1 class="text-center m-3">SHOPPING CART</h1>
        <div class="d-flex justify-content-center">
            <asp:Button ID="BtnToHome" runat="server" Text="Home" CssClass="btn btn-primary m-3" OnClick="BackToHomeClick" />
            <asp:Button ID="BtnEmptyCart" runat="server" Text="Svuota Carrello" CssClass="btn btn-danger m-3" OnClick="EmptyCartClick" />
            <asp:Label ID="LblCartCount" runat="server" Text="" CssClass="btn btn-light m-3"></asp:Label>
        </div>

    </div>
    <div id="PageContainer" runat="server">
        <div class="container p-4">
            <div class="row row-cols-1 row-cols-sm-2 row-cols-md-3 row-cols-lg-4 row-cols-xl-6" id="CartList" runat="server">
                <asp:Repeater ID="CartRepeater" runat="server">
                    <ItemTemplate>
                        <div class="col mb-3">
                            <div class="card">
                                <img class="card-img-top p-2" src='<%# Eval("ImageUrl") %>' alt='<%# Eval("Name") %>'>
                                <div class="card-body">
                                    <h5 class="card-title"><%# Eval("Name") %></h5>
                                    <h6 class="card-text">'<%# Eval("Brand") %>'</h6>
                                    <p class="card-text"><%# Eval("Price") %> &euro;</p>
                                    <asp:Button ID="BtnDelete" runat="server" Text="Elimina dal carrello" OnClick="DeleteArticle" CommandArgument='<%# Eval("Id") %>' CssClass="btn btn-danger" />
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>

    </div>
</asp:Content>
